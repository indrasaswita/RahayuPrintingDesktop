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
    public partial class StationeryBukaPack : Form
    {
        MainForm main;
        List<DetailBukaPackList> list;

        public StationeryBukaPack(MainForm main)
        {
            this.main = main;
            list = new List<DetailBukaPackList>();

            InitializeComponent();
        }

        public DataTable ExecuteQuery(string query)
        {
            return main.ExecuteQuery(query);
        }

        private void StationeryBukaPack_Load(object sender, EventArgs e)
        {
            gridCart.Columns.Clear();
            gridCart.Columns.Add("", "Kode");
            gridCart.Columns[0].Width = 65;
            gridCart.Columns.Add("", "Nama Barang");
            gridCart.Columns[1].Width = 240;
            gridCart.Columns.Add("", "Perubahan Stock");
            gridCart.Columns[2].Width = 80;

            RefreshBukaPackList();
            RefreshBukaPackListUI();
        }

        private void RefreshBukaPackList()
        {
            panelBukaPak.Controls.Clear();
            DataTable dt = ExecuteQuery("SELECT barangID, barangIDEceran, jumlahEcer, namaBarang, (SELECT namaBarang FROM MsBarang WHERE barangID = a.barangIDEceran) AS namaBarangEceran FROM MsBarang a WHERE NOT barangIDEceran = '' ORDER BY namaBarang ASC");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string barangID = dt.Rows[i]["barangID"].ToString();
                string barangIDEceran = dt.Rows[i]["barangIDEceran"].ToString();
                int jumlahEcer = Int32.Parse(dt.Rows[i]["jumlahEcer"].ToString());
                string namaBarang = dt.Rows[i]["namaBarang"].ToString();
                string namaBarangEceran = dt.Rows[i]["namaBarangEceran"].ToString();

                DetailBukaPackList temp = new DetailBukaPackList(this, barangID, barangIDEceran, namaBarang, namaBarangEceran, jumlahEcer);
                list.Add(temp);
            }
        }

        private void RefreshBukaPackListUI()
        {
            for (int i = 0; i < list.Count; i++)
            {
                list[i].Location = new Point(1, 1 + (i * (list[i].Height + 1)));
                panelBukaPak.Controls.Add(list[i]);
            }
        }

        private void tbNamaBarangRetail_Enter(object sender, EventArgs e)
        {
            nudPak.Focus();
            nudPak.Select(0, 9);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private string barangIDPak, barangIDEceran;

        public void SetSelectedItem(string barangID, string barangIDEceran, string namaBarang, string namaBarangEceran, int jumlahEcer)
        {
            tbNamaBarangPak.Text = namaBarang;
            tbNamaBarangRetail.Text = namaBarangEceran;
            barangIDPak = barangID;
            this.barangIDEceran = barangIDEceran;
            nudPerPak.Value = jumlahEcer;
            nudPak.Value = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gridCart.Rows.Add(barangIDPak, tbNamaBarangPak, "-" + nudPak.Value);
            gridCart.Rows.Add(barangIDEceran, tbNamaBarangRetail, "+" + nudJumlah.Value);
        }

        private void nudPerPak_ValueChanged(object sender, EventArgs e)
        {
            nudJumlah.Value = nudPak.Value * nudPerPak.Value;
        }

        private void nudPak_ValueChanged(object sender, EventArgs e)
        {
            nudJumlah.Value = nudPak.Value * nudPerPak.Value;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            barangIDEceran = "";
            barangIDPak = "";
            tbNamaBarangRetail.Text = "";
            tbNamaBarangPak.Text = "";
            nudPerPak.Value = 0;
            nudPak.Value = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (gridCart.Rows.Count > 0)
            {
                for (int i = 0; i < gridCart.Rows.Count; i++)
                {
                    string barangID = gridCart.Rows[i].Cells[0].Value.ToString();
                    string add = gridCart.Rows[i].Cells[2].Value.ToString();
                    //MessageBox.Show("UPDATE MsBarang SET stock = stock + '" + add + "' WHERE barangID = '" + barangID + "'");
                    ExecuteQuery("UPDATE MsBarang SET stock = stock + '" + add + "' WHERE barangID = '" + barangID + "'");
                }
                this.Dispose();
            }
            else
            {
                main.SetMessage("Belum ada isi, belum bisa submit");
            }
        }
    }
}
