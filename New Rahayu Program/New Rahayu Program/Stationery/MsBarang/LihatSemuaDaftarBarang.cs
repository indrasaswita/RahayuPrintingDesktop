using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Rahayu_Program.Stationery.MsBarang
{
    public partial class LihatSemuaDaftarBarang : Form
    {
        private MainForm main;
        
        public LihatSemuaDaftarBarang(MainForm main)
        {
            this.main = main;
            this.MdiParent = main;

            InitializeComponent();
        }

        public DataTable ExecuteQuery(string query)
        {
            return main.ExecuteQuery(query);
        }

        private void LihatSemuaDaftarBarang_Load(object sender, EventArgs e)
        {
            gridSearch.Columns.Clear();
            gridSearch.Columns.Add("", "ID");
            gridSearch.Columns.Add("", "Nama Barang");
            gridSearch.Columns[0].Width = 65;
            gridSearch.Columns[1].Width = 244;
        }

        private void clearField()
        {
            tbNomorBarang.Text = "";
            tbNamaBarang.Text = "";
            tbBarcodeAsli.Text = "";
            nudHargaBeli.Value = 0;
            nudPrice.Value = 0;
            nudStock.Value = 0;
            nudMin.Value = 0;
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            if (tbSearch.Text != "")
            {
                DataTable dt = new DataTable();
                if (Char.IsLetter(tbSearch.Text[0]))
                    dt = ExecuteQuery("SELECT * FROM MsBarang WHERE namaBarang LIKE '%" + tbSearch.Text + "%'");
                else if (Char.IsDigit(tbSearch.Text[0]))
                {
                    if (tbSearch.Text.Length <= 6)
                        dt = ExecuteQuery("SELECT * FROM MsBarang WHERE barangID LIKE '%" + tbSearch.Text + "%'");
                    else
                        dt = ExecuteQuery("SELECT * FROM MsBarang WHERE barangBarcode LIKE '%" + tbSearch.Text + "%'");
                }
                if (dt.Rows.Count != 0)
                {
                    gridSearch.Rows.Clear();

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        gridSearch.Rows.Add(dt.Rows[i]["barangID"].ToString(), dt.Rows[i]["namaBarang"].ToString());
                    }
                }
            }
            else
            {
                gridSearch.Rows.Clear();
            }
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                clickGridSearch();
            }
        }

        private void clickGridSearch()
        {
            if (gridSearch.Rows.Count > 0)
            {
                tbNomorBarang.Text = gridSearch.Rows[gridSearch.CurrentRow.Index].Cells[0].Value.ToString();
                tbNomorBarang.Focus();
                tbNomorBarang.Select(0, 9);

                nmrBarangDiEnter();
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            clickGridSearch();
        }

        private void tbSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (gridSearch.Rows.Count > 0)
            {
                if (e.KeyCode == Keys.Down && gridSearch.CurrentRow.Index < gridSearch.Rows.Count - 1)
                {
                    gridSearch.CurrentCell = gridSearch.Rows[gridSearch.CurrentRow.Index + 1].Cells[0];
                }
                else if (e.KeyCode == Keys.Up && gridSearch.CurrentRow.Index > 0)
                {
                    gridSearch.CurrentCell = gridSearch.Rows[gridSearch.CurrentRow.Index - 1].Cells[0];
                }
                else if (e.KeyCode == Keys.Enter)
                {
                    tbNomorBarang.Text = gridSearch.Rows[gridSearch.CurrentRow.Index].Cells[0].Value.ToString();
                    nmrBarangDiEnter();
                }
            }
            else
            {
                if (e.KeyCode == Keys.Enter)
                {
                    tbSearch.Text = "Cari Disini";
                    tbNomorBarang.Text = "";
                    tbNomorBarang.Focus();
                    tbNomorBarang.SelectAll();
                }
            }
        }

        private void nmrBarangDiEnter()
        {
            comboBox1.Text = "";
            if (tbNomorBarang.Text.StartsWith("R") == true && tbNomorBarang.Text.Length == 7)
            {
                tbNomorBarang.Text = tbNomorBarang.Text.Substring(1);

                DataTable dt = ExecuteQuery("SELECT * FROM MsBarang WHERE barangID = '" + tbNomorBarang.Text + "'");
                if (dt.Rows.Count == 1)
                {
                    addBarangToEditing(dt);
                }
                else
                {
                    tbBarcodeAsli.Text = "";
                    tbNomorBarang.Text = "";
                    tbNomorBarang.Focus();
                }
            }
            else if (tbNomorBarang.Text.Length > 6)
            {
                DataTable dt = ExecuteQuery("SELECT * FROM MsBarang WHERE barangBarcode = '" + tbNomorBarang.Text + "'");
                if (dt.Rows.Count == 1)
                {
                    addBarangToEditing(dt);
                }
                else
                {
                    tbBarcodeAsli.Text = "";
                    tbNomorBarang.Text = "";
                    tbNomorBarang.Focus();
                }
            }
            else if (tbNomorBarang.Text.Length == 6)
            {
                DataTable dt = ExecuteQuery("SELECT * FROM MsBarang WHERE barangID = '" + tbNomorBarang.Text + "'");
                if (dt.Rows.Count == 1)
                {
                    addBarangToEditing(dt);
                }
                else
                {
                    tbBarcodeAsli.Text = "";
                    tbNomorBarang.Text = "";
                    tbNomorBarang.Focus();
                }
            }
            else
            {
                tbNomorBarang.Text = "";
                tbNomorBarang.Focus();
            }
        }

        private Image barImg;

        private void addBarangToEditing(DataTable dt)
        {
            tbNomorBarang.Text = dt.Rows[0]["barangID"].ToString();
            tbNamaBarang.Text = dt.Rows[0]["namaBarang"].ToString();
            tbBarcodeAsli.Text = dt.Rows[0]["barangBarcode"].ToString();
            nudHargaBeli.Value = Convert.ToDecimal(Int32.Parse(dt.Rows[0]["buyPrice"].ToString()));
            nudPrice.Value = Convert.ToDecimal(Int32.Parse(dt.Rows[0]["sellPrice"].ToString()));
            nudStock.Value = Convert.ToDecimal(Int32.Parse(dt.Rows[0]["stock"].ToString()));
            nudMin.Value = Convert.ToDecimal(Int32.Parse(dt.Rows[0]["batasStock"].ToString()));

            comboBox1.SelectedIndex = Int32.Parse(dt.Rows[0]["nomorRak"].ToString()) - 1;

            //CETAK BARCODE!
            barImg = Util.Barcode.Barcode.createBarcode(tbNomorBarang.Text);


            nudStock.Focus();
            nudStock.Select(0, 9);
        }

        private void tbNomorBarang_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && tbNomorBarang.Text != "")
            {
                nmrBarangDiEnter();
            }
        }

        private void nudStock_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                nudMin.Focus();
                nudMin.Select(0, 9);
            }
        }

        private void nudMin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                nudHargaBeli.Focus();
                nudHargaBeli.Select(0, 9);
            }
        }

        private void nudHargaBeli_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                nudPrice.Focus();
                nudPrice.Select(0, 9);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (tbNamaBarang.Text != "")
            {
                ExecuteQuery("UPDATE MsBarang SET barangBarcode = '" + tbBarcodeAsli.Text + "', namaBarang = '" + tbNamaBarang.Text + "', sellPrice = " + nudPrice.Value + ", buyPrice = " + nudHargaBeli.Value + ", batasStock = " + nudMin.Value + ", stock = " + nudStock.Value + ", nomorRak = " + (comboBox1.SelectedIndex + 1) + " WHERE barangID = '" + tbNomorBarang.Text + "'");

                clearField();
                tbNomorBarang.Focus();
                tbNomorBarang.SelectAll();
            }
        }

        private void tbSearch_Enter(object sender, EventArgs e)
        {
            if (tbSearch.Text == "Cari Disini!")
            {
                tbSearch.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Rahayu_Program.Report.ReportForm reportForm = new Rahayu_Program.Report.ReportForm(main);
            reportForm.MdiParent = main;
            reportForm.WindowState = FormWindowState.Maximized;

            DataTable dt;
            dt = main.ExecuteQuery("SELECT barangID, namaBarang, nomorRak, sellPrice FROM MsBarang WHERE stock = 0 OR stock < 0");

            if (dt == null)
            {
                MessageBox.Show("OPEN REPORT ERROR (PRINT STOCK HABIS STATIONERY)");
                this.Dispose();
            }
            else
            {
                if (dt.Rows.Count > 0)
                {
                    Rahayu_Program.Report.Stationery.LaporanRekapAwal laporan = new Rahayu_Program.Report.Stationery.LaporanRekapAwal();
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

        private void button2_Click(object sender, EventArgs e)
        {
            Rahayu_Program.Report.ReportForm reportForm = new Rahayu_Program.Report.ReportForm(main);
            reportForm.MdiParent = main;
            reportForm.WindowState = FormWindowState.Maximized;

            DataTable dt;
            dt = main.ExecuteQuery("SELECT barangID, namaBarang, nomorRak, sellPrice FROM MsBarang WHERE batasStock = 0");

            if (dt == null)
            {
                MessageBox.Show("OPEN REPORT ERROR (PRINT STOCK HABIS STATIONERY)");
                this.Dispose();
            }
            else
            {
                if (dt.Rows.Count > 0)
                {
                    Rahayu_Program.Report.Stationery.LaporanRekapAwal laporan = new Rahayu_Program.Report.Stationery.LaporanRekapAwal();
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
            this.Hide();
        }

        private void nudPrice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnOK.Focus();
            }
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnSearch_Click(sender, e);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            tbSearch.Text = "";
            tbSearch.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Yakin di DELETE '" + tbNamaBarang.Text + "' (" + tbNomorBarang.Text + ")?", "Delete Confirmation", MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                ExecuteQuery("DELETE FROM MsBarang WHERE barangID = '" + tbNomorBarang.Text + "'");
                clearField();
            }
        }
    }
}
