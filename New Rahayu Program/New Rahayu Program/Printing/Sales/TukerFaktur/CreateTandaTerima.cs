using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Rahayu_Program.Master.Customer;
using Rahayu_Program.Report;
using CrystalDecisions.Shared;

namespace Rahayu_Program.Printing.Sales.TukerFaktur
{
    public partial class CreateTandaTerima : Form
    {
        MainForm main;

        public CreateTandaTerima(MainForm main)
        {
            this.main = main;
            this.MdiParent = main;

            InitializeComponent();
        }

        public DataTable ExecuteQuery(string query)
        {
            return main.ExecuteQuery(query);
        }

        private void CreateTandaTerima_Load(object sender, EventArgs e)
        {
            gridHeader.Columns.Add("SalesID", "#Job");
            gridHeader.Columns["SalesID"].Width = 80;
            gridHeader.Columns.Add("Tempo", "Tempo");
            gridHeader.Columns["Tempo"].Width = 150;
            gridHeader.Columns.Add("Customer", "Customer");
            gridHeader.Columns["Customer"].Width = 400;
            gridHeader.Columns.Add("SalesTime", "Tgl. Nota");
            gridHeader.Columns["SalesTime"].Width = 190;
            gridHeader.Columns.Add("Status", "Status");
            gridHeader.Columns["Status"].Width = 260;
            gridHeader.Columns.Add("TotalBelanja", "TotalBelanja");
            gridHeader.Columns["TotalBelanja"].Visible = false;

            gridCart.Columns.Add("SalesID", "#Job");
            gridCart.Columns["SalesID"].Width = 130;
            gridCart.Columns.Add("Tempo", "Tempo");
            gridCart.Columns["Tempo"].Width = 200;
            gridCart.Columns.Add("TotalBelanja", "TotalBelanja");
            gridCart.Columns["TotalBelanja"].Visible = false;
        }

        private int customerID, companyID, parentCompanyID;

        private void btnSearchCustomer_Click(object sender, EventArgs e)
        {
            SearchCustomerPVC searchCust = new SearchCustomerPVC(main);
            DialogResult result = searchCust.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                ClearData();

                parentCompanyID = main.globalParentCompanyID;
                companyID = main.globalCompanyID;
                customerID = main.globalCustomerID;

                DataTable dt = ExecuteQuery("SELECT companyName, phone FROM MsCompany WHERE companyID = " + companyID + "");
                tbCustomerCompany.Text = dt.Rows[0]["companyName"].ToString();
                dt = ExecuteQuery("SELECT customerName, phone FROM MsCustomer WHERE customerID = " + customerID + "");
                tbCustomerName.Text = dt.Rows[0]["customerName"].ToString();
                tbCustomerPhone.Text = dt.Rows[0]["phone"].ToString();

                refreshHeader(ckbJatuhTempo.Checked, ckbLunas.Checked);
            }
        }

        private void refreshHeader(Boolean temp, Boolean luna)
        {
            string query = "SELECT printingSalesID, DATE_FORMAT(tempo, '%d/%m/%Y %H:%i:%s') AS tempo, customerName, companyName, DATE_FORMAT(salesTime, '%d/%m/%Y %H:%i:%s') AS salesTime, '' as status, IFNULL((SELECT SUM(ammount) FROM PrintingSalesPayment psp WHERE psp.printingSalesID = psh.printingSalesID), 0) as totalPayment, IFNULL((SELECT SUM(hargaMaterial + hargaOngkosCetak) FROM PrintingSalesDetail psd WHERE psd.printingSalesID = psh.printingSalesID), 0) as totalBelanja FROM PrintingSalesHeader psh JOIN MsCustomer cu ON psh.customerID = cu.customerID JOIN MsCompany co ON cu.companyID = co.companyID WHERE co.companyID = '" + companyID + "' AND psh.status = 'SALE' ";
            string lunasY = " AND IFNULL((SELECT SUM(ammount) FROM PrintingSalesPayment psp WHERE psp.printingSalesID = psh.printingSalesID), 0) >= IFNULL((SELECT SUM(hargaMaterial + hargaOngkosCetak) FROM PrintingSalesDetail psd WHERE psd.printingSalesID = psh.printingSalesID), 0) ";
            string lunasX = " AND IFNULL((SELECT SUM(ammount) FROM PrintingSalesPayment psp WHERE psp.printingSalesID = psh.printingSalesID), 0) < IFNULL((SELECT SUM(hargaMaterial + hargaOngkosCetak) FROM PrintingSalesDetail psd WHERE psd.printingSalesID = psh.printingSalesID), 0) ";
            string tempoY = " AND tempo < now() ";
            string tempoX = " AND tempo >= now() ";
            string order = " ORDER BY tempo DESC";
            string q = query + (temp ? tempoY : tempoX) + (luna ? lunasY : lunasX) + order;
            DataTable dt = ExecuteQuery(q);

            gridHeader.Rows.Clear();

            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow i in dt.Rows)
                    {
                        int salesID = Int32.Parse(i["printingSalesID"].ToString());
                        DateTime tempo = Other.Parser.TimeFromString(i["tempo"].ToString());
                        DateTime salesTime = Other.Parser.TimeFromString(i["salesTime"].ToString());
                        string customerName = i["customerName"].ToString();
                        string companyName = i["companyName"].ToString();
                        int totalBayar = Int32.Parse(i["totalPayment"].ToString());
                        int totalBelanja = Int32.Parse(i["totalBelanja"].ToString());
                        string status = i["status"].ToString();
                        if (status == "")
                        {
                            if (totalBayar == 0)
                                status = "Belum ada pembayaran";
                            else if (totalBayar < totalBelanja)
                                status = "Masih ada kekurangan bayar";
                            else if (totalBayar == totalBelanja)
                                status = "LUNAS"; //jangan pake tulisan kecil, karena reference ke bawh, kalo lunas ga bisa di add
                            else
                                status = "ERROR, panggil boy!";
                        }

                        gridHeader.Rows.Add(String.Format("{0:D7}", salesID), tempo.ToString("ddd, dd/MM/yy"), companyName + "; " + customerName, salesTime.ToString("ddd, dd/MM/yy HH:mm"), status, totalBelanja);
                    }
                }
            }
            
        }

        internal void ClearData()
        {
            gridHeader.Rows.Clear();
            gridCart.Rows.Clear();

            tbCustomerCompany.Text = "";
            tbCustomerName.Text = "";
            tbCustomerPhone.Text = "";

            ckbJatuhTempo.Checked = true;
            ckbLunas.Checked = false;

            refreshHeader(ckbJatuhTempo.Checked, ckbLunas.Checked);
        }

        private void ckbLunas_CheckedChanged()
        {
            refreshHeader(ckbJatuhTempo.Checked, ckbLunas.Checked);
        }

        private void ckbJatuhTempo_CheckedChanged()
        {
            refreshHeader(ckbJatuhTempo.Checked, ckbLunas.Checked);
        }

        private void ckbLunas_CheckedChanged(object sender, EventArgs e)
        {
            ckbLunas_CheckedChanged();
        }

        private void ckbJatuhTempo_CheckedChanged(object sender, EventArgs e)
        {
            ckbJatuhTempo_CheckedChanged();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (gridHeader.Rows.Count > 0)
            {
                int index = gridHeader.CurrentRow.Index;
                if (index >= 0 && index < gridHeader.Rows.Count)
                {
                    string salesID = gridHeader.Rows[index].Cells["SalesID"].Value.ToString();
                    string status = gridHeader.Rows[index].Cells["SalesID"].Value.ToString();
                    if (status == "LUNAS")
                    {
                        main.SetMessage("Sudah Lunas, tidak bisa di tagih lagi..");
                    }
                    else if (IsAlreadyInCart(salesID))
                    {
                        main.SetMessage("Data sudah di add sebelumnya!");
                    }
                    else
                    {
                        string tempo = gridHeader.Rows[index].Cells["Tempo"].Value.ToString();
                        string totalBelanja = gridHeader.Rows[index].Cells["TotalBelanja"].Value.ToString();
                        gridCart.Rows.Add(salesID, tempo, totalBelanja);
                    }
                    if (index != gridHeader.Rows.Count - 1)
                    {
                        gridHeader.CurrentCell = gridHeader.Rows[index + 1].Cells[0];
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (gridCart.Rows.Count > 0)
            {
                int index = gridCart.CurrentRow.Index;
                if (index >= 0 && index < gridCart.Rows.Count)
                {
                    gridCart.Rows.RemoveAt(index);
                }
            }
        }

        private Boolean IsAlreadyInCart(string salesID)
        {
            if (gridCart.Rows.Count == 0)
            {
                return false;
            }
            else
            {
                foreach (DataGridViewRow i in gridCart.Rows)
                {
                    if (Int32.Parse(i.Cells["SalesID"].Value.ToString().Trim()) == Int32.Parse(salesID.Trim()))
                    {
                        return true;
                    }
                }
                return false;
            }
        }

        private void btnTandaTrima_Click(object sender, EventArgs e)
        {
            if (tbCustomerCompany.Text != "")
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("printingSalesID", System.Type.GetType("System.Int32"));
                dt.Columns.Add("tempo", System.Type.GetType("System.String"));
                dt.Columns.Add("totalBelanja", System.Type.GetType("System.Int32"));
                foreach (DataGridViewRow i in gridCart.Rows)
                {
                    Decimal salesID = Decimal.Parse(i.Cells["SalesID"].Value.ToString().Trim());
                    string tempo = i.Cells["Tempo"].Value.ToString();
                    Decimal totalBelanja = Decimal.Parse(i.Cells["TotalBelanja"].Value.ToString().Trim());
                    dt.Rows.Add(salesID, tempo, totalBelanja);
                }
                if (dt == null)
                {
                    MessageBox.Show("ERROR PRINT TANDA TERIMA (CreateTandaTerima.cs)");
                    this.Dispose();
                }
                else
                {
                    if (dt.Rows.Count > 0)
                    {
                        Rahayu_Program.Report.PrintingSales.PrintingSalesTandaTerima laporan = new Rahayu_Program.Report.PrintingSales.PrintingSalesTandaTerima();

                        laporan.DataSourceConnections.Clear();
                        laporan.SetParameterValue("companyName", tbCustomerCompany.Text);
                        laporan.SetDataSource(dt);

                        buatLaporanByQuery(laporan, tbCustomerCompany.Text);

                        //direct print
                        /*laporan.PrintOptions.PrinterName = System.IO.File.ReadAllText(Application.StartupPath + @"\config\printer\printing-sales-wo.is");
                        laporan.PrintToPrinter(1, false, 0, 0);*/
                    }
                    else
                    {
                        MessageBox.Show("DATA TIDAK ADA (CreateSuratJalanManual.cs)");
                    }
                }
            }
            else
            {
                main.SetMessage("TIDAK ADA NAMA COMPANY, GA BISA PRINT!");
            }
        }

        private void buatLaporanByQuery(object laporan, string companyName)
        {
            ReportForm reportForm = new ReportForm(main);
            reportForm.MdiParent = main;
            reportForm.WindowState = FormWindowState.Maximized;

            ParameterField field1 = new ParameterField();
            ParameterDiscreteValue value1 = new ParameterDiscreteValue();
            field1.Name = "companyName";
            value1.Value = companyName;
            field1.CurrentValues.Add(value1);

            ParameterFields fields = new ParameterFields();
            fields.Add(field1);

            reportForm.GetCrystalReportViewer().ReportSource = laporan;
            reportForm.GetCrystalReportViewer().ParameterFieldInfo = fields;
            reportForm.GetCrystalReportViewer().Refresh();
            reportForm.Show();
        }
    }
}
