using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace Rahayu_Program.Stationery.Sales
{
    public partial class CreateSalesStationery : Form
    {
        List<DetailMiniItem> detailMini;
        Config.Conn conn;

        DateTime previousKeyPressTime;
        string lastQty;

        private MainForm main;
        private int bayar;

        public CreateSalesStationery(MainForm main)
        {
            conn = new Config.Conn();
            conn.Connect();
            InitializeComponent();
            this.MdiParent = main;
            this.main = main;

            detailMini = new List<DetailMiniItem>();
        }

        private void numericUpDown8_Enter(object sender, EventArgs e)
        {
            btnOK.Focus();
        }

        private void CreateSalesStationery_Load(object sender, EventArgs e)
        {
            RefreshUI();
        }

        public void RefreshUI()
        {
            detailMini.Clear();

            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("", "ID");
            dataGridView1.Columns.Add("", "Nama Barang");
            dataGridView1.Columns[0].Width = 65;
            dataGridView1.Columns[1].Width = 240;

            btn200.Visible = false;
            clearCartDetail();
            tbNomorBarang.Focus();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            addBarangToDetail();
            clearInputDetail();
        }

        private void clearCartDetail()
        {
            detailMini.Clear();
            panelDetail.Controls.Clear();
            clearInputDetail();
        }

        private void clearInputDetail()
        {
            tbNomorBarang.Text = "";
            tbNamaBarang.Text = "";
            nudPrice.Value = 0;
            tbSearch.Text = "";
            tbQty.Text = "1";
            tbNomorBarang.Focus();
        }

        private void addBarangToDetail()
        {
            Boolean enter = true;
            try
            {
                Int32.Parse(tbQty.Text.Trim().Replace(",", "").Replace(".",""));
            }
            catch (Exception)
            {
                enter = false;
            }
            if (tbNamaBarang.Text == "") enter = false;
            if (tbNomorBarang.Text.Length < 6) enter = false;

            if (enter)
            {
                // --> MASUKIN KE DETAIL LIST
                // --> 1. CEK DULU ADA YANG SAMA GA? (KALO SAMA, DITAMBAHIN QTY-NYA)
                int qtyTemp = 0;
                foreach (DetailMiniItem i in detailMini)
                {
                    if (tbNomorBarang.Text == i.getNomor())
                    {
                        qtyTemp = i.getQty();
                        deleteDetail(i);
                        refreshDetail();
                        break;
                    }
                }
                //tbQty.Text = Int32.Parse(lastQty) + "";

                //======================TAMBAHIN BARANG======================================
                //DITAMBAHIN BARANG YANG DI DELETE SUPAYA NAMBAH
                DetailMiniItem item = new DetailMiniItem(this, tbNomorBarang.Text, tbNamaBarang.Text, Int32.Parse(tbQty.Text) + qtyTemp, Convert.ToInt32(nudPrice.Value));
                //item.Location = new Point(1, 1 + (detailMini.Count * (item.Height + 2)));
                detailMini.Add(item);

                refreshDetail();
                //============================================================================

                tbNomorBarang.Text = textBox1.Text;
                nmrBarangDiEnter();

                //BERSIHIN BUFFER LAGI
                lastQty = "";
                textBox1.Text = "";
                tbQty.Text = "1";
            }
        }

        public void updateHarga()
        {
            int total = 0;
            for (int i = 0; i < detailMini.Count; i++)
            {
                total += detailMini[i].getTotalHarga();
            }
            nudTotalBelanja.Value = total;
        }

        private void refreshDetail()
        {
            panelDetail.Controls.Clear();
            for (int i = 0; i < detailMini.Count; i++)
            {
                detailMini[i].Location = new Point(1, 1 + (i * (detailMini[i].Height + 2)));
                panelDetail.Controls.Add(detailMini[i]);
            }
            numericUpDown4.Value = detailMini.Count;
            updateHarga();
        }

        private void tbNomorBarang_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && tbNomorBarang.Text != "")
            {
                nmrBarangDiEnter();
            }
        }

        private string activeBarcode = "";

        private void nmrBarangDiEnter()
        {
            try
            {
                Int32.Parse(tbNomorBarang.Text);
            }
            catch(Exception e)
            {
                tbNomorBarang.Text = "";
                tbNomorBarang.Focus();
                tbNomorBarang.Select(0, 9);
                return;
            }

            price200 = false;

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
                    activeBarcode = "";
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
                    activeBarcode = "";
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
                    activeBarcode = "";
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

        private void addBarangToEditing(DataTable dt)
        {
            tbNomorBarang.Text = dt.Rows[0]["barangID"].ToString();
            tbNamaBarang.Text = dt.Rows[0]["namaBarang"].ToString();
            activeBarcode = dt.Rows[0]["barangBarcode"].ToString();
            nudPrice.Value = Convert.ToDecimal(Int32.Parse(dt.Rows[0]["sellPrice"].ToString()));
            tbQty.Text = "1";
            tbQty.Focus();
            tbQty.Select(0, 9);
        }

        private void nudQty_ValueChanged(object sender, EventArgs e)
        {
            nudTotalPrice.Value = Int32.Parse(tbQty.Text) * nudPrice.Value;
        }

        public void deleteDetail(DetailMiniItem item)
        {
            for (int i = 0; i < detailMini.Count; i++)
            {
                if (detailMini[i].getNomor() == item.getNomor())
                    detailMini.RemoveAt(i);
            }
            refreshDetail();
        }

        private void tbQty_KeyDown(object sender, KeyEventArgs e)
        {
            if (tbQty.Text.Length > 0)
                lastQty = lastQty + tbQty.Text.Substring(tbQty.Text.Length - 1);
            else
                lastQty = "0";
            //if (e.KeyCode == Keys.Enter)
            //{
            //    previousKeyPressTime = new DateTime();
            //}
            //else
            //{
            if (previousKeyPressTime == null)
            {
                previousKeyPressTime = DateTime.Now;
            }

            DateTime startTime = DateTime.Now;
            TimeSpan runLength = startTime.Subtract(previousKeyPressTime);
            int millisecs = runLength.Milliseconds;
            int secs = runLength.Seconds;
            int TotalMiliSecs = ((secs * 1000) + millisecs);

            if (TotalMiliSecs <= 50)
            {
                //.INI BRARTI SELESAI INPUT DARI BARCODE SCANNER
                textBox1.Text = textBox1.Text + tbQty.Text.Substring(tbQty.Text.Length - 1);
                if (e.KeyCode == Keys.Enter)
                {
                    lastQty = lastQty.Substring(0, lastQty.Length - textBox1.Text.Length);

                    //CEK DULU KALO YANG DIMASUKIN ADA 'Rxxx' ATAU '899xxxx'
                    if (textBox1.Text == tbNomorBarang.Text || textBox1.Text == activeBarcode || (textBox1.Text.Substring(1) == tbNomorBarang.Text && textBox1.Text[0] == 'R'))
                    {
                        addQtyBy1(lastQty);
                    }
                    else
                    {
                        addBarangToDetail();
                    }
                    lastQty = "";
                    textBox1.Text = "";
                }
                else
                {
                }
            }
            else
            {
                if (e.KeyCode == Keys.Enter)
                {
                    //btnOK.Focus();
                    btnOK_Click(sender, e);
                }
                else
                {
                    lastQty = tbQty.Text;
                    textBox2.Text = lastQty;
                }
            }
            previousKeyPressTime = DateTime.Now;
            //}
        }

        private void tbQty_TextChanged(object sender, EventArgs e)
        {
            if (tbQty.Text.Length > 0 && tbQty.Text.Length <= 5)
            {
                nudTotalPrice.Value = Util.MathPlus.pembulatan500(Convert.ToDecimal(Int32.Parse(tbQty.Text)), nudPrice.Value);
                if (tbNomorBarang.Text == "500003" && price200 == false)
                {
                    int jumlah = Int32.Parse(tbQty.Text);
                    if (jumlah <= 10)
                    {
                        if (jumlah == 1 || jumlah == 2)
                            nudPrice.Value = 500;
                        else if (jumlah == 3)
                            nudPrice.Value = 1000 / 3;
                        else if (jumlah == 4)
                            nudPrice.Value = 1500 / 4;
                        else if (jumlah == 5 || jumlah == 10)
                            nudPrice.Value = 300;
                        else if (jumlah == 6)
                            nudPrice.Value = 2000 / 6;
                        else if (jumlah == 7)
                            nudPrice.Value = 2500 / 7;
                        else if (jumlah == 8)
                            nudPrice.Value = 2500 / 8;
                        else if (jumlah == 9)
                            nudPrice.Value = 3000 / 9;
                    }
                    else
                    {
                        nudPrice.Value = 250;
                        int subtotal = 250 * jumlah;
                        int pembulatan = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(subtotal) / 500)) * 500;
                        nudPrice.Value = pembulatan / jumlah;
                    }
                }
            }
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button37_Click(sender, e);
        }

        private void submitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button6_Click(sender, e);
        }

        public DataTable ExecuteQuery(string query)
        {
            return main.ExecuteQuery(query);
        }

        DateTime tm;

        public void printReceipt(int bayar)
        {
            this.bayar = bayar;
            //INPUT DATA KE DATABASE ====================================================
            ExecuteQuery("INSERT INTO StationerySalesHeader(salesTime, paymentMethod) VALUES (NOW(), 'CASH')");
            DataTable dt = ExecuteQuery("SELECT stationerySalesID, DATE_FORMAT(NOW(), '%d/%m/%Y %H:%i:%s') AS time FROM StationerySalesHeader ORDER BY stationerySalesID DESC LIMIT 0, 1");
            if (dt.Rows.Count == 1)
            {
                int id = Int32.Parse(dt.Rows[0]["stationerySalesID"].ToString());
                string temp = dt.Rows[0]["time"].ToString();
                tm = Other.Parser.TimeFromString(temp);
                for (int i = 0; i < detailMini.Count; i++)
                {
                    ExecuteQuery("INSERT INTO StationerySalesDetail VALUES (" + id + ", '" + detailMini[i].getNomor() + "', " + detailMini[i].GetHargaJual() + ", " + detailMini[i].GetQty() + ", 0)");
                    ExecuteQuery("UPDATE MsBarang SET stock = stock - " + detailMini[i].GetQty() + " WHERE barangID = '" + detailMini[i].getNomor() + "'");
                }
            }
            //===============================================================================

            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(printPage);
            pd.PrinterSettings.PrinterName = System.IO.File.ReadAllText(Application.StartupPath + @"\config\printer\stationery-sales-nota.is");
            pd.PrintController = new StandardPrintController();

            //PrintDialog printDialog1 = new PrintDialog();
            //printDialog1.Document = pd;
            //DialogResult result = printDialog1.ShowDialog();
            //MessageBox.Show(printDialog1.PrinterSettings.PrinterName);

            try
            {
                pd.Print();
            }catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void printPage(object o, PrintPageEventArgs e)
        {
            Font f = new Font("Courier New", 9, FontStyle.Regular);
            printSalesReceipt(e.Graphics, f);
        }

        private Point p(int x, int y)
        {
            return new Point(x, y);
        }

        public void printSalesReceipt(Graphics g, Font f)
        {
            Brush b = Brushes.Black;
            //g.DrawString("012345678901234568790123456789012", f, b, p(0, 0));
            g.DrawString("     TLP. 649 1502, 649 1101", f, b, p(0, 10));
            g.DrawString("---------------------------------", f, b, p(0, 25));

            g.DrawString(String.Format("{0,-16}{1,16}", tm.ToString("dd.MM.yy hh:mm"), "STATIONERY"), f, b, p(0, 35));
            g.DrawString("---------------------------------", f, b, p(0, 45));
            int y =60; //awal dari item list beli
            int grandTotal = 0;
            for (int i = 0; i < detailMini.Count; i++)
            {
                g.DrawString(String.Format("{0,4} {1,-24}", detailMini[i].GetQty().ToString(), detailMini[i].GetNamaBarang()), f, b, p(0, y)); 
                g.DrawString(String.Format("{0,7} {1,10}", detailMini[i].GetHargaJual().ToString(), detailMini[i].getTotalHarga().ToString("#,##0")), f, b, p(108, y + 12));
                grandTotal += detailMini[i].getTotalHarga();

                y += 27;
            }
            g.DrawString("              -------------------", f, b, p(0, y-3));
            g.DrawString("              TOTAL : " + String.Format("{0,10}", grandTotal.ToString("#,##0")), f, b, p(0, y + 11));
            g.DrawString("              TUNAI : " + String.Format("{0,10}", bayar.ToString("#,##0")), f, b, p(0, y + 23));
            g.DrawString("            KEMBALI : " + String.Format("{0,10}", (bayar - grandTotal).ToString("#,##0")), f, b, p(0, y + 35));
            //g.DrawString("              -------------------", f, b, p(0, y + 60));
            g.DrawString("    BARANG YANG SUDAH DIBELI,", f, b, p(0, y + 58));
            g.DrawString("       TIDAK DAPAT DITUKAR", f, b, p(0, y + 68));
            g.DrawString("   ---------------------------", f, b, p(0, y + 78));
            g.DrawString("     SELAMAT BELANJA KEMBALI", f, b, p(0, y + 88));
            g.DrawString("          TERIMA KASIH", f, b, p(0, y + 98));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (tbNomorBarang.Text != "")
            {
                addBarangToDetail();
                clearInputDetail();
            }

            if (detailMini.Count > 0)
            {
                //MASUKKAN DATA - SUBMIT
                PaymentForm payment = new PaymentForm(main, Convert.ToInt32(nudTotalBelanja.Value));
                DialogResult result = payment.ShowDialog();
                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    clearCartDetail();
                    clearInputDetail();
                }
            }
        }

        private void button37_Click(object sender, EventArgs e)
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
            else
            {
                dataGridView1.Rows.Clear();
            }
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                if (e.KeyCode == Keys.Down && dataGridView1.CurrentRow.Index < dataGridView1.Rows.Count - 1)
                {
                    dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.CurrentRow.Index + 1].Cells[0];
                }
                else if (e.KeyCode == Keys.Up && dataGridView1.CurrentRow.Index >= 1)
                {
                    dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.CurrentRow.Index - 1].Cells[0];
                }
                else if (e.KeyCode == Keys.Enter)
                {
                    if (tbNomorBarang.Text != "")
                    {
                        addBarangToDetail();
                        clearInputDetail();
                    }

                    tbNomorBarang.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
                    
                    tbSearch.Text = "";
                    dataGridView1.Rows.Clear();

                    nmrBarangDiEnter();
                }
            }
        }
        
        private void addQtyBy1(string lastQty)
        {
            // --> REPEAT BARCODE + ITEM QTY
            tbQty.Text = (Int32.Parse(lastQty) + 1) + "";
            tbQty.Focus();
            tbQty.Select(0, 9);
        }

        private void addItemByCode(string code)
        {
            if (code == tbNomorBarang.Text || code == activeBarcode || (code.Substring(1) == tbNomorBarang.Text && code[0] == 'R'))
            {
                if (tbQty.Text.Length > 0)
                {
                    addQtyBy1(tbQty.Text);
                }
            }
            else if (tbNomorBarang.Text != "")
            {
                addBarangToDetail();
                selectBarang(code);
            }
            else
            {
                selectBarang(code);
            }
        }

        private void selectBarang(string code)
        {
            if (code.Substring(1) == tbNomorBarang.Text && code[0] == 'R')
                tbNomorBarang.Text = code.Substring(1);
            else
                tbNomorBarang.Text = code;
            nmrBarangDiEnter();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addItemByCode("500003");
        }
        private void button4_Click(object sender, EventArgs e)
        {
            addItemByCode("500001");
        }
        private void button5_Click(object sender, EventArgs e)
        {
            addItemByCode("500005");
        }
        private void button9_Click(object sender, EventArgs e)
        {
            addItemByCode("330001");
        }
        private void button7_Click(object sender, EventArgs e)
        {
            addItemByCode("330003");
        }
        private void button8_Click(object sender, EventArgs e)
        {
            addItemByCode("330005");
        }
        private void button19_Click(object sender, EventArgs e)
        {
            addItemByCode("308009");
        }
        private void button20_Click(object sender, EventArgs e)
        {
            addItemByCode("308006");
        }
        private void button21_Click(object sender, EventArgs e)
        {
            addItemByCode("321003");
        }
        private void button23_Click(object sender, EventArgs e)
        {
            addItemByCode("154015");
        }
        private void button25_Click(object sender, EventArgs e)
        {
            addItemByCode("052003");
        }
        private void button26_Click(object sender, EventArgs e)
        {
            addItemByCode("052002");
        }
        private void button29_Click(object sender, EventArgs e)
        {
            addItemByCode("316038");
        }
        private void button32_Click(object sender, EventArgs e)
        {
            addItemByCode("312012");
        }
        private void button33_Click(object sender, EventArgs e)
        {
            addItemByCode("312007");
        }
        private void button34_Click(object sender, EventArgs e)
        {
            addItemByCode("316040");
        }
        private void button32_Click_1(object sender, EventArgs e)
        {
            addItemByCode("312013");
        }
        private void button33_Click_1(object sender, EventArgs e)
        {
            addItemByCode("312009");
        }
        private void button34_Click_1(object sender, EventArgs e)
        {
            addItemByCode("312010");
        }
        private void button35_Click(object sender, EventArgs e)
        {
            addItemByCode("630220");
        }
        private void button36_Click(object sender, EventArgs e)
        {
            addItemByCode("630224");
        }

        private void button24_Click(object sender, EventArgs e)
        {
            addItemByCode("154014");
        }

        private void button27_Click(object sender, EventArgs e)
        {
            addItemByCode("302000");
        }

        private void button28_Click(object sender, EventArgs e)
        {
            addItemByCode("302221");
        }

        private void button30_Click(object sender, EventArgs e)
        {
            addItemByCode("312084");
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (tbSearch.Text == "")
            {
                tbSearch.Text = "Cari Disini!";
            }
        }

        private void tbSearch_Enter(object sender, EventArgs e)
        {
            if (tbSearch.Text == "Cari Disini!")
            {
                tbSearch.Text = "";
            }
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tbNomorBarang.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();

                dataGridView1.Rows.Clear();
                tbSearch.Text = "";

                nmrBarangDiEnter();
            }
        }

        private void CreateSalesStationery_Paint(object sender, PaintEventArgs e)
        {
            tbNomorBarang.Focus();
            tbNomorBarang.Select(0, 9);
        }

        private void tbNomorBarang_TextChanged(object sender, EventArgs e)
        {
            if (tbNomorBarang.Text == "500003" && btn200.Visible == false)
            {
                btn200.Visible = true;
            }
            else if (tbNomorBarang.Text != "500003" && btn200.Visible == true)
            {
                btn200.Visible = false;
            }
        }

        Boolean price200 = false;

        private void btn200_Click(object sender, EventArgs e)
        {
            price200 = true;
            nudPrice.Value = 200;
            tbQty.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            clearInputDetail();
        }

        private void nudPrice_ValueChanged(object sender, EventArgs e)
        {
            if (tbQty.Text.Length > 0 && tbQty.Text.Length <= 5)
            {
                nudTotalPrice.Value = Util.MathPlus.pembulatan500(Convert.ToDecimal(Int32.Parse(tbQty.Text)), nudPrice.Value);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            addItemByCode("110001");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            addItemByCode("110002");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            addItemByCode("110003");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            addItemByCode("130002");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            addItemByCode("130003");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            addItemByCode("130004");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            addItemByCode("130005");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            addItemByCode("130006");
        }

        private void button18_Click(object sender, EventArgs e)
        {
            addItemByCode("130007");
        }

        private void button31_Click(object sender, EventArgs e)
        {
            addItemByCode("154021");
        }

        private void button22_Click(object sender, EventArgs e)
        {
            addItemByCode("321005");
        }

        private void button37_Click_1(object sender, EventArgs e)
        {
            addItemByCode("321004");
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            clearCartDetail();
            clearInputDetail();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button39_Click(object sender, EventArgs e)
        {
            main.inputBarangByBarcodeToolStripMenuItem_Click(sender, e);
        }

        private void btnBukaPak_Click(object sender, EventArgs e)
        {
            Rahayu_Program.Stationery.MsBarang.StationeryBukaPack bukaPack = new MsBarang.StationeryBukaPack(main);
            DialogResult result = bukaPack.ShowDialog();
        }

        private void photoCopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }

        private void button40_Click(object sender, EventArgs e)
        {
            addItemByCode("052001");
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                tbNomorBarang.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

                tbSearch.Text = "";
                dataGridView1.Rows.Clear();

                nmrBarangDiEnter();
            }
        }

        private void button41_Click(object sender, EventArgs e)
        {
            addItemByCode("024002");
        }

        private void button42_Click(object sender, EventArgs e)
        {
            addItemByCode("301036");
        }

        private void button44_Click(object sender, EventArgs e)
        {
            addItemByCode("163103");
        }

        private void button45_Click(object sender, EventArgs e)
        {
            addItemByCode("163121");
        }

        private void button46_Click(object sender, EventArgs e)
        {
            addItemByCode("163127");
        }

        private void button47_Click(object sender, EventArgs e)
        {
            addItemByCode("201001");
        }

        private void button48_Click(object sender, EventArgs e)
        {
            addItemByCode("201002");
        }

        private void button49_Click(object sender, EventArgs e)
        {
            addItemByCode("201003");
        }

        private void stampToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StampCashier stC = new StampCashier(main);
            stC.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button51_Click(object sender, EventArgs e)
        {
            addItemByCode("301055");
        }

        private void button52_Click(object sender, EventArgs e)
        {
            addItemByCode("301036");
        }

        private void button53_Click(object sender, EventArgs e)
        {
            addItemByCode("301098");
        }

        private void button55_Click(object sender, EventArgs e)
        {
            addItemByCode("301034");
        }

        private void button56_Click(object sender, EventArgs e)
        {
            addItemByCode("301035");
        }

        private void button57_Click(object sender, EventArgs e)
        {
            addItemByCode("301015");
        }

        private void button50_Click(object sender, EventArgs e)
        {
            addItemByCode("313005");
        }

        private void button54_Click(object sender, EventArgs e)
        {
            addItemByCode("044001");
        }

        private void button58_Click(object sender, EventArgs e)
        {
            addItemByCode("044013");
        }

        private void button59_Click(object sender, EventArgs e)
        {
            addItemByCode("044014");
        }

        private void button60_Click(object sender, EventArgs e)
        {
            addItemByCode("044015");
        }

        private void button61_Click(object sender, EventArgs e)
        {
            addItemByCode("312029");
        }

        private void button62_Click(object sender, EventArgs e)
        {
            addItemByCode("312106");
        }

        private void button63_Click(object sender, EventArgs e)
        {
            addItemByCode("312032");
        }

        private void button68_Click(object sender, EventArgs e)
        {
            addItemByCode("312032");
        }

        private void button64_Click(object sender, EventArgs e)
        {
            addItemByCode("313177");
        }

        private void button65_Click(object sender, EventArgs e)
        {
            addItemByCode("340326");
        }

        private void button66_Click(object sender, EventArgs e)
        {
            addItemByCode("313889");
        }

        private void button67_Click(object sender, EventArgs e)
        {
            addItemByCode("340325");
        }

        private void button69_Click(object sender, EventArgs e)
        {
            addItemByCode("313014");
        }
    }
}
