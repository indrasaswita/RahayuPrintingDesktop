using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OnBarcode.Barcode;
using System.Drawing.Printing;

namespace Rahayu_Program.Stationery.MsBarang
{
    public partial class PrintBarcode : Form
    {
        private Config.Conn conn;
        private Image barImg;
        private Font courierFont, kodeFont;
        private string hargaBeli;

        public PrintBarcode(MainForm main)
        {
            conn = new Config.Conn();
            conn.Connect();

            this.MdiParent = main;
            courierFont = new Font("Courier New", 6, FontStyle.Bold);
            kodeFont = new Font("Courier New", 12, FontStyle.Bold);

            //MessageBox.Show("123000 : " + buatKodeHuruf("123000"));
            //MessageBox.Show("105000 : " + buatKodeHuruf("105000"));
            //MessageBox.Show("100000 : " + buatKodeHuruf("100000"));
            //MessageBox.Show("12345 : " + buatKodeHuruf("12345"));
            //MessageBox.Show("500500 : " + buatKodeHuruf("500500"));

            InitializeComponent();
        }

        private void PrintBarcode_Load(object sender, EventArgs e)
        {
            RefreshUI();
        }

        public void RefreshUI()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("", "ID");
            dataGridView1.Columns.Add("", "Nama Barang");
            dataGridView1.Columns[0].Width = 65;
            dataGridView1.Columns[1].Width = 240;

            tbNomorBarang.Text = "";
            tbNamaBarang.Text = "";
            tbBarcodeAsli.Text = "";
            nudPrice.Value = 0;
            nudQty.Value = 1;
            pictureBox1.Image = null;
            tbNomorBarang.Focus();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            tbSearch.Text = "";
            tbSearch.Focus();
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            if (tbSearch.Text != "")
            {
                DataTable dt = new DataTable();
                if (Char.IsLetter(tbSearch.Text[0]))
                    dt = conn.ExecuteQuery("SELECT * FROM MsBarang WHERE namaBarang LIKE '%" + tbSearch.Text + "%'");
                else if (Char.IsDigit(tbSearch.Text[0]))
                {
                    if (tbSearch.Text.Length <= 6)
                        dt = conn.ExecuteQuery("SELECT * FROM MsBarang WHERE barangID LIKE '%" + tbSearch.Text + "%'");
                    else
                        dt = conn.ExecuteQuery("SELECT * FROM MsBarang WHERE barangBarcode LIKE '%" + tbSearch.Text + "%'");
                }
                if (dt.Rows.Count != 0)
                {
                    dataGridView1.Rows.Clear();

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        dataGridView1.Rows.Add(dt.Rows[i]["barangID"].ToString(), dt.Rows[i]["namaBarang"].ToString());
                    }
                }
            }
        }

        private void tbSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                if (e.KeyCode == Keys.Down && dataGridView1.CurrentRow.Index < dataGridView1.Rows.Count - 1)
                {
                    dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.CurrentRow.Index + 1].Cells[0];
                }
                else if (e.KeyCode == Keys.Up && dataGridView1.CurrentRow.Index > 1)
                {
                    dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.CurrentRow.Index - 1].Cells[0];
                }
                else if (e.KeyCode == Keys.Enter)
                {
                    tbNomorBarang.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
                    nmrBarangDiEnter();
                }
            }
        }

        private void addBarangToEditing(DataTable dt)
        {
            tbNomorBarang.Text = dt.Rows[0]["barangID"].ToString();
            tbNamaBarang.Text = dt.Rows[0]["namaBarang"].ToString();
            tbBarcodeAsli.Text = dt.Rows[0]["barangBarcode"].ToString();
            hargaBeli = dt.Rows[0]["buyPrice"].ToString();
            nudPrice.Value = Convert.ToDecimal(Int32.Parse(dt.Rows[0]["sellPrice"].ToString()));
            nudQty.Text = "1";

            //CETAK BARCODE!
            barImg = Util.Barcode.Barcode.createBarcode(tbNomorBarang.Text);
            pictureBox1.Image = barImg;

            nudQty.Focus();
            nudQty.Select(0, 9);
        }

        private void nmrBarangDiEnter()
        {
            if (tbNomorBarang.Text.StartsWith("R") == true && tbNomorBarang.Text.Length == 7)
            {
                tbNomorBarang.Text = tbNomorBarang.Text.Substring(1);

                DataTable dt = conn.ExecuteQuery("SELECT * FROM MsBarang WHERE barangID = '" + tbNomorBarang.Text + "'");
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
                DataTable dt = conn.ExecuteQuery("SELECT * FROM MsBarang WHERE barangBarcode = '" + tbNomorBarang.Text + "'");
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
                DataTable dt = conn.ExecuteQuery("SELECT * FROM MsBarang WHERE barangID = '" + tbNomorBarang.Text + "'");
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
                tbNamaBarang.Text = "";
                tbBarcodeAsli.Text = "";
                nudPrice.Value = 0;
                nudQty.Value = 1;
                pictureBox1.Image = null;

                tbNomorBarang.Focus();
            }
        }

        private void tbNomorBarang_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && tbNomorBarang.Text != "")
            {
                nmrBarangDiEnter();
            }
        }

        private void nudQty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnOK.Focus();
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            //PRINT BARCODENYA

            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(printPage);
            pd.PrinterSettings.PrinterName = "ZDesigner GK420t";
            pd.PrintController = new StandardPrintController();

            try
            {
                for (int i = 0; i < nudQty.Value; i++)
                    pd.Print();
                tbNomorBarang.Focus();
                tbNomorBarang.Select(0, 9);
            }
            catch (Exception ex)
            {
                if (ex.Message == "Settings to access printer '" + pd.PrinterSettings.PrinterName + "' are not valid.")
                {
                    MessageBox.Show("Printer IS NOT INSTALLED YET");
                }
                else
                    MessageBox.Show(ex.Message);
            }

            //BUAT CEK PRINTER APA?
            //PrintDialog printDialog1 = new PrintDialog();
            //printDialog1.Document = pd;
            //DialogResult result = printDialog1.ShowDialog();
            //MessageBox.Show(printDialog1.PrinterSettings.PrinterName);
        }

        private void printPage(object o, PrintPageEventArgs e)
        {
            Util.Barcode.Barcode.printBarcodeLayout(e.Graphics, courierFont, kodeFont, barImg, tbNamaBarang.Text, tbNomorBarang.Text, hargaBeli, Convert.ToInt32(nudPrice.Value));
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tbNomorBarang.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
                nmrBarangDiEnter();
            }
        }

        private void tbSearch_Enter(object sender, EventArgs e)
        {
            if (tbSearch.Text == "Cari Disini!")
            {
                tbSearch.Text = "";
            }
        }

        private void tbSearch_Leave(object sender, EventArgs e)
        {
            if (tbSearch.Text == "")
            {
                tbSearch.Text = "Cari Disini!";
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void tbNomorBarang_TextChanged(object sender, EventArgs e)
        {
            if (tbNomorBarang.Text.Length >= 6)
            {
                nmrBarangDiEnter();
            }
            else
            {
                tbNamaBarang.Text = "";
                tbBarcodeAsli.Text = "";
                nudPrice.Value = 0;
                nudQty.Value = 1;
                pictureBox1.Image = null;
            }
        }
    }
}
