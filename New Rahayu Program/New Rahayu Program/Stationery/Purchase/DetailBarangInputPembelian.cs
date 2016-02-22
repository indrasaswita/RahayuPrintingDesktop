using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Rahayu_Program.Stationery.Purchase
{
    public partial class DetailBarangInputPembelian : UserControl
    {
        private string barangID;
        private string namaBarang;
        private int qty;
        private int hargaBeli;
        private int totalHarga;

        private InputPembelian parent;

        public DetailBarangInputPembelian(InputPembelian parent, string barangID, string namaBarang, int qty, int hargaBeli)
        {
            this.parent = parent;

            this.barangID = barangID;
            this.namaBarang = namaBarang;
            this.qty = qty;
            this.hargaBeli = hargaBeli;

            InitializeComponent();
        }

        private void DetailBarangInputPembelian_Load(object sender, EventArgs e)
        {
            tbNamaBarang.Text = namaBarang;
            tbNomorBarang.Text = barangID;
            nudQty.Value = qty;
            nudHargaBeli.Value = hargaBeli;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //if(nudQty.Value * nudHargaBeli.Value != 0)
            parent.InputBeliKeCart(barangID, namaBarang, Convert.ToInt32(nudQty.Value), Convert.ToInt32(nudHargaBeli.Value));
        }

        private void nudQty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                nudHargaBeli.Focus();
            }
        }

        private void nudHargaBeli_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button2.Focus();
            }
        }

        private void nudHargaBeli_ValueChanged(object sender, EventArgs e)
        {
            hargaBeli = Convert.ToInt32(nudHargaBeli.Value);
            totalHarga = Convert.ToInt32(nudQty.Value) * Convert.ToInt32(nudHargaBeli.Value);
            parent.CalculateTotal();
        }

        private void nudQty_ValueChanged(object sender, EventArgs e)
        {
            qty = Convert.ToInt32(nudQty.Value);
            totalHarga = Convert.ToInt32(nudQty.Value) * Convert.ToInt32(nudHargaBeli.Value);
            parent.CalculateTotal();
        }

        public int GetTotal()
        {
            return totalHarga;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
