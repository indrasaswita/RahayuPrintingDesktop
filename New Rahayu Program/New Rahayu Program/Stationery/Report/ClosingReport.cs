using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Rahayu_Program.Report;
using OnBarcode.Barcode;
using System.Drawing.Printing;

namespace Rahayu_Program.Stationery.Report
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
            dataGridView1.Columns.Add("", "Emp");
            dataGridView1.Columns[2].Width = 150;
            dataGridView1.Columns.Add("", "Desc");
            dataGridView1.Columns[3].Width = 150;

            tbAkhir.Text = tbAwal.Text = "";
            idAkhir = idAwal = 0;

            RefreshClosingStamp();
        }

        private void RefreshClosingStamp()
        {
            DataTable dt = ExecuteQuery("SELECT stampID, DATE_FORMAT(stampTime, '%d/%m/%Y %H:%i:%s') AS stampTime, employeeName, description FROM StationeryTimeStamp sts, MsEmployee me WHERE sts.employeeID = me.employeeID ORDER BY StampID ASC");
            if (dt == null)
            {
                MessageBox.Show("ERROR SHOWING DATA STAMP IN CLOSING FORM STATIONERY");
                this.Dispose();
            }
            else
            {
                if (dt.Rows.Count > 0)
                {
                    dataGridView1.Rows.Clear();
                    for (int i = 0; i < dt.Rows.Count; i++)
                        dataGridView1.Rows.Add(dt.Rows[i]["stampID"].ToString(), dt.Rows[i]["stampTime"].ToString(), dt.Rows[i]["employeeName"].ToString(), dt.Rows[i]["description"].ToString());
                }
                else
                {
                    MessageBox.Show("DATA TIDAK ADA (STATIONERY TIME STAMP - SHOWING DATA STAMP IN CLOSING FORM STATIONERY)");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = main.ExecuteQuery("SELECT ssh.stationerySalesID, ssh.salesTime, ssd.barangID, mb.namaBarang, ssd.quantity, ssd.sellPrice FROM StationerySalesHeader ssh, StationerySalesDetail ssd, MsBarang mb WHERE ssh.stationerySalesID = ssd.stationerySalesID AND ssd.barangID = mb.barangID AND ssh.salesTime > '" + awal.ToString("yyyy-MM-dd HH:mm:ss") + "' AND ssh.salesTime < '" + akhir.ToString("yyyy-MM-dd HH:mm:ss") + "'");

            if (dt == null)
            {
                MessageBox.Show("ERROR PRINT REPORT (LAPORAN HARIAN DI CLOSING FORM STATIONERY)");
                this.Dispose();
            }
            else
            {
                if (dt.Rows.Count > 0)
                {
                    Rahayu_Program.Report.Stationery.LaporanHarian laporan = new Rahayu_Program.Report.Stationery.LaporanHarian();
                    laporan.SetDataSource(dt);

                    buatLaporanByQuery(laporan);
                }
                else
                {
                    MessageBox.Show("DATA TIDAK ADA (LAPORAN HARIAN DI CLOSING FORM STATIONERY)");
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

        private void button4_Click(object sender, EventArgs e)
        {
            if (main.GetLevel() < 4)
            {
                //CUMA BOLEH ADMIN + ADANG
                setStamp();
                RefreshClosingStamp();
            }
            else
            {
                DialogBox.SupervisorForm superLogin = new DialogBox.SupervisorForm(main);
                superLogin.ShowDialog();
                if (superLogin.DialogResult == System.Windows.Forms.DialogResult.OK)
                {
                    setStamp();
                    RefreshClosingStamp();
                }
            }
        }

        private void setStamp()
        {
            DataTable dt = main.ExecuteQuery("SELECT ssd.barangID AS barangID, mb.namaBarang AS namaBarang, mb.stock as stock, SUM(ssd.quantity) AS quantity, ssd.sellPrice AS sellPrice FROM StationerySalesHeader ssh, StationerySalesDetail ssd, MsBarang mb WHERE ssh.stationerySalesID = ssd.stationerySalesID AND ssd.barangID = mb.barangID AND ssh.stationerySalesID = ssd.stationerySalesID AND ssh.salesTime > (SELECT stampTime FROM StationeryTimeStamp WHERE description = 'CLOSING HARIAN' ORDER BY stampID DESC LIMIT 0, 1) GROUP BY ssd.barangID, mb.namaBarang, mb.stock, ssd.sellPrice");

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string barangID = dt.Rows[i]["barangID"].ToString();
                int stockAkhir = Int32.Parse(dt.Rows[i]["stock"].ToString());
                int jual = Int32.Parse(dt.Rows[i]["quantity"].ToString());
                int stockAwal = stockAkhir + jual;
                string info = "dijual " + jual + ", dari " + stockAwal + " jadi " + stockAkhir;
                ExecuteQuery("INSERT INTO StationeryChangeValue (changeValueTime, employeeID, changeValueType, barangID, information, description) VALUES (now(), 9, 'DAILY SELL', '" + barangID + "', '" + info + "', 'normal')");
            }
            ExecuteQuery("INSERT INTO StationeryTimeStamp (stampTime, employeeID, description) VALUES (now(), " + main.globalEmployeeID + ", 'CLOSING HARIAN')");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            RefreshClosingStamp();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DataTable dt = main.ExecuteQuery("SELECT ssd.barangID AS barangID, mb.namaBarang AS namaBarang, SUM(ssd.quantity) AS quantity, ssd.sellPrice AS sellPrice FROM StationerySalesHeader ssh, StationerySalesDetail ssd, MsBarang mb WHERE ssh.stationerySalesID = ssd.stationerySalesID AND ssd.barangID = mb.barangID AND ssh.stationerySalesID = ssd.stationerySalesID AND ssh.salesTime > '" + awal.ToString("yyyy-MM-dd HH:mm:ss") + "' AND ssh.salesTime < '" + akhir.ToString("yyyy-MM-dd HH:mm:ss") + "' GROUP BY ssd.barangID, mb.namaBarang, ssd.sellPrice");

            //DataTable dt = main.ExecuteQuery("SELECT mb.barangID, mb.namaBarang, mb.stock, mb.sellPrice FROM StationerySalesHeader ssh, StationerySalesDetail ssd, MsBarang mb WHERE ssh.stationerySalesID = ssd.stationerySalesID AND ssd.barangID = mb.barangID");

            if (dt == null)
            {
                MessageBox.Show("ERROR PRINT REPORT (LAPORAN GROUP DI CLOSING FORM STATIONERY)");
                this.Dispose();
            }
            else
            {
                if (dt.Rows.Count > 0)
                {
                    Rahayu_Program.Report.Stationery.LaporanHarianGroup laporan = new Rahayu_Program.Report.Stationery.LaporanHarianGroup();
                    laporan.SetDataSource(dt);

                    buatLaporanByQuery(laporan);
                }
                else
                {
                    MessageBox.Show("DATA TIDAK ADA (LAPORAN GROUP DI CLOSING FORM STATIONERY)");
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DataTable dt = main.ExecuteQuery("SELECT spd.barangID, mb.namaBarang, spd.qty AS qtyPembelian, ms.supplierName, mb.sellPrice, spd.buyPrice, spd.buyPriceHistory FROM MsSupplier ms, MsBarang mb, StationeryPurchaseHeader sph, StationeryPurchaseDetail spd WHERE mb.supplierID = ms.supplierID AND mb.barangID = spd.barangID AND sph.stationeryPurchaseID = spd.stationeryPurchaseID AND NOT spd.buyPrice = spd.buyPriceHistory AND NOT spd.buyPriceHistory = 0 AND sph.purchaseTime > '" + awal.ToString("yyyy-MM-dd HH:mm:ss") + "' AND sph.purchaseTime < '" + akhir.ToString("yyyy-MM-dd HH:mm:ss") + "' ORDER BY mb.barangID");

            if (dt == null)
            {
                MessageBox.Show("ERROR PRINT REPORT (LAPORAN GROUP DI CLOSING FORM STATIONERY)");
                this.Dispose();
            }
            else
            {
                if (dt.Rows.Count > 0)
                {
                    Rahayu_Program.Report.Stationery.LaporanPermintaanPerubahanHarga laporan = new Rahayu_Program.Report.Stationery.LaporanPermintaanPerubahanHarga();
                    laporan.SetDataSource(dt);

                    buatLaporanByQuery(laporan);
                }
                else
                {
                    MessageBox.Show("DATA TIDAK ADA (LAPORAN MsBARANG DI CLOSING FORM STATIONERY)");
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
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

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dt = main.ExecuteQuery("SELECT DISTINCT mb.barangID, mb.namaBarang, mb.stock, mb.sellPrice, mb.nomorRak FROM MsBarang mb, StationerySalesHeader ssh, StationerySalesDetail ssd WHERE mb.barangID = ssd.barangID AND ssh.stationerySalesID = ssd.stationerySalesID AND ssh.salesTime > '" + awal.ToString("yyyy-MM-dd HH:mm:ss") + "' AND ssh.salesTime < '" + akhir.ToString("yyyy-MM-dd HH:mm:ss") + "' ORDER BY mb.barangID");

            if (dt == null)
            {
                MessageBox.Show("ERROR PRINT REPORT (LAPORAN GROUP DI CLOSING FORM STATIONERY)");
                this.Dispose();
            }
            else
            {
                if (dt.Rows.Count > 0)
                {
                    Rahayu_Program.Report.Stationery.LaporanRekapAwal laporan = new Rahayu_Program.Report.Stationery.LaporanRekapAwal();
                    laporan.SetDataSource(dt);

                    buatLaporanByQuery(laporan);
                }
                else
                {
                    MessageBox.Show("DATA TIDAK ADA (LAPORAN MsBARANG DI CLOSING FORM STATIONERY)");
                }
            }
        }

        RekapStockInput rekapStock;

        private void button10_Click(object sender, EventArgs e)
        {
            rekapStock = new RekapStockInput(main, awal, akhir);
            rekapStock.Show();
        }

        string[] nomorBarang = new string[3];
        string[] namaBarang = new string[3];
        int[] sellPrice = new int[3];
        int[] buyPrice = new int[3];

        private void button11_Click(object sender, EventArgs e)
        {
            //PRINT BARCODENYA

            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(printPage);
            pd.PrinterSettings.PrinterName = "ZDesigner GK420t";
            pd.PrintController = new StandardPrintController();

            DataTable dt = ExecuteQuery("SELECT spd.barangID, mb.namaBarang, mb.sellPrice, spd.qty, mb.buyPrice FROM StationeryPurchaseHeader sph, StationeryPurchaseDetail spd, MsBarang mb WHERE mb.barangID = spd.barangID AND sph.stationeryPurchaseID = spd.stationeryPurchaseID AND sph.purchaseTime > '" + awal.ToString("yyyy-MM-dd HH:mm:ss") + "' AND sph.purchaseTime < '" + akhir.ToString("yyyy-MM-dd HH:mm:ss") + "'");

            int count = 0;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                int jj = Int32.Parse(dt.Rows[i]["qty"].ToString());

                for (int j = 0; j < jj; j++)
                {
                    nomorBarang[count % 3] = dt.Rows[i]["barangID"].ToString();
                    namaBarang[count % 3] = dt.Rows[i]["namaBarang"].ToString();
                    sellPrice[count % 3] = Int32.Parse(dt.Rows[i]["sellPrice"].ToString());
                    buyPrice[count % 3] = Int32.Parse(dt.Rows[i]["buyPrice"].ToString());

                    if (count % 3 == 2)
                    {
                        //YANG TERAKHIR
                        pd.Print();
                        //MessageBox.Show("baris ke : " + (count / 3) + " --> " + nomorBarang[0] + ", " + nomorBarang[1] + ", " + nomorBarang[2]);
                    }
                    count++;
                }
            }
        }

        Font courierFont = new Font("Courier New", 6, FontStyle.Bold);
        Font kodeFont = new Font("Courier New", 12, FontStyle.Bold);

        private void printPage(object o, PrintPageEventArgs e)
        {
            Util.Barcode.Barcode.printBarcodeFromArray(e.Graphics, courierFont, kodeFont, nomorBarang, namaBarang, sellPrice, buyPrice);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataTable dt = main.ExecuteQuery("SELECT sph.stationeryPurchaseID, sph.purchaseTime, spd.barangID, mb.namaBarang, ms.supplierName, spd.qty AS qtyPembelian, mb.sellPrice, spd.buyPrice, spd.buyPriceHistory FROM StationeryPurchaseHeader sph, StationeryPurchaseDetail spd, MsBarang mb, MsSupplier ms WHERE sph.stationeryPurchaseID = spd.stationeryPurchaseID AND spd.barangID = mb.barangID AND ms.supplierID = mb.supplierID AND sph.purchaseTime > '" + awal.ToString("yyyy-MM-dd HH:mm:ss") + "' AND sph.purchaseTime < '" + akhir.ToString("yyyy-MM-dd HH:mm:ss") + "'");

            if (dt == null)
            {
                MessageBox.Show("ERROR PRINT REPORT (LAPORAN HARIAN DI CLOSING FORM STATIONERY)");
                this.Dispose();
            }
            else
            {
                if (dt.Rows.Count > 0)
                {
                    Rahayu_Program.Report.Stationery.LaporanPembelianHarian laporan = new Rahayu_Program.Report.Stationery.LaporanPembelianHarian();
                    laporan.SetDataSource(dt);

                    buatLaporanByQuery(laporan);
                }
                else
                {
                    MessageBox.Show("DATA TIDAK ADA (LAPORAN HARIAN DI CLOSING FORM STATIONERY)");
                }
            }
        }
    }
}

