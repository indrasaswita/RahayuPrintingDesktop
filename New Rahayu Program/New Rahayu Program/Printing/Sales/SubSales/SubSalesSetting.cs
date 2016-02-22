using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Rahayu_Program.Printing.Sales.SubSales
{
    public partial class SubSalesSetting : Form
    {
        MainForm main;
        CreateSalesPrinting parent;
        string status;

        public SubSalesSetting(MainForm main, CreateSalesPrinting parent, string status)
        {
            this.main = main;
            this.parent = parent;
            this.status = status;
            this.MdiParent = main;
            InitializeComponent();
        }

        public DataTable ExecuteQuery(string query)
        {
            return main.ExecuteQuery(query);
        }

        private void SubSalesSetting_Load(object sender, EventArgs e)
        {
            gridTimerList.Columns.Add("TimerID", "No.");
            gridTimerList.Columns["TimerID"].Width = 70;
            gridTimerList.Columns.Add("Keterangan", "Keterangan");
            gridTimerList.Columns["Keterangan"].Width = 200;

            gridTimerDetail.Columns.Add("Awal", "Awal");
            gridTimerDetail.Columns["Awal"].Width = 165;
            gridTimerDetail.Columns.Add("Akhir", "Akhir");
            gridTimerDetail.Columns["Akhir"].Width = 165;
            gridTimerDetail.Columns.Add("Harga", "Harga");
            gridTimerDetail.Columns["Harga"].Width = 100;
            gridTimerDetail.Columns["Harga"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight;
            gridTimerDetail.Columns.Add("Waktu", "Waktu");
            gridTimerDetail.Columns["Waktu"].Visible = false;
        }

        private void blankEmployee()
        {
            btnRudi.BackColor = Color.FromArgb(0, 192, 255, 192);
            btnToing.BackColor = Color.FromArgb(0, 192, 255, 192);
            btnWawan.BackColor = Color.FromArgb(0, 192, 255, 192);
        }

        private void refreshListTimer(int employeeID)
        {
            DataTable dt = ExecuteQuery("SELECT * FROM PrintingTimerHeader WHERE employeeID = '" + employeeID + "' AND status = '0' ORDER BY printingTimerID DESC");
            gridTimerList.Rows.Clear();
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        int timerID = Int32.Parse(dt.Rows[i]["printingTimerID"].ToString());
                        string keterangan = dt.Rows[i]["keterangan"].ToString();

                        gridTimerList.Rows.Add(String.Format("{0:D4}", timerID), keterangan);
                    }
                }
            }

            dt = ExecuteQuery("SELECT employeeName FROM MsEmployee WHERE employeeID = '" + employeeID + "'");
            if (dt != null)
            {
                if (dt.Rows.Count == 1)
                {
                    employeeName = dt.Rows[0]["employeeName"].ToString();
                }
            }
        }

        string employeeName = "";
        int employeeID = 0;

        private void btnToing_Click(object sender, EventArgs e)
        {
            refreshListTimer(5);
            employeeID = 5;
            blankEmployee();
            btnToing.BackColor = Color.GreenYellow;
        }

        private void btnRudi_Click(object sender, EventArgs e)
        {
            refreshListTimer(7);
            employeeID = 7;
            blankEmployee();
            btnRudi.BackColor = Color.GreenYellow;
        }

        private void btnWawan_Click(object sender, EventArgs e)
        {
            refreshListTimer(8);
            employeeID = 8;
            blankEmployee();
            btnWawan.BackColor = Color.GreenYellow;
        }

        int timerID = 0;

        private void gridTimerList_SelectionChanged(object sender, EventArgs e)
        {
            int index = gridTimerList.CurrentRow.Index;
            if (index >= 0 && index < gridTimerList.Rows.Count)
            {
                timerID = Int32.Parse(gridTimerList.Rows[index].Cells["TimerID"].Value.ToString());
                DataTable dt = ExecuteQuery("SELECT DATE_FORMAT(awal, '%d/%m/%Y %H:%i:%s') AS awal, DATE_FORMAT(akhir, '%d/%m/%Y %H:%i:%s') AS akhir, TIMESTAMPDIFF(SECOND, awal, akhir) as waktu FROM PrintingTimerDetail WHERE printingTimerID = '" + timerID + "' ORDER BY awal ASC");
                gridTimerDetail.Rows.Clear();
                int totalHarga = 0, totalWaktu = 0;
                if (dt != null)
                {
                    if (dt.Rows.Count > 0)
                    {
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            int waktu = Int32.Parse(dt.Rows[i]["waktu"].ToString());
                            DateTime awal = Other.Parser.TimeFromString(dt.Rows[i]["awal"].ToString());
                            DateTime akhir = Other.Parser.TimeFromString(dt.Rows[i]["akhir"].ToString());
                            int harga = waktu * (40000 / 30 / 60);

                            gridTimerDetail.Rows.Add(awal.ToString("ddd, dd MMM, HH:mm"), akhir.ToString("ddd, dd MMM, HH:mm"), harga.ToString("#,##0"), waktu);

                            totalHarga += harga;
                            totalWaktu += waktu;
                        }
                    }
                }
                tbHargaMaterial.Text = totalHarga.ToString("#,##0");
                tbTotalJam.Text = totalWaktu.ToString("#,##0") + " detik";
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (tbJudulCetakan.Text.Trim() == "")
            {
                main.SetMessage("Judul Cetakan harus diisi..!");
                tbJudulCetakan.Focus();
            }
            else if (timerID == 0)
            {
                main.SetMessage("Select \"Timer ID\" dulu bos..");
            }
            else
            {
                if (status == "update")
                {
                    if (selected != null)
                        parent.deleteList(selected);
                }

                parent.addNewCart("ST", tbJenisCetakan.Text, tbJudulCetakan.Text, "", gridTimerDetail.Rows.Count, " times", 0, employeeID, employeeName, employeeName, "No. Timer : " + timerID, "", "", 0, "", "", Int32.Parse(tbHargaMaterial.Text.Replace(",", "").Replace(".", "").Trim()), Int32.Parse(tbHargaMaterial.Text.Replace(",", "").Replace(".", "").Trim()), 0, new DateTime(1900, 01, 01, 0, 0, 0), null);
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        PrintingCreateSalesList selected;

        internal void setData(PrintingCreateSalesList selected)
        {
            this.selected = selected;
            tbJudulCetakan.Text = selected.printingTitle;
            employeeName = selected.inschietType;
            employeeID = selected.inschiet;
            refreshListTimer(employeeID);
            timerID = Int32.Parse(selected.paperSize.Substring(selected.paperSize.LastIndexOf(" ")));
            foreach (DataGridViewRow i in gridTimerList.Rows)
            {
                if (Int32.Parse(i.Cells[0].Value.ToString()) == timerID)
                {
                    gridTimerList.CurrentCell = i.Cells[0];
                    break;
                }
            }

            blankEmployee();
            if (employeeID == 5)
                btnToing.BackColor = Color.GreenYellow;
            else if (employeeID == 7)
                btnRudi.BackColor = Color.GreenYellow;
            else if (employeeID == 8)
                btnWawan.BackColor = Color.GreenYellow;
        }
    }
}
