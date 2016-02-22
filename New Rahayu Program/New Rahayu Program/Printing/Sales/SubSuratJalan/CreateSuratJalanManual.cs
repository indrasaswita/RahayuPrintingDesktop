using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Rahayu_Program.Report;
using CrystalDecisions.Shared;

namespace Rahayu_Program.Printing.Sales.SubSuratJalan
{
    public partial class CreateSuratJalanManual : Form
    {
        MainForm main;
        List<CreateSuratJalanList> detail;
        int printingSalesID;
        string customerName, customerPhone, customerAddress;
        string companyName, companyPhone, companyAddress;

        public CreateSuratJalanManual(MainForm main, int printingSalesID)
        {
            this.main = main;
            this.printingSalesID = printingSalesID;

            InitializeComponent();
        }

        internal DataTable ExecuteQuery(string query)
        {
            return main.ExecuteQuery(query);
        }

        public void clearData()
        {
            detail.Clear();
            panelDetail.Controls.Clear();
            tbAddress.Text = "";
            tbPlatNomor.Text = "";
            tbCustomerPhone.Text = "";
            tbCustomerName.Text = "";
            tbCompanyName.Text = "";
        }

        private void CreateSuratJalanManual_Load(object sender, EventArgs e)
        {
            detail = new List<CreateSuratJalanList>();
            clearData();

            DataTable dt = ExecuteQuery("SELECT companyName, cu.address as customerAddress, cu.phone as customerPhone, co.phone2 as customerPhone2, customerName, co.address as companyAddress, co.phone as companyPhone, co.phone2 as companyPhone2, deliveryNote FROM PrintingSalesHeader psh JOIN MsCustomer cu ON psh.customerID = cu.customerID JOIN MsCompany co ON cu.companyID = co.companyID WHERE printingSalesID = '" + printingSalesID + "'");
            if (dt != null)
            {
                if (dt.Rows.Count != 0)
                {
                    customerAddress = dt.Rows[0]["customerAddress"].ToString();
                    customerPhone = dt.Rows[0]["customerPhone"].ToString();
                    string customerPhone2 = dt.Rows[0]["customerPhone2"].ToString();
                    if (customerPhone2.Trim() != "") customerPhone = customerPhone + " / " + customerPhone2;
                    customerName = dt.Rows[0]["customerName"].ToString();

                    companyAddress = dt.Rows[0]["companyAddress"].ToString();
                    companyPhone = dt.Rows[0]["companyPhone"].ToString();
                    string companyPhone2 = dt.Rows[0]["companyPhone2"].ToString();
                    if (companyPhone2.Trim() != "") companyPhone = companyPhone + " / " + companyPhone2;
                    companyName = dt.Rows[0]["companyName"].ToString();

                    tbDeliveryNote.Text = dt.Rows[0]["deliveryNote"].ToString();

                    tbAddress.Text = companyAddress;
                    tbPlatNomor.Text = "";
                    if (companyPhone.Trim() != "" && customerPhone.Trim() != "")
                        tbCustomerPhone.Text = customerPhone + "; " + companyPhone;
                    else
                        tbCustomerPhone.Text = customerPhone + companyPhone;
                    tbCustomerName.Text = customerName;
                    tbCompanyName.Text = companyName;
                    tbSalesID.Text = String.Format("{0:D10}", printingSalesID);

                    dt = ExecuteQuery("SELECT printingTitle, printingType, CONCAT(FORMAT(quantity, 0), ' ', quantityType) as quantity, material, imageSize, sidePrint, description FROM PrintingSalesDetail WHERE printingSalesID = '" + printingSalesID + "'");
                    if (dt != null)
                    {
                        if (dt.Rows.Count > 0)
                        {
                            string printingTitle, printingType, quantity, material, imageSize, sidePrint, description;
                            foreach (DataRow i in dt.Rows)
                            {
                                printingTitle = i["printingTitle"].ToString();
                                printingType = i["printingType"].ToString();
                                quantity = i["quantity"].ToString();
                                material = i["material"].ToString();
                                material = material.Trim() != "" ? "; " + material : "";
                                imageSize = i["imageSize"].ToString();
                                imageSize = imageSize.Trim() != "" ? "; " + imageSize : "";
                                sidePrint = i["sidePrint"].ToString();
                                sidePrint = sidePrint.Trim() != "" ? "; " + sidePrint : "";
                                description = i["description"].ToString();
                                description = description.Trim() != "" ? "; " + description : "";

                                //addDetailList(printingType + ", " + printingTitle, quantity + material + imageSize + sidePrint + description);
                                addDetailList(printingType + ", " + printingTitle, quantity + material + imageSize + sidePrint);
                            }
                            refreshDetail();
                        }
                    }
                }
            }
        }

        internal void addDetailList(string printingTitle, string description)
        {
            detail.Add(new CreateSuratJalanList(main, this, printingTitle, description));
        }

        private void refreshDetail()
        {
            panelDetail.Controls.Clear();
            int ix = 0;
            foreach (CreateSuratJalanList i in detail)
            {
                panelDetail.Controls.Add(i);
                i.Location = new Point(2, 2 + (ix * (i.Height + 2)));
                ix++;
            }
        }
    
        internal void deleteList(CreateSuratJalanList item)
        {
 	        detail.Remove(item);
            refreshDetail();
        }

        internal void updateList(CreateSuratJalanList item)
        {
 	        
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("printingSalesID");
            dt.Columns.Add("companyName");
            dt.Columns.Add("customerName");
            dt.Columns.Add("customerPhone");
            dt.Columns.Add("tanggalSuratJalan");
            dt.Columns.Add("platNomor");
            dt.Columns.Add("address");
            dt.Columns.Add("deliveryNote");
            dt.Columns.Add("printingTitle");
            dt.Columns.Add("description");
            foreach (CreateSuratJalanList i in detail)
            {
                dt.Rows.Add(String.Format("{0:D10}", printingSalesID), tbCompanyName.Text, tbCustomerName.Text, tbCustomerPhone.Text, dtpSuratJalan.Value.ToString("ddd, dd MMM yy - HH:mm"), tbPlatNomor.Text, tbAddress.Text, tbPesan.Text, i.printingTitle, i.description);
            }
            if (dt == null)
            {
                MessageBox.Show("ERROR PRINT SURAT JALAN (CreateSuratJalanManual.cs)");
                this.Dispose();
            }
            else
            {
                if (dt.Rows.Count > 0)
                {
                    Rahayu_Program.Report.PrintingSales.PrintingSalesSuratJalan laporan = new Rahayu_Program.Report.PrintingSales.PrintingSalesSuratJalan();

                    laporan.DataSourceConnections.Clear();
                    laporan.SetDataSource(dt);

                    buatLaporanByQuery(laporan);

                    //direct print

                    /*laporan.PrintOptions.PrinterName = System.IO.File.ReadAllText(Application.StartupPath + @"\config\printer\printing-sales-notasetengah.is");
                    laporan.PrintToPrinter(1, false, 0, 0);*/
                }
                else
                {
                    MessageBox.Show("DATA TIDAK ADA (CreateSuratJalanManual.cs)");
                }
            }
        }

        private void buatLaporanByQuery(object laporan)
        {
            ReportForm reportForm = new ReportForm(main);
            reportForm.MdiParent = main;
            reportForm.WindowState = FormWindowState.Maximized;

            reportForm.GetCrystalReportViewer().ReportSource = laporan;
            reportForm.GetCrystalReportViewer().Refresh();
            reportForm.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
