using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Rahayu_Program.Stationery
{
    public partial class DetailMiniItem : UserControl
    {
        private string nomor;
        private string namabarang;
        private int harga;
        private int qty;
        private Stationery.Sales.CreateSalesStationery main;

        public int GetHargaJual()
        {
            return harga;
        }

        public int GetQty()
        {
            return qty;
        }

        public string GetNamaBarang()
        {
            return namabarang;
        }

        public string getNomor()
        {
            return nomor;
        }

        public int getTotalHarga()
        {
            try
            {
                return Convert.ToInt32(numericUpDown3.Value);
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public int getQty()
        {
            return qty;
        }

        public void deleteItem()
        {
            main.deleteDetail(this);
        }

        public DetailMiniItem(Stationery.Sales.CreateSalesStationery main, string nomor, string namabarang, int qty, int harga)
        {
            this.main = main;
            this.nomor = nomor;
            this.namabarang = namabarang;
            this.qty = qty;
            this.harga = harga;

            InitializeComponent();
        }

        private void DetailMiniItem_Load(object sender, EventArgs e)
        {
            setBackground((Color) ColorTranslator.FromHtml("#002266"));
            tbNamaBarang.Text = namabarang;
            nudPrice.Value = harga;
            nudQty.Value = qty > nudQty.Maximum ? nudQty.Maximum : qty;
        }

        public void setBackground(Color color)
        {
            this.BackColor = color;
            button1.BackColor = color;
            button1.ForeColor = color;
            nudQty.BackColor = color;
            nudPrice.BackColor = color;
            numericUpDown3.BackColor = color;
            tbNamaBarang.BackColor = color;
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            nudQty.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            deleteItem();
        }

        private void nudQty_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown3.Value = Util.MathPlus.pembulatan500(nudQty.Value, nudPrice.Value);
            qty = Convert.ToInt32(nudQty.Value);
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            main.updateHarga();
        }

        private void nudPrice_ValueChanged(object sender, EventArgs e)
        {
            harga = Convert.ToInt32(nudPrice.Value);
        }
    }
}
