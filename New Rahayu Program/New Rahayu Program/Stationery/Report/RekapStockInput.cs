using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Rahayu_Program.Stationery.Report
{
    public partial class RekapStockInput : Form
    {
        private MainForm main;
        private DateTime awal;
        private DateTime akhir;
        private List<RekapInputList> list;
        private int nomorRakAktif;

        public RekapStockInput(MainForm main, DateTime awal, DateTime akhir)
        {
            this.main = main;
            this.MdiParent = main;

            this.awal = awal;
            this.akhir = akhir;

            this.list = new List<RekapInputList>();

            InitializeComponent();
        }

        public DataTable ExecuteQuery(string query)
        {
            return main.ExecuteQuery(query);
        }

        private void RekapStockInput_Load(object sender, EventArgs e)
        {
            
        }

        private void ShowByRak(int rak)
        {
            DataTable dt = ExecuteQuery("SELECT DISTINCT mb.barangID, mb.namaBarang, mb.stock, mb.sellPrice, mb.stock, mb.nomorRak FROM MsBarang mb, StationerySalesHeader ssh, StationerySalesDetail ssd WHERE mb.barangID = ssd.barangID AND ssh.stationerySalesID = ssd.stationerySalesID AND ssh.stationerySalesID = ssd.stationerySalesID AND ssh.salesTime > '" + awal.ToString("yyyy-MM-dd HH:mm:ss") + "' AND ssh.salesTime < '" + akhir.ToString("yyyy-MM-dd HH:mm:ss") + "' AND mb.nomorRak = " + rak + " ORDER BY ssd.barangID");

            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    DataTable dt2 = ExecuteQuery("SELECT srsd.stockHitung FROM StationeryRekapStockHeader srsh, StationeryRekapStockDetail srsd WHERE srsh.rekapStockID = srsd.rekapStockID AND rekapTime > '" + awal.ToString("yyyy-MM-dd HH:mm:ss") + "' AND rekapTime < '" + akhir.ToString("yyyy-MM-dd HH:mm:ss") + "' AND srsh.nomorRak = " + rak + " ORDER BY srsd.barangID");

                    list.Clear();
                    Boolean inputed = true;
                    if (dt2.Rows.Count == 0) inputed = false;

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        RekapInputList temp = new RekapInputList(this, dt.Rows[i]["barangID"].ToString(), dt.Rows[i]["namaBarang"].ToString(), inputed ? Int32.Parse(dt2.Rows[i]["stockHitung"].ToString()) : 0);
                        temp.SetIndex(i);
                        list.Add(temp);
                    }

                    RefreshList();
                    btnOK.Enabled = inputed ? false : true;

                    nomorRakAktif = rak;
                    tbNomorRak.Text = nomorRakAktif + "";
                }
                else
                {
                    if (rak < 22) ShowByRak(rak + 1);
                }
            }

        }

        public void SetNext(int index)
        {
            if (index < list.Count - 1)
            {
                list[index + 1].setFocus();
            }
            else if (index == list.Count - 1)
            {
                btnOK.Focus();
            }
        }

        private void RefreshList()
        {
            panel1.Controls.Clear();
            for (int i = 0; i < list.Count; i++)
            {
                list[i].Location = new Point(1, 1 + ((1 + list[i].Height) * i));
                panel1.Controls.Add(list[i]);
            }
            if (list.Count > 0)
            {
                list[0].setFocus();
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            ShowByRak(1);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            ShowByRak(2);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            ShowByRak(3);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            ShowByRak(4);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            ShowByRak(5);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            ShowByRak(6);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            ShowByRak(7);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            ShowByRak(8);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            ShowByRak(9);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            ShowByRak(10);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            ShowByRak(11);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowByRak(12);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ShowByRak(13);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ShowByRak(14);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ShowByRak(15);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ShowByRak(16);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ShowByRak(17);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ShowByRak(18);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ShowByRak(19);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            ShowByRak(20);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            ShowByRak(21);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            ShowByRak(22);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            //SAVE KE DATABASE
            ExecuteQuery("INSERT INTO StationeryRekapStockHeader (rekapTime, nomorRak) VALUES ('" + akhir.AddMinutes(-1).ToString("yyyy-MM-dd HH:mm:ss") + "', " + nomorRakAktif + ")");
            DataTable dt = ExecuteQuery("SELECT rekapStockID FROM StationeryRekapStockHeader ORDER BY rekapStockID DESC LIMIT 0, 1");
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    int rekapStockID = Int32.Parse(dt.Rows[0]["rekapStockID"].ToString());
                    for (int i = 0; i < list.Count; i++)
                    {
                        DataTable dt2 = ExecuteQuery("SELECT stock FROM MsBarang WHERE barangID = '" + list[i].GetNomorBarang() + "'");
                        if (dt2.Rows.Count > 0)
                            ExecuteQuery("INSERT INTO StationeryRekapStockDetail VALUES (" + rekapStockID + ", '" + list[i].GetNomorBarang() + "', " + list[i].getQty() + ", " + (list[i].getQty() - Int32.Parse(dt2.Rows[0]["stock"].ToString())) + ", " + Int32.Parse(dt2.Rows[0]["stock"].ToString()) + ")");
                    }
                    list.Clear();
                    RefreshList();
                }
            }
            if (nomorRakAktif < 22)
            {
                ShowByRak(nomorRakAktif + 1);
            }
            else
            {
                button2_Click(sender, e);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Rahayu_Program.Report.ReportForm reportForm = new Rahayu_Program.Report.ReportForm(main);
            reportForm.MdiParent = main;
            reportForm.WindowState = FormWindowState.Maximized;

            DataTable dt = main.ExecuteQuery("SELECT DISTINCT srsh.nomorRak, srsd.barangID, mb.namaBarang, srsd.stockAsli AS stockKomputer, srsd.selisih, srsd.stockHitung FROM MsBarang mb, StationeryRekapStockHeader srsh, StationeryRekapStockDetail srsd WHERE mb.barangID = srsd.barangID AND srsh.rekapStockID = srsd.rekapStockID AND NOT srsd.selisih = 0 AND srsh.rekapTime > '" + awal.ToString("yyyy-MM-dd HH:mm:ss") + "' AND srsh.rekapTime < '" + akhir.ToString("yyyy-MM-dd HH:mm:ss") + "' ORDER BY srsh.nomorRak, srsd.barangID");

            if (dt == null)
            {
                MessageBox.Show("OPEN REPORT ERROR (PRINT REKAP STOCK INPUT STATIONERY)");
                this.Dispose();
            }
            else
            {
                if (dt.Rows.Count > 0)
                {
                    Rahayu_Program.Report.Stationery.LaporanBedaStock laporan = new Rahayu_Program.Report.Stationery.LaporanBedaStock();
                    laporan.SetDataSource(dt);

                    reportForm.GetCrystalReportViewer().ReportSource = laporan;
                    reportForm.GetCrystalReportViewer().Refresh();

                    reportForm.Show();
                }
                else
                {
                    MessageBox.Show("DATA TIDAK ADA");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Rahayu_Program.Report.ReportForm reportForm = new Rahayu_Program.Report.ReportForm(main);
            reportForm.MdiParent = main;
            reportForm.WindowState = FormWindowState.Maximized;

            DataTable dt = main.ExecuteQuery("SELECT DISTINCT mb.barangID, mb.namaBarang, mb.stock, mb.sellPrice, mb.nomorRak FROM MsBarang mb, StationerySalesHeader ssh, StationerySalesDetail ssd WHERE mb.barangID = ssd.barangID AND ssh.stationerySalesID = ssd.stationerySalesID AND ssh.salesTime > '" + awal.ToString("yyyy-MM-dd HH:mm:ss") + "' AND ssh.salesTime < '" + akhir.ToString("yyyy-MM-dd HH:mm:ss") + "' ORDER BY ssd.barangID");

            if (dt == null)
            {
                MessageBox.Show("ERROR PRINT REPORT (LAPORAN GROUP DI CLOSING FORM STATIONERY)");
                this.Dispose();
            }
            else
            {
                if (dt.Rows.Count > 0)
                {
                    Rahayu_Program.Report.Stationery.LaporanRekapAkhir laporan = new Rahayu_Program.Report.Stationery.LaporanRekapAkhir();
                    laporan.SetDataSource(dt);

                    reportForm.GetCrystalReportViewer().ReportSource = laporan;
                    reportForm.GetCrystalReportViewer().Refresh();

                    reportForm.Show();
                }
                else
                {
                    MessageBox.Show("DATA TIDAK ADA (LAPORAN MsBARANG DI CLOSING FORM STATIONERY)");
                }
            }
        }
    }
}
