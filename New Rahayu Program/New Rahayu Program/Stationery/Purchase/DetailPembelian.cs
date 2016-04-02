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
    public partial class DetailPembelian : UserControl
    {
        private InputPembelian parent;
        private int index;

        private string barangID, namaBarang, kode;
        private int qty, hargaBeli;
        private int totalHarga;

        public DetailPembelian(InputPembelian parent, string barangID, string namaBarang, int qty, int hargaBeli, string kode)
        {
            this.parent = parent;
            this.barangID = barangID;
            this.namaBarang = namaBarang;
            this.qty = qty;
            this.hargaBeli = hargaBeli;
            this.kode = kode;
            totalHarga = qty * hargaBeli;

            InitializeComponent();
        }

        private void DetailPembelian_Load(object sender, EventArgs e)
        {
            tb_namaBarang.Text = namaBarang;
            tbQty.Text = qty.ToString("#,##0");
            tbHarga.Text = kode;//hargaBeli.ToString("#,##0");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            parent.DeleteListBeliByIndex(index);
        }

        public void SetIndex(int index)
        {
            this.index = index;
        }

        public int GetTotal()
        {
            return totalHarga;
        }

        public string GetBarangID()
        {
            return barangID;
        }

        public int GetQty()
        {
            return qty;
        }

        public int GetBuyPrice()
        {
            return hargaBeli;
        }
    }
}
