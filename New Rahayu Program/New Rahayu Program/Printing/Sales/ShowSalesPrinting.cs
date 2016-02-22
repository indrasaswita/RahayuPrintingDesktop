using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Rahayu_Program.Printing.Sales.SubSales;
using Rahayu_Program.DialogBox;
using Rahayu_Program.Report;
using Rahayu_Program.Report.PrintingSales;
using Rahayu_Program.Printing.Sales.SubSuratJalan;
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;
using Rahayu_Program.Printing.Report;

namespace Rahayu_Program.Printing.Sales
{
    public partial class ShowSalesPrinting : Form
    {
        MainForm main;
        string query = "SELECT psh.printingSalesID, mcu.customerName, mco.companyName, DATE_FORMAT(psh.salesTime, '%d/%m/%Y %H:%i:%s') AS salesTime, psh.status, (SELECT SUM(hargaMaterial + hargaOngkosCetak) FROM PrintingSalesDetail WHERE printingSalesID = psh.printingSalesID) as total, IFNULL((SELECT SUM(ammount) FROM PrintingSalesPayment WHERE printingSalesID = psh.printingSalesID), 0) as bayar FROM PrintingSalesHeader psh JOIN MsCustomer mcu ON psh.customerID = mcu.customerID JOIN MsCompany mco ON mcu.companyID = mco.companyID WHERE psh.salesTime > DATE_SUB(now(), INTERVAL 6 MONTH) ORDER BY psh.printingSalesID DESC";

        public ShowSalesPrinting(MainForm main)
        {
            this.main = main;
            this.MdiParent = main;

            InitializeComponent();
        }

        private void ShowSalesPrinting_Load(object sender, EventArgs e)
        {
            gridSalesHeader.Columns.Add("SalesID", "ID");
            gridSalesHeader.Columns[0].Width = 70;
            gridSalesHeader.Columns.Add("Customer", "Customer");
            gridSalesHeader.Columns[1].Width = 250;
            gridSalesHeader.Columns.Add("Time", "Time");
            gridSalesHeader.Columns[2].Width = 190;
            gridSalesHeader.Columns.Add("Status", "Status");
            gridSalesHeader.Columns[3].Width = 100;

            gridSalesDetail.Columns.Add("JobType", "TYP");
            gridSalesDetail.Columns[0].Width = 30;
            gridSalesDetail.Columns.Add("Jenis", "Jenis");
            gridSalesDetail.Columns[1].Width = 160;
            gridSalesDetail.Columns.Add("Judul", "Judul");
            gridSalesDetail.Columns[2].Width = 300;
            gridSalesDetail.Columns.Add("Jumlah", "Jumlah");
            gridSalesDetail.Columns[3].Width = 150;
            gridSalesDetail.Columns.Add("HargaAsli", "Hrg. Asli");
            gridSalesDetail.Columns[4].Visible = false;
            gridSalesDetail.Columns.Add("HargaMaterial", "Harga Material");
            gridSalesDetail.Columns[5].Visible = false;
            gridSalesDetail.Columns.Add("HargaOngkosCetak", "Harga Ongkos Cetak");
            gridSalesDetail.Columns[6].Visible = false;
            gridSalesDetail.Columns.Add("HargaTotal", "Harga Total");
            gridSalesDetail.Columns[7].Visible = false;
            gridSalesDetail.Columns.Add("Status", "Status");
            gridSalesDetail.Columns[8].Width = 150;

            gridSalesPayment.Columns.Add("PaymentID", "ID");
            gridSalesPayment.Columns[0].Visible = false;
            gridSalesPayment.Columns.Add("PaymentTime", "Waktu");
            gridSalesPayment.Columns[1].Width = 190;
            gridSalesPayment.Columns.Add("Ammount", "Jumlah");
            gridSalesPayment.Columns[2].Width = 105;
            gridSalesPayment.Columns.Add("Ammount2", "Jumlah2");
            gridSalesPayment.Columns[3].Visible = false;
            gridSalesPayment.Columns.Add("Method", "Metode");
            gridSalesPayment.Columns[4].Width = 100;
            gridSalesPayment.Columns.Add("Description", "Keterangan");
            gridSalesPayment.Columns[5].Width = 155;

            RefreshHeader(query);

            rbPPh23.Checked = true;
        }

        int salesID = 0;

        public void RefreshHeader()
        {
            RefreshHeader(query);
        }

        public void RefreshHeader(string qTemp)
        {
            DataTable dt = ExecuteQuery(qTemp);
            if (dt != null)
            {
                gridSalesHeader.Rows.Clear();
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow i in dt.Rows)
                    {
                        salesID = Int32.Parse(i["printingSalesID"].ToString());
                        string customer = i["customerName"].ToString();
                        string company = i["companyName"].ToString();
                        string gabung = (company.Trim() != "") ? company + "; " + customer : customer;
                        string time = i["salesTime"].ToString();
                        string status = i["status"].ToString();
                        int bayar = Int32.Parse(i["bayar"].ToString());
                        int total = Int32.Parse(i["total"].ToString());

                        gridSalesHeader.Rows.Add(String.Format("{0:D6}", salesID), gabung, time, status);
                        if (status == "SALE")
                        {
                            Color colorTemp = bayar == 0 ? Color.Orange : bayar < total ? Color.Yellow : Color.GreenYellow;
                            gridSalesHeader.Rows[gridSalesHeader.Rows.Count - 1].Cells["Status"].Style.BackColor = colorTemp;
                        }
                    }
                    //SET KE YANG PERTAMA LAGI
                    gridSalesHeader.CurrentCell = gridSalesHeader.Rows[0].Cells[0];
                    gridSalesHeader_SelectionChanged();
                }
            }
        }

        int totalHargaAsli = 0;
        int totalHargaMaterial = 0;
        int totalHargaOngkosCetak = 0;
        int totalHargaNota = 0;

        string printingType = "";
        string printingTitle = "";

        private void RefreshDetail(int selectedID)
        {
            DataTable dt = ExecuteQuery("SELECT jobType, printingType, printingTitle, quantity, quantityType, hargaAsli, hargaMaterial, hargaOngkosCetak, status FROM PrintingSalesDetail WHERE printingSalesID = '" + selectedID + "'");
            if (dt != null)
            {
                tbViewSalesID.Text = "No. Nota : " + String.Format("{0:D10}", selectedID);

                gridSalesDetail.Rows.Clear();
                if (dt.Rows.Count > 0)
                {
                    totalHargaAsli = 0;
                    totalHargaMaterial = 0;
                    totalHargaOngkosCetak = 0;
                    totalHargaNota = 0;

                    foreach (DataRow i in dt.Rows)
                    {
                        string jobType = i["jobType"].ToString();
                        string printingType = i["printingType"].ToString();
                        string printingTitle = i["printingTitle"].ToString();
                        int quantity = Int32.Parse(i["quantity"].ToString());
                        string quantityType = i["quantityType"].ToString();
                        int hargaAsli = Int32.Parse(i["hargaAsli"].ToString());
                        int hargaMaterial = Int32.Parse(i["hargaMaterial"].ToString());
                        int hargaOngkosCetak = Int32.Parse(i["hargaOngkosCetak"].ToString());
                        int hargaNota = hargaMaterial + hargaOngkosCetak;
                        string status = i["status"].ToString();

                        totalHargaAsli += hargaAsli;
                        totalHargaMaterial += hargaMaterial;
                        totalHargaOngkosCetak += hargaOngkosCetak;
                        totalHargaNota += hargaNota;

                        gridSalesDetail.Rows.Add(jobType, printingType, printingTitle, quantity.ToString("#,##0") + " " + quantityType, hargaAsli.ToString("#,##0"), hargaMaterial.ToString("#,##0"), hargaOngkosCetak.ToString("#,##0"), hargaNota.ToString("#,##0"), status);
                    }

                    tbTotalHargaAsli.Text = totalHargaAsli.ToString("#,##0");
                    tbTotalHargaMaterial.Text = totalHargaMaterial.ToString("#,##0");
                    tbTotalHargaOngkosCetak.Text = totalHargaOngkosCetak.ToString("#,##0");
                    tbTotalHargaNota.Text = totalHargaNota.ToString("#,##0");
                }
            }
        }

        private void HideButtonHeader()
        {
            btnDeleteTransaction.Visible = false;
            btnCreateTransaction.Visible = false;
            btnShowTransaction.Visible = false;
            btnPrintInvoice.Visible = false;
            btnPrintInvoiceKecil.Visible = false;
            btnPrintWO.Visible = false;
            btnTukerFaktur.Visible = false;
            btnSuratJalan.Visible = false;
            btnOFFER.Visible = false;
            btnSALE.Visible = false;
            btnPenawaranHarga.Visible = false;
            btnHutangPerCust.Visible = false;

            btnHapusBayar.Visible = false;
            btnBuatBayar.Visible = false;
            btnUbahBayar.Visible = false;
        }

        private void ShowButtonHeader(string status)
        {
            if (status == "SALE")
            {
                if (main.globalEmployeeID == 1) btnDeleteTransaction.Visible = true;
                btnCreateTransaction.Visible = true;
                btnShowTransaction.Visible = true;
                btnPrintInvoice.Visible = true;
                if (tbTotalHargaOngkosCetak.Text == "0") btnPrintInvoiceKecil.Visible = true;
                btnPrintWO.Visible = true;
                btnHutangPerCust.Visible = true;

                btnTukerFaktur.Visible = true;
                btnSuratJalan.Visible = true;
                if (main.globalEmployeeID == 1) btnOFFER.Visible = true;
                btnPenawaranHarga.Visible = true;

                btnHapusBayar.Visible = true;
                btnBuatBayar.Visible = true;
                btnUbahBayar.Visible = true;
            }
            else if (status == "OFFER")
            {
                if (main.globalEmployeeID == 1) btnDeleteTransaction.Visible = true;
                btnCreateTransaction.Visible = true;
                btnShowTransaction.Visible = true;
                btnSALE.Visible = true;
                btnPenawaranHarga.Visible = true;
                btnHutangPerCust.Visible = true;
            }
        }

        int totalBayar = 0;
        int totalBayarPalsu = 0;

        private void RefreshPayment(int selectedID)
        {
            int selectedHeaderIdx;

            totalBayar = 0;
            totalBayarPalsu = 0;

            DataTable dt = ExecuteQuery("SELECT paymentID, DATE_FORMAT(paymentTime, '%d/%m/%Y %H:%i:%s') AS paymentTime, ammount, ammount2, description, method FROM PrintingSalesPayment WHERE printingSalesID = '" + selectedID + "' ORDER BY paymentID");
            if (dt != null)
            {
                tbViewSalesID.Text = "No. Nota : " + String.Format("{0:D10}", selectedID);

                gridSalesPayment.Rows.Clear();
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow i in dt.Rows)
                    {
                        int paymentID = Int32.Parse(i["paymentID"].ToString());
                        string paymentTime = i["paymentTime"].ToString();
                        int ammount = Int32.Parse(i["ammount"].ToString());
                        int ammount2 = Int32.Parse(i["ammount2"].ToString());
                        string description = i["description"].ToString();
                        string method = i["method"].ToString();

                        totalBayar += ammount;
                        totalBayarPalsu += ammount2;

                        gridSalesPayment.Rows.Add(paymentID, paymentTime, ammount.ToString("#,##0"), ammount, method, description);
                    }

                    selectedHeaderIdx = gridSalesHeader.CurrentRow.Index;
                    tbStatusBayar.Text = (totalHargaAsli < totalBayar) ? "SALAH HARGA ASLI" : (totalHargaAsli == totalBayar) ? "LUNAS" : "KURANG BAYAR";
                    if (totalHargaAsli < totalBayar)
                    {
                        tbStatusBayar.Text = "SALAH HARGA ASLI (BAYARNYA LEBIH GEDE)";
                        pnlStatusBayar.BackColor = Color.Red;
                    }
                    else if (totalHargaAsli == totalBayar)
                    {
                        tbStatusBayar.Text = "LUNAS";
                        pnlStatusBayar.BackColor = Color.GreenYellow;
                    }
                    else
                    {
                        tbStatusBayar.Text = "KURANG BAYAR";
                        pnlStatusBayar.BackColor = Color.Yellow;
                    }
                    gridSalesHeader.Rows[selectedHeaderIdx].Cells["Status"].Style.BackColor = pnlStatusBayar.BackColor;
                }
                else
                {
                    tbStatusBayar.Text = "BELUM ADA PEMBAYARAN";
                    pnlStatusBayar.BackColor = Color.Orange;
                }
            }
            else
            {
                tbStatusBayar.Text = "DATA PEMBAYARAN ERROR - HUB BOY";
                pnlStatusBayar.BackColor = Color.Red;
            }
        }

        public DataTable ExecuteQuery(string query)
        {
            return main.ExecuteQuery(query);
        }

        private void btnRefreshHeader_Click(object sender, EventArgs e)
        {
            RefreshHeader(query);
        }

        private void gridSalesHeader_SelectionChanged(object sender, EventArgs e)
        {
            gridSalesHeader_SelectionChanged();
        }

        private void gridSalesHeader_SelectionChanged()
        {
            if (gridSalesHeader.Rows.Count > 0)
            {
                int index = gridSalesHeader.CurrentRow.Index;
                if (index >= 0 && index < gridSalesHeader.Rows.Count)
                {
                    salesID = Int32.Parse(gridSalesHeader.Rows[index].Cells["SalesID"].Value.ToString());
                    RefreshDetail(salesID);
                    RefreshPayment(salesID);
                    HideButtonHeader();
                    string status = gridSalesHeader.Rows[index].Cells["Status"].Value.ToString();
                    ShowButtonHeader(status);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void gridSalesDetail_SelectionChanged(object sender, EventArgs e)
        {
            if (gridSalesDetail.Rows.Count > 0)
            {
                int index = gridSalesDetail.CurrentRow.Index;
                if (index >= 0 && index < gridSalesDetail.Rows.Count)
                {
                    printingTitle = gridSalesDetail.Rows[index].Cells["Judul"].Value.ToString();
                    printingType = gridSalesDetail.Rows[index].Cells["Jenis"].Value.ToString();

                    tbViewHargaAsli.Text = gridSalesDetail.Rows[index].Cells["HargaAsli"].Value.ToString();
                    tbViewHargaMaterial.Text = gridSalesDetail.Rows[index].Cells["HargaMaterial"].Value.ToString();
                    tbViewHargaOngkosCetak.Text = gridSalesDetail.Rows[index].Cells["HargaOngkosCetak"].Value.ToString();
                    tbViewHargaTotal.Text = gridSalesDetail.Rows[index].Cells["HargaTotal"].Value.ToString();
                }
            }
        }

        private void btnBuatBayar_Click(object sender, EventArgs e)
        {
            int sisaBayar = totalHargaAsli - totalBayar;
            sisaBayar = sisaBayar < 0 ? 0 : sisaBayar;

            int sisaBayarPalsu = totalHargaNota - totalBayarPalsu;
            sisaBayarPalsu = sisaBayarPalsu < 0 ? 0 : sisaBayarPalsu;
            CreateSalesPayment createSalesPayment = new CreateSalesPayment(main, salesID, sisaBayar, sisaBayarPalsu);
            DialogResult result = createSalesPayment.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                RefreshPayment(salesID);
            }
        }

        private void btnFileSiap_Click(object sender, EventArgs e)
        {
            setStatus("File Siap Cetak");
        }

        private void btnSudahCetak_Click(object sender, EventArgs e)
        {
            setStatus("Selesai Cetak");
        }

        private void btnSudahFinishing_Click(object sender, EventArgs e)
        {
            setStatus("Selesai Finishing");
        }

        private void btnSudahPacking_Click(object sender, EventArgs e)
        {
            setStatus("Selesai Packaging");
        }

        private void btnSudahSelesai_Click(object sender, EventArgs e)
        {
            setStatus("Sudah Diambil / Dikirim");
        }

        private void setStatus(string status)
        {
            ExecuteQuery("UPDATE PrintingSalesDetail SET Status = '" + status + "' WHERE printingSalesID = '" +
                salesID + "' AND printingType = '" + printingType + "' AND printingTitle = '" + printingTitle + "'");
            int index = gridSalesDetail.CurrentRow.Index;
            if (index >= 0 && index < gridSalesDetail.Rows.Count)
            {
                gridSalesDetail.Rows[index].Cells["status"].Value = status;
            }
        }

        private void btnUbahBayar_Click(object sender, EventArgs e)
        {
            if (gridSalesPayment.Rows.Count > 0)
            {
                int index = gridSalesPayment.CurrentRow.Index;
                if (index >= 0 && index < gridSalesPayment.Rows.Count)
                {
                    int paymentID = Int32.Parse(gridSalesPayment.Rows[index].Cells["PaymentID"].Value.ToString());
                    DateTime paymentTime = Other.Parser.TimeFromString(gridSalesPayment.Rows[index].Cells["PaymentTime"].Value.ToString());
                    int ammount = Int32.Parse(gridSalesPayment.Rows[index].Cells["Ammount"].Value.ToString().Replace(".", "").Replace(",", "").Trim());
                    int ammount2 = Int32.Parse(gridSalesPayment.Rows[index].Cells["Ammount2"].Value.ToString().Trim());
                    string method = gridSalesPayment.Rows[index].Cells["Method"].Value.ToString();

                    ChangePaymentSalesPrinting changePayment = new ChangePaymentSalesPrinting(main, salesID, paymentID, paymentTime, ammount, ammount2, method);
                    DialogResult result = changePayment.ShowDialog();
                    if (result == System.Windows.Forms.DialogResult.OK)
                    {
                        RefreshPayment(salesID);
                    }
                }
            }
        }

        private void btnCreateTransaction_Click(object sender, EventArgs e)
        {
            main.openCreateSalesPrinting();
        }

        private void btnDeleteTransaction_Click(object sender, EventArgs e)
        {
            if (gridSalesHeader.Rows.Count > 0)
            {
                int index = gridSalesHeader.CurrentRow.Index;
                if (index >= 0 && index < gridSalesHeader.Rows.Count)
                {
                    AnsBox ans = new AnsBox(main, "Yakin di HAPUS?", "WARNING!");
                    DialogResult result = ans.ShowDialog();
                    if (result == System.Windows.Forms.DialogResult.OK)
                    {
                        int salesID = Int32.Parse(gridSalesHeader.Rows[index].Cells["SalesID"].Value.ToString());
                        ExecuteQuery("DELETE FROM PrintingSalesHeader WHERE printingSalesID = '" + salesID + "'");
                        ExecuteQuery("DELETE FROM PrintingSalesDetail WHERE printingSalesID = '" + salesID + "'");
                        ExecuteQuery("DELETE FROM PrintingSalesDetailFinishing WHERE printingSalesID = '" + salesID + "'");
                        ExecuteQuery("DELETE FROM PrintingSalesDetailFile WHERE printingSalesID = '" + salesID + "'");
                        ExecuteQuery("DELETE FROM PrintingSalesPayment WHERE printingSalesID = '" + salesID + "'");
                        ExecuteQuery("DELETE FROM PrintingSalesDelivery WHERE printingSalesID = '" + salesID + "'");

                        RefreshHeader(query);
                        main.SetMessage("PrintingSalesID -> " + salesID + " has been deleted.");
                    }
                }
            }
        }

        private int GetHeaderIndex()
        {
            if (gridSalesHeader.Rows.Count > 0)
            {
                int index = gridSalesHeader.CurrentRow.Index;
                if (index >= 0 && index < gridSalesHeader.Rows.Count)
                {
                    return index;
                }
            }
            return -1;
        }

        private void btnShowTransaction_Click(object sender, EventArgs e)
        {
            int index = GetHeaderIndex();
            if (index != -1)
            {
                int salesID = Int32.Parse(gridSalesHeader.Rows[index].Cells["SalesID"].Value.ToString());
                main.openCreateSalesPrinting(salesID);
            }
            else
                main.SetMessage("NO HEADER SELECTED");
        }

        private void btnHapusBayar_Click(object sender, EventArgs e)
        {
            if (gridSalesPayment.Rows.Count > 0)
            {
                int index = gridSalesPayment.CurrentRow.Index;
                if (index >= 0 && index < gridSalesPayment.Rows.Count)
                {
                    AnsBox ans = new AnsBox(main, "Yakin di HAPUS?", "WARNING!");
                    DialogResult result = ans.ShowDialog();
                    if (result == System.Windows.Forms.DialogResult.OK)
                    {
                        ExecuteQuery("DELETE FROM PrintingSalesPayment WHERE printingSalesID = '" + salesID + "' AND paymentID = '" + gridSalesPayment.Rows[index].Cells["PaymentID"].Value.ToString() + "'");
                        main.SetMessage("Pembayaran dengan SalesID : " + salesID + " (kode pembayaran : " + gridSalesPayment.Rows[index].Cells["PaymentID"].Value.ToString() + ") telah di HAPUS");
                        RefreshPayment(salesID);
                    }
                }
            }
        }

        internal void setSelectedPrintingSalesID(int salesID)
        {
            RefreshHeader(query);
            foreach (DataGridViewRow i in gridSalesHeader.Rows)
            {
                //bisa di ganti dengan binary search nih, soalnya nomornya urut
                if (Int32.Parse(i.Cells[0].Value.ToString()) == salesID)
                {
                    gridSalesHeader.CurrentCell = gridSalesHeader.Rows[i.Index].Cells[0];
                    break;
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

        private void buatLaporanByQuery(object laporan, string subjekPPh)
        {
            ReportForm reportForm = new ReportForm(main);
            reportForm.MdiParent = main;
            reportForm.WindowState = FormWindowState.Maximized;

            ParameterField field1 = new ParameterField();
            ParameterDiscreteValue value1 = new ParameterDiscreteValue();
            field1.Name = "SubjekPPH";
            value1.Value = subjekPPh;
            field1.CurrentValues.Add(value1);

            ParameterFields fields = new ParameterFields();
            fields.Add(field1);

            reportForm.GetCrystalReportViewer().ReportSource = laporan;
            reportForm.GetCrystalReportViewer().ParameterFieldInfo = fields;
            reportForm.GetCrystalReportViewer().Refresh();

            reportForm.Show();
        }

        private void btnPrintInvoice_Click(object sender, EventArgs e)
        {
            DataTable dt = main.ExecuteQuery("SELECT psh.printingSalesID, salesTime, "
                    + "parentCompanyName, companyName, customerName, "
                    + "tempo, purchaseOrderID as noPO, psd.printingType, psd.printingTitle, "
                    + "jobType, CONCAT(quantity, ' ', quantityType) as quantity, "
                    + "CONCAT(material, '; ', imageSize, '; ', sidePrint, '; ', psd.description) as description, "
                    + "hargaMaterial, hargaOngkosCetak "
                + "FROM PrintingSalesHeader psh "
                    + "LEFT JOIN PrintingSalesDetail psd ON psh.printingSalesID = psd.printingSalesID "
                    + "LEFT JOIN MsCustomer cu ON cu.customerID = psh.customerID "
                    + "LEFT JOIN MsCompany co ON co.companyID = cu.companyID "
                    + "LEFT JOIN MsParentCompany pc ON co.parentCompanyID = pc.parentCompanyID "
                + "WHERE psh.printingSalesID = '" + salesID + "'");

            DataTable dtSub = main.ExecuteQuery("SELECT * FROM PrintingSalesPayment WHERE printingSalesID = '" + salesID + "'");
            DataTable dtSub2 = main.ExecuteQuery("SELECT printingSalesID, printingType, printingTitle, finishingType, detail as descriptionFinishing FROM PrintingSalesDetailFinishing WHERE printingSalesID = '" + salesID + "'");

            if (dt == null)
            {
                MessageBox.Show("ERROR PRINT REPORT (LAPORAN HARIAN DI CLOSING FORM STATIONERY)");
                this.Dispose();
            }
            else
            {
                if (dt.Rows.Count > 0)
                {
                    Rahayu_Program.Report.PrintingSales.PrintingSalesInvoice laporan = new Rahayu_Program.Report.PrintingSales.PrintingSalesInvoice();

                    laporan.SetDataSource(dt);
                    laporan.SetParameterValue("SubjekPPH", rbPPh21.Checked ? "Subjek PPh 21" : "Subjek PPh 23");

                    laporan.Subreports["PrintingSalesSubReportPayment.rpt"].DataSourceConnections.Clear();
                    if (dtSub.Rows.Count > 0) laporan.Subreports["PrintingSalesSubReportPayment.rpt"].SetDataSource(dtSub);
                    laporan.Subreports["PrintingSalesSubReportFinishing.rpt"].DataSourceConnections.Clear();
                    if (dtSub2.Rows.Count > 0) laporan.Subreports["PrintingSalesSubReportFinishing.rpt"].SetDataSource(dtSub2);

                    buatLaporanByQuery(laporan, rbPPh21.Checked ? "Subjek PPh 21" : "Subjek PPh 23");

                    //direct print
                    /*laporan.PrintOptions.PrinterName = System.IO.File.ReadAllText(Application.StartupPath + @"\config\printer\printing-sales-notasetengah.is");
                    laporan.PrintToPrinter(1, false, 0, 0);*/
                }
                else
                {
                    MessageBox.Show("DATA TIDAK ADA (LAPORAN HARIAN DI CLOSING FORM STATIONERY)");
                }
            }
        }

        private void btnPrintWO_Click(object sender, EventArgs e)
        {
            DataTable dt = main.ExecuteQuery("SELECT psh.printingSalesID, salesTime, "
                    + "parentCompanyName, companyName, customerName, "
                    + "purchaseOrderID, deliveryNote, printingType, printingTitle, "
                    + "jobType, CONCAT(FORMAT(quantity,0), ' ', quantityType) as quantity, "
                    + "CONCAT(FORMAT(inschiet,0), ' ', inschietType) as inschiet, material, paperSize, "
                    + "imageSize, sidePrint, totalPlat, description, deadline, note "
                + "FROM PrintingSalesHeader psh "
                    + "LEFT JOIN PrintingSalesDetail psd ON psh.printingSalesID = psd.printingSalesID "
                    + "LEFT JOIN MsCustomer cu ON cu.customerID = psh.customerID "
                    + "LEFT JOIN MsCompany co ON co.companyID = cu.companyID "
                    + "LEFT JOIN MsParentCompany pc ON co.parentCompanyID = pc.parentCompanyID "
                + "WHERE psh.printingSalesID = '" + salesID + "'");

            DataTable dtSub2 = main.ExecuteQuery("SELECT printingSalesID, printingType, printingTitle, finishingType, detail as descriptionFinishing FROM PrintingSalesDetailFinishing WHERE printingSalesID = '" + salesID + "'");

            if (dt == null)
            {
                MessageBox.Show("ERROR PRINT REPORT (LAPORAN HARIAN DI CLOSING FORM STATIONERY)");
                this.Dispose();
            }
            else
            {
                if (dt.Rows.Count > 0)
                {
                    Rahayu_Program.Report.PrintingSales.PrintingSalesWorkOrder laporan = new Rahayu_Program.Report.PrintingSales.PrintingSalesWorkOrder();

                    foreach (DataRow i in dt.Rows)
                    {
                        AnsBox ans = new AnsBox(main, i["printingType"].ToString() + ", " + i["printingTitle"].ToString() + ", cetak?");
                        DialogResult result = ans.ShowDialog();
                        if (result == System.Windows.Forms.DialogResult.OK)
                        {
                            laporan.DataSourceConnections.Clear();
                            laporan.SetDataSource(dt);
                            laporan.Subreports["PrintingSalesSubReportFinishing.rpt"].DataSourceConnections.Clear();
                            if (dtSub2.Rows.Count > 0) laporan.Subreports["PrintingSalesSubReportFinishing.rpt"].SetDataSource(dtSub2);

                            //buatLaporanByQuery(laporan);

                            //direct print
                            laporan.PrintOptions.PrinterName = System.IO.File.ReadAllText(Application.StartupPath + @"\config\printer\printing-sales-wo.is");
                            laporan.PrintToPrinter(1, false, 0, 0);
                        }
                        else
                        {
                            ans = new AnsBox(main, "batal cetak WO?");
                            result = ans.ShowDialog();
                            if (result == System.Windows.Forms.DialogResult.OK)
                            {
                                break;
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("DATA TIDAK ADA (LAPORAN HARIAN DI CLOSING FORM STATIONERY)");
                }
            }
        }

        CreateSuratJalanManual suratJalanForm;

        private void btnSuratJalan_Click(object sender, EventArgs e)
        {
            int index = GetHeaderIndex();
            if (index != -1)
            {
                int salesID = Int32.Parse(gridSalesHeader.Rows[index].Cells["SalesID"].Value.ToString());
                suratJalanForm = new CreateSuratJalanManual(main, salesID);
                suratJalanForm.ShowDialog();
            }
            else
            {
                main.SetMessage("HEADER BELUM DI PILIH");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = main.ExecuteQuery("SELECT psh.printingSalesID, salesTime, "
                    + "parentCompanyName, companyName, customerName, "
                    + "tempo, purchaseOrderID, psd.printingType, psd.printingTitle, "
                    + "jobType, CONCAT(quantity, ' ', quantityType) as quantity, "
                    + "CONCAT(material, '; ', imageSize, '; ', sidePrint, '; ', psd.description) as description, "
                    + "hargaMaterial, hargaOngkosCetak "
                + "FROM PrintingSalesHeader psh "
                    + "LEFT JOIN PrintingSalesDetail psd ON psh.printingSalesID = psd.printingSalesID "
                    + "LEFT JOIN MsCustomer cu ON cu.customerID = psh.customerID "
                    + "LEFT JOIN MsCompany co ON co.companyID = cu.companyID "
                    + "LEFT JOIN MsParentCompany pc ON co.parentCompanyID = pc.parentCompanyID "
                + "WHERE psh.printingSalesID = '" + salesID + "'");

            DataTable dtSub = main.ExecuteQuery("SELECT * FROM PrintingSalesPayment WHERE printingSalesID = '" + salesID + "'");

            if (dt == null)
            {
                MessageBox.Show("ERROR PRINT REPORT (LAPORAN HARIAN DI CLOSING FORM STATIONERY)");
                this.Dispose();
            }
            else
            {
                if (dt.Rows.Count > 0)
                {
                    Rahayu_Program.Report.PrintingSales.PrintingSalesInvoiceKecil laporan = new Rahayu_Program.Report.PrintingSales.PrintingSalesInvoiceKecil();

                    laporan.SetDataSource(dt);

                    laporan.Subreports["PrintingSalesSubReportPayment.rpt"].DataSourceConnections.Clear();
                    if (dtSub.Rows.Count > 0) laporan.Subreports["PrintingSalesSubReportPayment.rpt"].SetDataSource(dtSub);

                    //buatLaporanByQuery(laporan);

                    //direct print
                    laporan.PrintOptions.PrinterName = System.IO.File.ReadAllText(Application.StartupPath + @"\config\printer\printing-sales-notakecil.is");
                    laporan.PrintToPrinter(1, false, 0, 0);
                }
                else
                {
                    MessageBox.Show("DATA TIDAK ADA (LAPORAN HARIAN DI CLOSING FORM STATIONERY)");
                }
            }
        }

        private void btnTukerFaktur_Click(object sender, EventArgs e)
        {
            main.ShowCreateTandaTerima();
        }

        private void btnSALE_Click(object sender, EventArgs e)
        {
            int index = GetHeaderIndex();
            if (index != -1)
            {
                int salesID = Int32.Parse(gridSalesHeader.Rows[index].Cells["SalesID"].Value.ToString());
                gridSalesHeader.Rows[index].Cells["Status"].Value = "SALE";
                ExecuteQuery("UPDATE PrintingSalesHeader SET status = 'SALE' WHERE printingSalesID = '" + salesID + "'");
                main.SetMessage("UPDATE Status SUKSES");
                HideButtonHeader();
                string status = gridSalesHeader.Rows[index].Cells["Status"].Value.ToString();
                ShowButtonHeader(status);
            }
            else
                main.SetMessage("NO HEADER SELECTED");
        }

        private void btnOFFER_Click(object sender, EventArgs e)
        {
            int index = GetHeaderIndex();
            if (index != -1)
            {
                int salesID = Int32.Parse(gridSalesHeader.Rows[index].Cells["SalesID"].Value.ToString());
                gridSalesHeader.Rows[index].Cells["Status"].Value = "OFFER";
                ExecuteQuery("UPDATE PrintingSalesHeader SET status = 'OFFER' WHERE printingSalesID = '" + salesID + "'");
                main.SetMessage("UPDATE Status SUKSES");
                HideButtonHeader();
                string status = gridSalesHeader.Rows[index].Cells["Status"].Value.ToString();
                ShowButtonHeader(status);
            }
            else
                main.SetMessage("NO HEADER SELECTED");
        }

        private void btnPenawaran_Click(object sender, EventArgs e)
        {
            DataTable dt = main.ExecuteQuery("SELECT psh.printingSalesID as printingOfferingID, salesTime as offeringTime, "
                    + "parentCompanyName, companyName, customerName, "
                    + "IF(DATEDIFF(tempo, salesTime) <= 0, '-', CONCAT(DATEDIFF(tempo, salesTime), ' hari')) AS tempo , purchaseOrderID, psd.printingType, psd.printingTitle, "
                    + "jobType, CONCAT(FORMAT(quantity, 0), ' ', quantityType) as quantity, "
                    + "CONCAT(material, '; ', imageSize, '; ', sidePrint, '; ', psd.description) as description, "
                    + "hargaMaterial, hargaOngkosCetak "
                + "FROM PrintingSalesHeader psh "
                    + "LEFT JOIN PrintingSalesDetail psd ON psh.printingSalesID = psd.printingSalesID "
                    + "LEFT JOIN MsCustomer cu ON cu.customerID = psh.customerID "
                    + "LEFT JOIN MsCompany co ON co.companyID = cu.companyID "
                    + "LEFT JOIN MsParentCompany pc ON co.parentCompanyID = pc.parentCompanyID "
                + "WHERE psh.printingSalesID = '" + salesID + "'");

            DataTable dtSub = main.ExecuteQuery("SELECT printingSalesID, printingType, printingTitle, finishingType, detail as descriptionFinishing FROM PrintingSalesDetailFinishing WHERE printingSalesID = '" + salesID + "'");

            if (dt == null)
            {
                MessageBox.Show("ERROR PRINT REPORT (LAPORAN HARIAN DI CLOSING FORM STATIONERY)");
                this.Dispose();
            }
            else
            {
                if (dt.Rows.Count > 0)
                {
                    Rahayu_Program.Report.PrintingSales.PrintingOfferingLetter laporan = new Rahayu_Program.Report.PrintingSales.PrintingOfferingLetter();

                    laporan.SetDataSource(dt);
                    laporan.SetParameterValue("SubjekPPH", rbPPh21.Checked ? "Subjek PPh 21" : "Subjek PPh 23");

                    laporan.Subreports["PrintingSalesSubReportFinishing.rpt"].DataSourceConnections.Clear();
                    if (dtSub.Rows.Count > 0) laporan.Subreports["PrintingSalesSubReportFinishing.rpt"].SetDataSource(dtSub);

                    buatLaporanByQuery(laporan, rbPPh21.Checked ? "Subjek PPh 21" : "Subjek PPh 23");
                }
                else
                {
                    MessageBox.Show("DATA TIDAK ADA (LAPORAN HARIAN DI CLOSING FORM STATIONERY)");
                }
            }
        }

        private void btnSearchHeader_Click(object sender, EventArgs e)
        {
            FilterShowSales filter = new FilterShowSales(main);
            DialogResult result = filter.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                RefreshHeader(main.globalQuery);
            }
        }

        private void btnHutangPerCust_Click(object sender, EventArgs e)
        {
            HutangPerCustomer hutangCustomer = new HutangPerCustomer(main);
            hutangCustomer.Show();
            hutangCustomer.BringToFront();
            hutangCustomer.ClearAll();
        }

        string searchOn = "";

        private void btnCompany_Click(object sender, EventArgs e)
        {
            searchOn = "COMPANY";
            btnCompany.BackColor = Color.GreenYellow;
            btnCustomer.BackColor = Color.Red;
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            searchOn = "CUSTOMER";
            btnCompany.BackColor = Color.Red;
            btnCustomer.BackColor = Color.GreenYellow;
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            if (searchOn == "COMPANY")
            {
                RefreshHeader("SELECT psh.printingSalesID, mcu.customerName, mco.companyName, DATE_FORMAT(psh.salesTime, '%d/%m/%Y %H:%i:%s') AS salesTime, psh.status, (SELECT SUM(hargaMaterial + hargaOngkosCetak) FROM PrintingSalesDetail WHERE printingSalesID = psh.printingSalesID) as total, IFNULL((SELECT SUM(ammount) FROM PrintingSalesPayment WHERE printingSalesID = psh.printingSalesID), 0) as bayar FROM PrintingSalesHeader psh JOIN MsCustomer mcu ON psh.customerID = mcu.customerID JOIN MsCompany mco ON mcu.companyID = mco.companyID WHERE companyName LIKE '%" + tbCari.Text + "%' AND psh.salesTime > DATE_SUB(now(), INTERVAL 6 MONTH) ORDER BY psh.printingSalesID DESC");
            }
            else if (searchOn == "CUSTOMER")
            {
                RefreshHeader("SELECT psh.printingSalesID, mcu.customerName, mco.companyName, DATE_FORMAT(psh.salesTime, '%d/%m/%Y %H:%i:%s') AS salesTime, psh.status, (SELECT SUM(hargaMaterial + hargaOngkosCetak) FROM PrintingSalesDetail WHERE printingSalesID = psh.printingSalesID) as total, IFNULL((SELECT SUM(ammount) FROM PrintingSalesPayment WHERE printingSalesID = psh.printingSalesID), 0) as bayar FROM PrintingSalesHeader psh JOIN MsCustomer mcu ON psh.customerID = mcu.customerID JOIN MsCompany mco ON mcu.companyID = mco.companyID WHERE customerName LIKE '%" + tbCari.Text + "%' AND psh.salesTime > DATE_SUB(now(), INTERVAL 6 MONTH) ORDER BY psh.printingSalesID DESC");
            }
            else
            {
                main.SetMessage("SELECT FILTER FIRST");
            }
        }

        private void tbCari_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnCari_Click(sender, e);
            }
        }
    }
}
