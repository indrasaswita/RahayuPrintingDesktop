using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Rahayu_Program.Stationery.MsBarang
{
    public partial class DetailBukaPackList : UserControl
    {
        private StationeryBukaPack parent;
        private string barangID;
        private string barangIDEceran;
        private string namaBarang;
        private string namaBarangEceran;
        private int jumlahEcer;
        
        public DetailBukaPackList(StationeryBukaPack parent, string barangID, string barangIDEceran, string namaBarang, string namaBarangEceran, int jumlahEcer)
        {
            this.parent = parent;
            this.barangID = barangID;
            this.barangIDEceran = barangIDEceran;
            this.namaBarang = namaBarang;
            this.namaBarangEceran = namaBarangEceran;
            this.jumlahEcer = jumlahEcer;

            InitializeComponent();
        }

        private void DetailBukaPackList_Load(object sender, EventArgs e)
        {
            tbPerPack.Text = jumlahEcer + "";
            tbNamaBarang.Text = namaBarang;
            tbNamaBarangEceran.Text = namaBarangEceran;
            tbBarangID.Text = barangID;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            parent.SetSelectedItem(barangID, barangIDEceran, namaBarang, namaBarangEceran, jumlahEcer);
        }
    }
}
