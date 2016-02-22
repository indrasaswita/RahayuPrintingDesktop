using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Rahayu_Program.Stationery.Sales
{
    public partial class InputBarangByBarcode : Form
    {
        private Config.Conn conn;
        public InputBarangByBarcode(MainForm main)
        {
            InitializeComponent();
            this.MdiParent = main;
            conn = new Config.Conn();
            conn.Connect();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.ExecuteQuery("INSERT INTO MsBarang VALUES('" + tbNomorBarang.Text + "', '" + textBox1.Text + "', '" + tbNamaBarang.Text + "', " + nudPrice.Value + ", " + 0 + ", 0, '', 0, " + 0 + ", " +textBox2.Text+ ", 1)");

            RefreshUI();
        }

        private void tbNomorBarang_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                apusWarnaButton();
                string a = tbNomorBarang.Text;

                DataTable dt = conn.ExecuteQuery("SELECT * FROM MsBarang WHERE barangID = '" + tbNomorBarang.Text + "'");
                if (dt.Rows.Count == 0)
                {
                    nudPrice.Value = 1;
                    textBox1.Text = "";
                    tbNamaBarang.Text = "";
                    textBox1.Focus();
                }
                else
                {
                    textBox1.Text = dt.Rows[0]["barangBarcode"].ToString();
                    tbNamaBarang.Text = dt.Rows[0]["namaBarang"].ToString();
                    nudPrice.Value = Convert.ToDecimal(dt.Rows[0]["sellPrice"]);
                    textBox2.Text = dt.Rows[0]["nomorRak"].ToString();

                    if (textBox2.Text == "1") button4.BackColor = Color.DarkGreen;
                    if (textBox2.Text == "2") button5.BackColor = Color.DarkGreen;
                    if (textBox2.Text == "3") button6.BackColor = Color.DarkGreen;
                    if (textBox2.Text == "4") button7.BackColor = Color.DarkGreen;
                    if (textBox2.Text == "5") button8.BackColor = Color.DarkGreen;
                    if (textBox2.Text == "6") button9.BackColor = Color.DarkGreen;
                    if (textBox2.Text == "7") button10.BackColor = Color.DarkGreen;
                    if (textBox2.Text == "8") button11.BackColor = Color.DarkGreen;
                    if (textBox2.Text == "9") button12.BackColor = Color.DarkGreen;
                    if (textBox2.Text == "10") button13.BackColor = Color.DarkGreen;
                    if (textBox2.Text == "11") button14.BackColor = Color.DarkGreen;
                    if (textBox2.Text == "12") button15.BackColor = Color.DarkGreen;
                    if (textBox2.Text == "13") button16.BackColor = Color.DarkGreen;
                    if (textBox2.Text == "14") button17.BackColor = Color.DarkGreen;
                    if (textBox2.Text == "15") button18.BackColor = Color.DarkGreen;
                    if (textBox2.Text == "16") button19.BackColor = Color.DarkGreen;
                    if (textBox2.Text == "17") button21.BackColor = Color.DarkGreen;
                    if (textBox2.Text == "18") button23.BackColor = Color.DarkGreen;
                    if (textBox2.Text == "19") button25.BackColor = Color.DarkGreen;
                    if (textBox2.Text == "20") button26.BackColor = Color.DarkGreen;
                    if (textBox2.Text == "21") button20.BackColor = Color.DarkGreen;
                    if (textBox2.Text == "22") button22.BackColor = Color.DarkGreen;
                }
                tbNomorBarang.Text = a;
            }
        }

        private void tbNomorBarang_TextChanged(object sender, EventArgs e)
        {
            //RefreshUI();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RefreshUI();
        }

        private void InputBarangByBarcode_Load(object sender, EventArgs e)
        {
            RefreshUI();
        }

        public void RefreshUI()
        {
            tbNomorBarang.Text = "";
            nudPrice.Value = 1;
            textBox1.Text = "";
            tbNamaBarang.Text = "";
            pesan.Visible = false;
            apusWarnaButton();
            tbNomorBarang.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            conn.ExecuteQuery("UPDATE MsBarang SET barangBarcode = '" + textBox1.Text + "', namaBarang = '" + tbNamaBarang.Text + "', sellPrice = " + nudPrice.Value + ", nomorRak = " + textBox2.Text + " WHERE barangID = '" + tbNomorBarang.Text + "'");

            tbNomorBarang.Text = "";
            nudPrice.Value = 1;
            textBox1.Text = "";
            tbNamaBarang.Text = "";
            apusWarnaButton();
            tbNomorBarang.Focus();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tbNamaBarang.Focus();
            }
        }

        private void tbNamaBarang_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (tbNamaBarang.Text.Length < 25)
                {
                    nudPrice.Focus();
                    nudPrice.Select(0, 99);
                    pesan.Visible = false;
                }
                else
                {
                    pesan.Visible = true;
                }
            }
        }

        private void nudPrice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.Focus();
            }
        }

        private void tbNamaBarang_TextChanged(object sender, EventArgs e)
        {
            numericUpDown1.Value = tbNamaBarang.Text.Length;
        }

        private void apusWarnaButton()
        {
            button4.BackColor = Color.Maroon;
            button5.BackColor = Color.Maroon;
            button6.BackColor = Color.Maroon;
            button7.BackColor = Color.Maroon;
            button8.BackColor = Color.Maroon;
            button9.BackColor = Color.Maroon;
            button10.BackColor = Color.Maroon;
            button11.BackColor = Color.Maroon;
            button12.BackColor = Color.Maroon;
            button13.BackColor = Color.Maroon;
            button14.BackColor = Color.Maroon;
            button15.BackColor = Color.Maroon;
            button16.BackColor = Color.Maroon;
            button17.BackColor = Color.Maroon;
            button18.BackColor = Color.Maroon;
            button19.BackColor = Color.Maroon;
            button20.BackColor = Color.Maroon;
            button21.BackColor = Color.Maroon;
            button22.BackColor = Color.Maroon;
            button23.BackColor = Color.Maroon;
            button25.BackColor = Color.Maroon;
            button26.BackColor = Color.Maroon;
        }

        private void haha(int angka)
        {
            apusWarnaButton();

            if (angka + "" == "1") button4.BackColor = Color.DarkGreen;
            if (angka + "" == "2") button5.BackColor = Color.DarkGreen;
            if (angka + "" == "3") button6.BackColor = Color.DarkGreen;
            if (angka + "" == "4") button7.BackColor = Color.DarkGreen;
            if (angka + "" == "5") button8.BackColor = Color.DarkGreen;
            if (angka + "" == "6") button9.BackColor = Color.DarkGreen;
            if (angka + "" == "7") button10.BackColor = Color.DarkGreen;
            if (angka + "" == "8") button11.BackColor = Color.DarkGreen;
            if (angka + "" == "9") button12.BackColor = Color.DarkGreen;
            if (angka + "" == "10") button13.BackColor = Color.DarkGreen;
            if (angka + "" == "11") button14.BackColor = Color.DarkGreen;
            if (angka + "" == "12") button15.BackColor = Color.DarkGreen;
            if (angka + "" == "13") button16.BackColor = Color.DarkGreen;
            if (angka + "" == "14") button17.BackColor = Color.DarkGreen;
            if (angka + "" == "15") button18.BackColor = Color.DarkGreen;
            if (angka + "" == "16") button19.BackColor = Color.DarkGreen;
            if (angka + "" == "17") button21.BackColor = Color.DarkGreen;
            if (angka + "" == "18") button23.BackColor = Color.DarkGreen;
            if (angka + "" == "19") button25.BackColor = Color.DarkGreen;
            if (angka + "" == "20") button26.BackColor = Color.DarkGreen;
            if (angka + "" == "21") button20.BackColor = Color.DarkGreen;
            if (angka + "" == "22") button22.BackColor = Color.DarkGreen;
            
            textBox2.Text = "" + angka;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            haha(1);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            haha(2);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            haha(3);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            haha(4);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            haha(5);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            haha(6);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            haha(7);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            haha(8);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            haha(9);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            haha(10);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            haha(11);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            haha(12);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            haha(13);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            haha(14);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            haha(15);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            haha(16);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            haha(17);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            haha(18);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            haha(19);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            haha(20);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            haha(21);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            haha(22);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
