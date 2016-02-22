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
    public partial class InputStockByBarang : Form
    {
        private List<DetailBarangInputStock> list;
        private MainForm main;

        public InputStockByBarang(MainForm main)
        {
            this.main = main;
            this.MdiParent = main;
            list = new List<DetailBarangInputStock>();

            InitializeComponent();
        }

        private void InputStockByBarang_Load(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
        }

        private void showRakWithCondition(string query)
        {
            list.Clear();
            DataTable dt = ExecuteQuery("SELECT * FROM MsBarang " + query);

            
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string nomorBarang = dt.Rows[i]["barangID"].ToString();
                    string namaBarang = dt.Rows[i]["namaBarang"].ToString();
                    int stock = Int32.Parse(dt.Rows[i]["stock"].ToString());
                    int batasStock = Int32.Parse(dt.Rows[i]["batasStock"].ToString());
                    int hargaJual = Int32.Parse(dt.Rows[i]["sellPrice"].ToString());
                    int hargaBeli = Int32.Parse(dt.Rows[i]["buyPrice"].ToString());
                    addNewList(nomorBarang, namaBarang, stock, batasStock, hargaJual, hargaBeli);
                }
            }
            showList();
        }

        public DataTable ExecuteQuery(string query)
        {
            return main.ExecuteQuery(query);
        }

        private void showByRak(int group)
        {
            list.Clear();
            DataTable dt = ExecuteQuery("SELECT * FROM MsBarang WHERE nomorRak = " + group + "");

            list = new List<DetailBarangInputStock>();
            if (dt.Rows.Count > 0)
            {
                for(int i = 0; i < dt.Rows.Count; i++)
                {
                    string nomorBarang = dt.Rows[i]["barangID"].ToString();
                    string namaBarang = dt.Rows[i]["namaBarang"].ToString();
                    int stock = Int32.Parse(dt.Rows[i]["stock"].ToString());
                    int batasStock = Int32.Parse(dt.Rows[i]["batasStock"].ToString());
                    int hargaJual = Int32.Parse(dt.Rows[i]["sellPrice"].ToString());
                    int hargaBeli = Int32.Parse(dt.Rows[i]["buyPrice"].ToString());
                    addNewList(nomorBarang, namaBarang, stock, batasStock, hargaJual, hargaBeli);
                }
            }
            showList();
        }

        private void addNewList(string nomorBarang, string namaBarang, int stock, int batasStock, int hargaJual, int hargaBeli)
        {
            DetailBarangInputStock temp = new DetailBarangInputStock(this, nomorBarang, namaBarang, stock, batasStock, hargaJual, hargaBeli);

            list.Add(temp);
        }

        private void showList()
        {
            Point location = panel1.Location;
            Size size = panel1.Size;
            Color bg = panel1.BackColor;

            this.Controls.Remove(panel1);
            panel1.Dispose();
            panel1 = new Panel();

            panel1.Location = location;
            panel1.Size = size;
            panel1.BackColor = bg;
            panel1.AutoScroll = true;

            this.Controls.Add(panel1);

            if (list != null && list.Count != 0)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    list[i].Location = new Point(1, 1 + ((list[i].Height + 1) * i));
                    panel1.Controls.Add(list[i]);
                }
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            showByRak(1);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            showByRak(2);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            showByRak(3);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            showByRak(4);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            showByRak(5);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            showByRak(6);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            showByRak(7);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            showByRak(8);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            showByRak(9);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            showByRak(10);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            showByRak(11);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            showByRak(12);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            showByRak(13);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            showByRak(14);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            showByRak(15);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            showByRak(16);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            showByRak(17);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            showByRak(18);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            showByRak(19);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            showByRak(20);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            showByRak(21);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            showByRak(22);
        }

        internal void SetNext(DetailBarangInputStock detailBarangInputStock)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (detailBarangInputStock == list[i])
                {
                    if (i + 1 < list.Count)
                        list[i + 1].FocusOn();
                    else
                        list[i].FocusOn();
                }
            }
        }

        private void button29_Click(object sender, EventArgs e)
        {
            showRakWithCondition("WHERE barangID LIKE '5%' OR barangID LIKE '6%' OR barangID LIKE '7%' OR barangID LIKE '8%' OR barangID LIKE '9%'");
        }

        private void button27_Click(object sender, EventArgs e)
        {
            showRakWithCondition("WHERE barangID LIKE '4%'");
        }

        private void button28_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button30_Click(object sender, EventArgs e)
        {
            showRakWithCondition("WHERE barangID LIKE '1%'");
        }

        private void button31_Click(object sender, EventArgs e)
        {
            showRakWithCondition("WHERE barangID LIKE '34%' OR barangID LIKE '35%'");
        }

        private void button32_Click(object sender, EventArgs e)
        {
            showRakWithCondition("WHERE barangID LIKE '2%'");
        }

        private void button33_Click(object sender, EventArgs e)
        {
            showRakWithCondition("WHERE barangID LIKE '30%'");
        }

        private void button34_Click(object sender, EventArgs e)
        {
            showRakWithCondition("WHERE barangID LIKE '312%' or  barangID LIKE '311%' or  barangID LIKE '313%' or  barangID LIKE '314%' or  barangID LIKE '310%'");
        }

        private void button35_Click(object sender, EventArgs e)
        {
            showRakWithCondition("WHERE barangID LIKE '32%'");
        }

        private void button36_Click(object sender, EventArgs e)
        {
            showRakWithCondition("WHERE barangID LIKE '33%'");
        }

        private void button37_Click(object sender, EventArgs e)
        {
            showRakWithCondition("WHERE barangID LIKE '316%' or  barangID LIKE '315%' or  barangID LIKE '317%' or  barangID LIKE '318%' or  barangID LIKE '319%'");
        }
    }
}
