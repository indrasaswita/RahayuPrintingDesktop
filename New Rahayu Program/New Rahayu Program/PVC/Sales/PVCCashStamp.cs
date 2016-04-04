using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Rahayu_Program.Util;

namespace Rahayu_Program.PVC.Sales
{
    public partial class PVCCashStamp : Form
    {
        MainForm main;

        public PVCCashStamp(MainForm main)
        {
            this.main = main;
            InitializeComponent();
        }

        public DataTable ExecuteQuery(string query)
        {
            return main.ExecuteQuery(query);
        }

        private void nudCepeCeng_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                nudGoban.Focus();
                nudGoban.Select(0, 9);
            }
        }

        private void nudGoban_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                nudNoban.Focus();
                nudNoban.Select(0, 9);
            }
        }

        private void nudNoban_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                nudCeban.Focus();
                nudCeban.Select(0, 9);
            }
        }

        private void nudCeban_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                nudGoceng.Focus();
                nudGoceng.Select(0, 9);
            }
        }

        private void nudGoceng_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                nudNoceng.Focus();
                nudNoceng.Select(0, 9);
            }
        }

        private void nudNoceng_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                nudCeceng.Focus();
                nudCeceng.Select(0, 9);
            }
        }

        private void nudCeceng_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                nudGope.Focus();
                nudGope.Select(0, 9);
            }
        }

        private void nudGope_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                nudNope.Focus();
                nudNope.Select(0, 9);
            }
        }

        private void nudNope_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                nudCepe.Focus();
                nudCepe.Select(0, 9);
            }
        }

        private void nudCepe_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                nudPengeluaran.Focus();
                nudPengeluaran.Select(0, 9);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (stampEmployee != 0)
            {
                decimal total = 0;
                total += nudCepeCeng.Value * 100000;
                total += nudGoban.Value * 50000;
                total += nudNoban.Value * 20000;
                total += nudCeban.Value * 10000;
                total += nudGoceng.Value * 5000;
                total += nudNoceng.Value * 2000;
                total += nudCeceng.Value * 1000;
                total += nudGope.Value * 500;
                total += nudNope.Value * 200;
                total += nudCepe.Value * 100;

                total -= 800000; // kurang modal

                DataTable dt = ExecuteQuery("SELECT SUM(sellPrice * quantity) AS totalBelanja FROM PVCSalesDetail psd WHERE psd.pvcSalesID IN (SELECT pvcSalesID FROM PVCSalesHeader ssh WHERE salesTime > (SELECT stampTime FROM PVCTimeStamp WHERE description = 'CLOSING HARIAN' ORDER BY stampTime DESC LIMIT 0, 1))");
                int totalBelanja = 0;
                string totalBelanjaStr = "";
                try
                {
                    if (dt != null)
                        if (dt.Rows.Count == 1)
                        {
                            totalBelanjaStr = dt.Rows[0]["totalBelanja"].ToString();
                            totalBelanja = Int32.Parse(dt.Rows[0]["totalBelanja"].ToString());
                        }
                }
                catch
                {
                    MessageBox.Show("tolong dicatet : \"" + totalBelanjaStr + "\"");
                    totalBelanja = 0;
                }

                totalBelanja -= Convert.ToInt32(nudPengeluaran.Value); // kurang pengeluaran

                ExecuteQuery("INSERT INTO PVCTimeStamp (stampTime, employeeID, description, cashDrawer, totalPenjualan) VALUES (now(), " + stampEmployee + ", 'PVC CASH STAMP', '" + total + "', '" + totalBelanja + "')");
                main.SetMessage("INSERTING DONE! (" + (total - totalBelanja) + ")");
            }
            else
            {
                main.SetMessage("GAGAL!");
            }
            this.Close();
        }

        int stampEmployee = 0;

        private void StampCashier_Load(object sender, EventArgs e)
        {
            DialogBox.LoginBox login = new DialogBox.LoginBox(main);
            login.ShowDialog();
            btnOK.Enabled = false;
            if (login.DialogResult != DialogResult.OK)
            {
                this.Close();
            }
            else
            {
                stampEmployee = login.Value;

                DataTable getPositionID = ExecuteQuery("SELECT role FROM MsEmployee WHERE employeeID = " + stampEmployee + "");
                if (getPositionID.Rows.Count == 1)
                {
                    int role = Int32.Parse(getPositionID.Rows[0]["role"].ToString());
                    if (role <= 7)
                    {
                        btnOK.Enabled = true;
                        string printerName = System.IO.File.ReadAllText(Application.StartupPath + @"\config\printer\stationery-sales-nota.is");
                        RawPrinterHelper.SendStringToPrinter(printerName, System.Text.ASCIIEncoding.ASCII.GetString(new byte[] { 27, 112, 48, 55, 121 }));
                    }
                    else
                    {
                        this.Close();
                    }
                }
                else
                {
                    this.Close();
                }
            }
        }

        private void nudPengeluaran_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnOK.Focus();
            }
        }
    }
}
