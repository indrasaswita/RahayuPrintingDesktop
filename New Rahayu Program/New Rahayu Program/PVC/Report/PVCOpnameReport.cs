using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.Shared;
using Rahayu_Program.Report;

namespace Rahayu_Program.PVC.Report
{
    public partial class PVCOpnameReport : Form
    {
        private MainForm main;
        private DateTime awal;
        private DateTime akhir;
        private List<OpnameList> list;
        private ClosingReport parent;

        public PVCOpnameReport(MainForm main, ClosingReport parent, DateTime awal, DateTime akhir)
        {
            this.main = main;
            this.parent = parent;
            this.MdiParent = main;

            this.awal = awal;
            this.akhir = akhir;

            this.list = new List<OpnameList>();

            InitializeComponent();
        }

        public DataTable ExecuteQuery(string query)
        {
            return main.ExecuteQuery(query);
        }

        private void PVCOpnameReport_Load(object sender, EventArgs e)
        {
            ShowAll();
        }

        private void ShowAll()
        {
            DataTable dt = ExecuteQuery("SELECT pvcID, pvcName, pvcPerPack, pvcTypeUnit, sellPrice FROM MsPVC mp JOIN MsPVCType mpt ON mp.pvcTypeID = mpt.pvcTypeID WHERE NOT mp.pvcTypeID = 8 AND NOT mp.pvcTypeID = 9 ORDER BY mpt.pvcTypeName");

            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    DataTable dt2 = ExecuteQuery("SELECT prsd.stockHitung FROM PVCRekapStockHeader prsh JOIN PVCRekapStockDetail prsd ON prsh.rekapStockID = prsd.rekapStockID JOIN MsPVC mp ON prsd.pvcID = mp.pvcID JOIN MsPVCType mpt ON mp.pvcTypeID = mpt.pvcTypeID AND rekapTime > '" + awal.ToString("yyyy-MM-dd HH:mm:ss") + "' AND rekapTime < '" + akhir.ToString("yyyy-MM-dd HH:mm:ss") + "' AND NOT mp.pvcTypeID = 8 AND NOT mp.pvcTypeID = 9  ORDER BY mpt.pvcTypeName");

                    list.Clear();
                    Boolean inputed = true;
                    if (dt2.Rows.Count == 0) inputed = false;

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        int pvcID = Int32.Parse(dt.Rows[i]["pvcID"].ToString());
                        string pvcName = dt.Rows[i]["pvcName"].ToString();
                        int stockHitung = inputed ? Int32.Parse(dt2.Rows[i]["stockHitung"].ToString()) : 0;
                        decimal pvcPerPack = Decimal.Parse(dt.Rows[i]["pvcPerPack"].ToString());
                        string pvcTypeUnit = dt.Rows[i]["pvcTypeUnit"].ToString();

                        OpnameList temp = new OpnameList(this, pvcID, pvcName, stockHitung, pvcPerPack, pvcTypeUnit);
                        temp.SetIndex(i);
                        list.Add(temp);
                    }

                    RefreshList();
                    btnOK.Enabled = inputed ? false : true;
                }
                else
                {
                    //if (rak < 22) ShowByRak(rak + 1);
                    main.SetMessage("NO PVC DATA, ERROR ON PVC OPNAME REPORT");
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            //SAVE KE DATABASE
            ExecuteQuery("INSERT INTO PVCRekapStockHeader (rekapTime) VALUES ('" + akhir.AddMinutes(-1).ToString("yyyy-MM-dd HH:mm:ss") + "')");
            DataTable dt = ExecuteQuery("SELECT rekapStockID FROM PVCRekapStockHeader ORDER BY rekapStockID DESC LIMIT 0, 1");
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    int rekapStockID = Int32.Parse(dt.Rows[0]["rekapStockID"].ToString());
                    for (int i = 0; i < list.Count; i++)
                    {
                        DataTable dt2 = ExecuteQuery("SELECT rahayuStock AS stock FROM MsBarang WHERE barangID = '" + list[i].GetPVCID() + "'");
                        if (dt2.Rows.Count > 0)
                            ExecuteQuery("INSERT INTO PVCRekapStockDetail VALUES (" + rekapStockID + ", '" + list[i].GetPVCID() + "', " + list[i].getQty() + ", " + (list[i].getQty() - Int32.Parse(dt2.Rows[0]["stock"].ToString())) + ", " + Int32.Parse(dt2.Rows[0]["stock"].ToString()) + ")");
                    }
                    list.Clear();
                    RefreshList();
                }
            }
            btnBedaRekap_Click(sender, e);
        }

        private void btnBedaRekap_Click(object sender, EventArgs e)
        {
            Rahayu_Program.Report.ReportForm reportForm = new Rahayu_Program.Report.ReportForm(main);
            reportForm.MdiParent = main;
            reportForm.WindowState = FormWindowState.Maximized;

            DataTable dt = main.ExecuteQuery("SELECT DISTINCT srsh.nomorRak, srsd.barangID, mb.namaBarang, srsd.stockAsli AS stockKomputer, srsd.selisih, srsd.stockHitung FROM MsBarang mb JOIN StationeryRekapStockHeader srsh ON mb.barangID = srsd.barangID JOIN StationeryRekapStockDetail srsd ON srsh.rekapStockID = srsd.rekapStockID JOIN MsPVCType mpt WHERE NOT srsd.selisih = 0 AND srsh.rekapTime > '" + awal.ToString("yyyy-MM-dd HH:mm:ss") + "' AND srsh.rekapTime < '" + akhir.ToString("yyyy-MM-dd HH:mm:ss") + "' AND NOT mp.pvcTypeID = 8 AND NOT mp.pvcTypeID = 9 ORDER BY mpt.pvcTypeID");

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

        private void buatLaporanByQueryStock(object laporan, Boolean blank)
        {
            ReportForm reportForm = new ReportForm(main);
            reportForm.MdiParent = main;
            reportForm.WindowState = FormWindowState.Maximized;

            reportForm.GetCrystalReportViewer().ReportSource = laporan;

            ParameterField field1 = new ParameterField();
            ParameterDiscreteValue value1 = new ParameterDiscreteValue();
            field1.Name = "blank";
            value1.Value = blank;
            field1.CurrentValues.Add(value1);

            ParameterFields fields = new ParameterFields();
            fields.Add(field1);

            reportForm.GetCrystalReportViewer().ReportSource = laporan;
            reportForm.GetCrystalReportViewer().ParameterFieldInfo = fields;
            reportForm.GetCrystalReportViewer().Refresh();
            reportForm.Show();
        }

        private void btnRekapAkhir_Click(object sender, EventArgs e)
        {
            Rahayu_Program.Report.ReportForm reportForm = new Rahayu_Program.Report.ReportForm(main);
            reportForm.MdiParent = main;
            reportForm.WindowState = FormWindowState.Maximized;

            DataTable dt = main.ExecuteQuery("SELECT pvcTypeName, mp.pvcID, pvcName, pvcPerPack, pvcTypeUnit, sellPrice, homeStock, rahayuStock FROM MsPVC mp JOIN MsPVCType mpt ON mp.pvcTypeID = mpt.pvcTypeID WHERE NOT mp.pvcTypeID = 8 AND NOT mp.pvcTypeID = 9 ORDER BY mpt.pvcTypeID");

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

                    buatLaporanByQueryStock(laporan, false); //false soalnya ga mau di tutupin
                }
                else
                {
                    MessageBox.Show("DATA TIDAK ADA (LAPORAN HARIAN DI CLOSING FORM PVC)");
                }
            }
        }

        private void PVCOpnameReport_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.opnameSetNull();
        }
    }
}
