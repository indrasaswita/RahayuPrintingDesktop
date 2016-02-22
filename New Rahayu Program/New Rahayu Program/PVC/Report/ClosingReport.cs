using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Rahayu_Program.Report;

namespace Rahayu_Program.PVC.Report
{
    public partial class ClosingReport : Form
    {
        private DateTime awal, akhir;
        private int idAwal, idAkhir;
        private MainForm main;

        public ClosingReport(MainForm main)
        {
            this.main = main;
            this.MdiParent = main;

            InitializeComponent();
        }

        private DataTable ExecuteQuery(string query)
        {
            return main.ExecuteQuery(query);
        }

        private void ClosingReport_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("", "ID");
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns.Add("", "Time");
            dataGridView1.Columns[1].Width = 200;

            tbAkhir.Text = tbAwal.Text = "";
            idAkhir = idAwal = 0;

            RefreshClosingStamp();
        }

        private void RefreshClosingStamp()
        {
            awal = akhir = DateTime.MinValue;
            DataTable dt = ExecuteQuery("SELECT stampID, DATE_FORMAT(stampTime, '%d/%m/%Y %H:%i:%s') AS stampTime FROM PVCTimeStamp ORDER BY StampID ASC");
            if (dt == null)
            {
                MessageBox.Show("ERROR SHOWING DATA STAMP IN CLOSING FORM PVC");
                this.Dispose();
            }
            else
            {
                if (dt.Rows.Count > 0)
                {
                    dataGridView1.Rows.Clear();
                    for (int i = 0; i < dt.Rows.Count; i++)
                        dataGridView1.Rows.Add(dt.Rows[i]["stampID"].ToString(), dt.Rows[i]["stampTime"].ToString());
                }
                else
                {
                    MessageBox.Show("DATA TIDAK ADA (PVC TIME STAMP - SHOWING DATA STAMP IN CLOSING FORM PVC)");
                }
            }
        }

        private DateTime GetNowTime()
        {
            //AMBIL JAM SEKARANG DARI SERVER
            DataTable dt = ExecuteQuery("SELECT DATE_FORMAT(now(), '%d/%m/%Y %H:%i:%s') AS sekarang");
            if (dt == null)
            {
                main.SetMessage("SELECT NOW() FROM DATABASE ISNOT RETURN ANY VALUE (NULL)");
                return DateTime.MinValue;
            }
            else
            {
                DateTime temp = Other.Parser.TimeFromString(dt.Rows[0]["sekarang"].ToString());
                return temp;
            }
        }

        private void btnHarian_Click(object sender, EventArgs e)
        {
            if (awal != DateTime.MinValue)
            {
                if (akhir == DateTime.MinValue) akhir = GetNowTime();
                DataTable dt = main.ExecuteQuery("SELECT psh.pvcSalesID, psh.salesTime, mc.customerName, mp.pvcName, mp.pvcPerPack, mp.pvcTypeUnit AS paymentMethod, psd.quantity, psd.sellPrice, (psd.quantity * psd.sellPrice) AS subtotal, (SELECT SUM(quantity * sellPrice) FROM PVCSalesDetail WHERE psh.pvcSalesID = pvcSalesID) AS grandtotal, 0 AS grandtotalBayar FROM PVCSalesHeader psh, PVCSalesDetail psd, MsCustomer mc, MsPVC mp WHERE psh.pvcSalesID = psd.pvcSalesID AND psd.pvcID = mp.pvcID AND psh.customerID = mc.customerID AND ((psh.salesTime > '" + awal.ToString("yyyy-MM-dd HH:mm:ss") + "' AND psh.salesTime < '" + akhir.ToString("yyyy-MM-dd HH:mm:ss") + "') OR psh.pvcSalesID IN (SELECT pvcSalesID FROM PVCSalesPayment WHERE paymentTime > '" + awal.ToString("yyyy-MM-dd HH:mm:ss") + "' AND paymentTime < '" + akhir.ToString("yyyy-MM-dd HH:mm:ss") + "')) " +

    "UNION " +

    "SELECT psh.pvcSalesID, psh.salesTime, mc.customerName, psp.paymentTime, -1 as pvcPerPack, psp.paymentMethod, -1, psp.ammount, -(1 * psp.ammount) AS subtotal, (SELECT SUM(quantity * sellPrice) FROM PVCSalesDetail WHERE psh.pvcSalesID = pvcSalesID) AS grandtotal, (SELECT SUM(1 * ammount) FROM PVCSalesPayment WHERE psp.pvcSalesID = pvcSalesID) AS grandtotalBayar FROM PVCSalesHeader psh, PVCSalesDetail psd, PVCSalesPayment psp, MsCustomer mc, MsPVC mp WHERE psh.pvcSalesID = psd.pvcSalesID AND psd.pvcID = mp.pvcID AND psh.customerID = mc.customerID AND psh.pvcSalesID = psp.pvcSalesID AND ((psh.salesTime > '" + awal.ToString("yyyy-MM-dd HH:mm:ss") + "' AND psh.salesTime < '" + akhir.ToString("yyyy-MM-dd HH:mm:ss") + "') OR psh.pvcSalesID IN (SELECT DISTINCT pvcSalesID FROM PVCSalesPayment WHERE paymentTime > '" + awal.ToString("yyyy-MM-dd HH:mm:ss") + "' AND paymentTime < '" + akhir.ToString("yyyy-MM-dd HH:mm:ss") + "'))");

                if (dt == null)
                {
                    MessageBox.Show("ERROR PRINT REPORT (LAPORAN HARIAN DI CLOSING FORM PVC)");
                    this.Dispose();
                }
                else
                {
                    if (dt.Rows.Count > 0)
                    {
                        Rahayu_Program.Report.PVC.LaporanPenjualanHarian laporan = new Rahayu_Program.Report.PVC.LaporanPenjualanHarian();
                        laporan.SetDataSource(dt);
                        laporan.SummaryInfo.ReportTitle = "PVC Laporan Penjualan Harian";

                        buatLaporanByQuery(laporan);
                    }
                    else
                    {
                        MessageBox.Show("DATA TIDAK ADA (LAPORAN HARIAN DI CLOSING FORM PVC)");
                    }
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

        private void button8_Click(object sender, EventArgs e)
        {
            //AWAL
            int indexSelected = dataGridView1.CurrentRow.Index;
            if (indexSelected >= 0 && indexSelected < dataGridView1.Rows.Count)
            {
                tbAwal.Text = dataGridView1.Rows[indexSelected].Cells[1].Value.ToString();
                awal = Other.Parser.TimeFromString(tbAwal.Text);
                idAwal = Int32.Parse(dataGridView1.Rows[indexSelected].Cells[0].Value.ToString());
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //AKHIR
            int indexSelected = dataGridView1.CurrentRow.Index;
            if (indexSelected >= 0 && indexSelected < dataGridView1.Rows.Count)
            {
                tbAkhir.Text = dataGridView1.Rows[indexSelected].Cells[1].Value.ToString();
                akhir = Other.Parser.TimeFromString(tbAkhir.Text);
                idAkhir = Int32.Parse(dataGridView1.Rows[indexSelected].Cells[0].Value.ToString());
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (main.GetLevel() < 4 || main.globalEmployeeID == 4)
            {
                //CUMA BOLEH ADMIN + ADANG
                ExecuteQuery("INSERT INTO PVCTimeStamp (stampTime) VALUES (now())");
                RefreshClosingStamp();
            }
            else
            {
                DialogBox.SupervisorForm superLogin = new DialogBox.SupervisorForm(main);
                superLogin.ShowDialog();
                if (superLogin.DialogResult == System.Windows.Forms.DialogResult.OK)
                {
                    ExecuteQuery("INSERT INTO PVCTimeStamp (stampTime) VALUES (now())");
                    RefreshClosingStamp();
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            RefreshClosingStamp();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (awal != DateTime.MinValue)
            {
                if (akhir == DateTime.MinValue) akhir = GetNowTime();
                DataTable dt = main.ExecuteQuery("SELECT psh.pvcSalesID, salesTime, customerName, (SELECT SUM(sellPrice * quantity) FROM PVCSalesDetail WHERE psh.pvcSalesID = pvcSalesID) as totalPrice, pvcPaymentID as paymentID, paymentTime, paymentMethod as method, ammount FROM PVCSalesPayment psp JOIN PVCSalesHeader psh ON psh.pvcSalesID = psp.pvcSalesID JOIN MsCustomer mc ON mc.customerID = psh.customerID WHERE paymentTime > '" + awal.ToString("yyyy-MM-dd HH:mm:ss") + "' AND paymentTime < '" + akhir.ToString("yyyy-MM-dd HH:mm:ss") + "' ORDER BY paymentTime ASC");

                if (dt == null)
                {
                    MessageBox.Show("ERROR PRINT REPORT (LAPORAN HARIAN GROUPING DI CLOSING FORM PVC)");
                    this.Dispose();
                }
                else
                {
                    if (dt.Rows.Count > 0)
                    {
                        Rahayu_Program.Report.PVC.LaporanPenjualanHarianIncome laporan = new Rahayu_Program.Report.PVC.LaporanPenjualanHarianIncome();
                        laporan.SetDataSource(dt);
                        laporan.SummaryInfo.ReportTitle = "PVC Laporan Penjualan Harian Grouping";

                        buatLaporanByQuery(laporan);
                    }
                    else
                    {
                        MessageBox.Show("DATA TIDAK ADA (LAPORAN HARIAN GROUPING DI CLOSING FORM PVC)");
                    }
                }
            }
        }

        private void btnPrintStock_Click(object sender, EventArgs e)
        {
            DataTable dt = main.ExecuteQuery("SELECT pvcTypeName, mp.pvcID, pvcName, pvcPerPack, pvcTypeUnit, sellPrice, homeStock, rahayuStock FROM MsPVC mp JOIN MsPVCType mpt ON mp.pvcTypeID = mpt.pvcTypeID");

            if (dt == null)
            {
                MessageBox.Show("ERROR PRINT REPORT (LAPORAN HARIAN DI CLOSING FORM PVC)");
                this.Dispose();
            }
            else
            {
                if (dt.Rows.Count > 0)
                {
                    Rahayu_Program.Report.PVC.LaporanStockManual laporan = new Rahayu_Program.Report.PVC.LaporanStockManual();
                    laporan.SetDataSource(dt);
                    laporan.SummaryInfo.ReportTitle = "PVC Laporan Stock Manual";

                    buatLaporanByQuery(laporan);
                }
                else
                {
                    MessageBox.Show("DATA TIDAK ADA (LAPORAN HARIAN DI CLOSING FORM PVC)");
                }
            }
        }

        private void btnHarianGroup_Click(object sender, EventArgs e)
        {
            if (awal != DateTime.MinValue)
            {
                if (akhir == DateTime.MinValue) akhir = GetNowTime();
                DataTable dt = main.ExecuteQuery("SELECT pvcTypeName as pvcType, pvcName, SUM(quantity) as quantity, psd.sellPrice FROM PVCSalesDetail psd JOIN MsPVC mpv ON psd.pvcID = mpv.pvcID JOIN MsPVCType mpt ON mpv.pvcTypeID = mpt.pvcTypeID WHERE pvcSalesID IN (SELECT DISTINCT pvcSalesID FROM PVCSalesHeader WHERE salesTime > '" + awal.ToString("yyyy-MM-dd HH:mm:ss") + "' AND salesTime < '" + akhir.ToString("yyyy-MM-dd HH:mm:ss") + "') GROUP BY pvcTypeName, pvcName, psd.sellPrice ORDER BY pvcName");

                if (dt == null)
                {
                    MessageBox.Show("ERROR PRINT REPORT (LAPORAN HARIAN GROUPING DI CLOSING FORM PVC)");
                    this.Dispose();
                }
                else
                {
                    if (dt.Rows.Count > 0)
                    {
                        Rahayu_Program.Report.PVC.LaporanPenjualanHarianGroup laporan = new Rahayu_Program.Report.PVC.LaporanPenjualanHarianGroup();
                        laporan.SetDataSource(dt);
                        laporan.SummaryInfo.ReportTitle = "PVC Laporan Penjualan Harian Grouping";

                        buatLaporanByQuery(laporan);
                    }
                    else
                    {
                        MessageBox.Show("DATA TIDAK ADA (LAPORAN HARIAN GROUPING DI CLOSING FORM PVC)");
                    }
                }
            }
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            if (awal != DateTime.MinValue)
            {
                if (akhir == DateTime.MinValue) akhir = GetNowTime();
                DataTable dt = main.ExecuteQuery("SELECT pth.pvcTransferID, deliveryOfficer, transferTime, pvcName, pvcPerPack, pvcTypeUnit, quantity FROM PVCTransferHeader pth JOIN PVCTransferDetail ptd ON pth.pvcTransferID = ptd.pvcTransferID JOIN MsPVC mp ON mp.pvcID = ptd.pvcID WHERE transferTime > '" + awal.ToString("yyyy-MM-dd HH:mm:ss") + "' AND transferTime < '" + akhir.ToString("yyyy-MM-dd HH:mm:ss") + "' ORDER BY pvcName");

                if (dt == null)
                {
                    MessageBox.Show("ERROR PRINT REPORT (LAPORAN PINDAH BARANG DI CLOSING FORM PVC)");
                    this.Dispose();
                }
                else
                {
                    if (dt.Rows.Count > 0)
                    {
                        Rahayu_Program.Report.PVC.LaporanTransferStock laporan = new Rahayu_Program.Report.PVC.LaporanTransferStock();
                        laporan.SetDataSource(dt);
                        laporan.SummaryInfo.ReportTitle = "PVC Laporan Pindah Barang";

                        buatLaporanByQuery(laporan);
                    }
                    else
                    {
                        MessageBox.Show("DATA TIDAK ADA (LAPORAN PINDAH BARANG DI CLOSING FORM PVC)");
                    }
                }
            }
        }
    }
}
