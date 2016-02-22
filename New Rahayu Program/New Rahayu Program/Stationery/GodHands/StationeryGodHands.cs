using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Rahayu_Program.Stationery.GodHands
{
    public partial class StationeryGodHands : Form
    {
        private MainForm main;
        private int minStockLama;
        private int hargaBeliLama;

        public StationeryGodHands(MainForm main)
        {
            this.main = main;
            this.MdiParent = main;

            InitializeComponent();
        }

        private DataTable ExecuteQuery(string query)
        {
            return main.ExecuteQuery(query);
        }

        private void btnChangeStock_Click(object sender, EventArgs e)
        {
            if (nudChangeStockValue.Value >= 0)
            {
                int dari = Convert.ToInt32(nudStock.Value);
                int jadi = Convert.ToInt32(nudChangeStockValue.Value);
                int rubah = jadi - dari;

                ExecuteQuery("INSERT INTO StationeryChangeValue (changeValueTime, employeeID, changeValueType, barangID, information, description) VALUES(now(), " + main.globalEmployeeID + ", 'STOCK', '" + tbNomorBarang.Text + "', 'From " + dari + " (" + (rubah > 0 ? "+" : "") + rubah + ") To " + jadi + "', '" + tbChangeStockDesc.Text + "')");
                ExecuteQuery("UPDATE MsBarang SET stock = '" + nudChangeStockValue.Value + "' WHERE barangID = '" + tbNomorBarang.Text + "'");

                string temp = tbNomorBarang.Text;
                tbNomorBarang.Text = "";
                tbChangeStockDesc.Text = "";
                nudChangeStockValue.Value = 0;
                tbNomorBarang.Text = temp;

                tbNomorBarang.Focus();
                tbNomorBarang.Select(0, 9);
            }
            else
            {
                main.SetMessage("Change Stock Value Mustn't be ZERO (Jumlah Perubahan Stock Tidak Boleh Kosong)");
            }
        }

        private void tbNomorBarang_TextChanged(object sender, EventArgs e)
        {
            if (tbNomorBarang.Text.Length == 6)
            {
                DataTable dt = ExecuteQuery("SELECT * FROM MsBarang WHERE barangID = '" + tbNomorBarang.Text + "'");
                if (dt != null)
                {
                    if (dt.Rows.Count == 1)
                    {
                        tbNamaBarang.Text = dt.Rows[0]["namaBarang"].ToString();
                        tbBarcodeAsli.Text = dt.Rows[0]["barangBarcode"].ToString();
                        nudJual.Value = Int32.Parse(dt.Rows[0]["sellPrice"].ToString());
                        nudBeli.Value = Int32.Parse(dt.Rows[0]["buyPrice"].ToString());
                        hargaBeliLama = Convert.ToInt32(nudBeli.Value);
                        nudMin.Value = Int32.Parse(dt.Rows[0]["batasStock"].ToString());
                        minStockLama = Convert.ToInt32(nudMin.Value);
                        nudStock.Value = Int32.Parse(dt.Rows[0]["stock"].ToString());
                        nudEtalase.Text = dt.Rows[0]["nomorRak"].ToString();

                        btnRefresh_Click(sender, e);
                    }
                }
            }
            else if (tbNomorBarang.Text.Length > 6)
            {
                DataTable dt = ExecuteQuery("SELECT barangID FROM MsBarang WHERE barangBarcode = '" + tbBarcodeAsli.Text + "'");
                if (dt != null)
                {
                    if (dt.Rows.Count == 1)
                    {
                        tbNomorBarang.Text = dt.Rows[0]["barangID"].ToString();
                    }
                }
            }
            else
            {
                gridHistory.Rows.Clear();
                tbNamaBarang.Text = "";
                tbBarcodeAsli.Text = "";
                nudBeli.Value = 0;
                nudJual.Value = 0;
                nudStock.Value = 0;
                nudMin.Value = 1;
                nudEtalase.Value = 1;
            }
        }

        private void StationeryGodHands_Load(object sender, EventArgs e)
        {
            gridHistory.Columns.Add("", "Tgl");
            gridHistory.Columns[0].Width = 150;
            gridHistory.Columns.Add("", "Jenis");
            gridHistory.Columns[1].Width = 130;
            gridHistory.Columns.Add("", "Perubahan");
            gridHistory.Columns[2].Width = 322;
            gridHistory.Columns.Add("", "Alasan");
            gridHistory.Columns[3].Width = 195;

            tbNomorBarang.Focus();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DataTable dt = ExecuteQuery("SELECT DATE_FORMAT(changeValueTime, '%d/%m/%Y %H:%i') AS tanggal, changeValueType, information, description FROM StationeryChangeValue WHERE barangID = '" + tbNomorBarang.Text + "' ORDER BY changeValueID DESC");

            gridHistory.Rows.Clear();
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    for(int i = 0; i < dt.Rows.Count; i++)
                        gridHistory.Rows.Add(dt.Rows[i]["tanggal"].ToString(), dt.Rows[i]["changeValueType"].ToString(), dt.Rows[i]["information"].ToString(), dt.Rows[i]["description"].ToString());
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void tbNomorBarang_Click(object sender, EventArgs e)
        {
            tbNomorBarang.Focus();
            tbNomorBarang.Select(0, 9);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (nudJualBaru.Value != 0)
            {
                int dari = Convert.ToInt32(nudStock.Value);
                int jadi = Convert.ToInt32(nudChangeStockValue.Value);
                int rubah = jadi - dari;

                ExecuteQuery("INSERT INTO StationeryChangeValue (changeValueTime, employeeID, changeValueType, barangID, information, description) VALUES(now(), " + main.globalEmployeeID + ", 'HRG JUAL', '" + tbNomorBarang.Text + "', 'From " + nudJual.Value + "  To " + nudJualBaru.Value + "', '" + tbJualBaruDesc.Text + "')");
                ExecuteQuery("UPDATE MsBarang SET sellPrice = '" + nudJualBaru.Value + "' WHERE barangID = '" + tbNomorBarang.Text + "'");

                string temp = tbNomorBarang.Text;
                tbNomorBarang.Text = "";
                nudJualBaru.Value = 0;
                tbJualBaruDesc.Text = "";
                tbNomorBarang.Text = temp;

                tbNomorBarang.Focus();
                tbNomorBarang.Select(0, 9);
            }
            else
            {
                main.SetMessage("Change Stock Value Mustn't be ZERO (Jumlah Perubahan Stock Tidak Boleh Kosong)");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (tbNamaBarangBaru.Text.Length <= 24 && tbNamaBarangBaru.Text.Length > 3)
            {
                ExecuteQuery("UPDATE MsBarang SET namaBarang = '" + tbNamaBarangBaru.Text + "' WHERE barangID = '" + tbNomorBarang.Text + "'");
                ExecuteQuery("INSERT INTO StationeryChangeValue (changeValueTime, employeeID, changeValueType, barangID, information, description) VALUES(now(), " + main.globalEmployeeID + ", 'NAMA', '" + tbNomorBarang.Text + "', 'From " + tbNamaBarang.Text + " To " + tbNamaBarangBaru.Text + "', '- NO Description -')");

                string temp = tbNomorBarang.Text;
                tbNomorBarang.Text = "";
                tbNamaBarangBaru.Text = "";
                tbNomorBarang.Text = temp;

                tbNomorBarang.Focus();
                tbNomorBarang.Select(0, 9);
            }
            else
            {
                main.SetMessage("Nama Barang Baru tidak boleh lebih dari 24 characters.");
            }
        }

        private void btnNomorBaru_Click(object sender, EventArgs e)
        {
            if (tbNomorBarangBaru.Text.Length == 6)
            {
                DataTable dt = ExecuteQuery("SELECT * FROM MsBarang WHERE barangID = '" + tbNomorBarangBaru.Text + "'");
                if (dt != null)
                {
                    if (dt.Rows.Count == 0)
                    {
                        ExecuteQuery("UPDATE MsBarang SET barangID = '" + tbNomorBarangBaru.Text + "' WHERE barangID = '" + tbNomorBarang.Text + "'");
                        ExecuteQuery("UPDATE StationeryChangeValue SET barangID = '" + tbNomorBarangBaru.Text + "' WHERE barangID = '" + tbNomorBarang.Text + "'");
                        ExecuteQuery("UPDATE StationeryPurchaseDetail SET barangID = '" + tbNomorBarangBaru.Text + "' WHERE barangID = '" + tbNomorBarang.Text + "'");
                        ExecuteQuery("UPDATE StationerySalesDetail SET barangID = '" + tbNomorBarangBaru.Text + "' WHERE barangID = '" + tbNomorBarang.Text + "'");
                        ExecuteQuery("UPDATE StationeryRekapStockDetail SET barangID = '" + tbNomorBarangBaru.Text + "' WHERE barangID = '" + tbNomorBarang.Text + "'");
                        ExecuteQuery("INSERT INTO StationeryChangeValue (changeValueTime, employeeID, changeValueType, barangID, information, description) VALUES(now(), " + main.globalEmployeeID + ", 'BRG ID', '" + tbNomorBarangBaru.Text + "', 'From " + tbNomorBarang.Text + " To " + tbNomorBarangBaru.Text + "', '- NO Description -')");

                        string temp = tbNomorBarangBaru.Text;
                        tbNomorBarang.Text = "";
                        tbNomorBarangBaru.Text = "";
                        tbNomorBarang.Text = temp;

                        tbNomorBarang.Focus();
                        tbNomorBarang.Select(0, 9);
                    }
                }
            }
            else
            {
                main.SetMessage("Nomor Barang Baru harus terdiri dari 6 characters.");
            }
        }

        private void tbNamaBarangBaru_TextChanged(object sender, EventArgs e)
        {
            lblNamaLength.Text = String.Format("{0:D2}", tbNamaBarangBaru.Text.Length);
        }

        private void btnEtalaseBaru_Click(object sender, EventArgs e)
        {
            ExecuteQuery("UPDATE MsBarang SET nomorRak = '" + nudEtalaseBaru.Value + "' WHERE barangID = '" + tbNomorBarang.Text + "'");
            ExecuteQuery("INSERT INTO StationeryChangeValue (changeValueTime, employeeID, changeValueType, barangID, information, description) VALUES(now(), " + main.globalEmployeeID + ", 'ETALASE', '" + tbNomorBarang.Text + "', 'From " + nudEtalase.Value + " To " + nudEtalaseBaru.Value + "', '- NO Description -')");
            tbNomorBarang_TextChanged(sender, e);
        }

        Search.SearchBarangStationery searchBarang;

        private void btnSearch_Click(object sender, EventArgs e)
        {
            searchBarang = new Search.SearchBarangStationery(main);
            DialogResult result = searchBarang.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                tbNomorBarang.Text = main.globalBarangID;
            }
        }

        private void nudChangeStockValue_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btnChangeStock_Click(sender, e);
        }

        private void nudJualBaru_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) button2_Click(sender, e);
        }

        private void tbNomorBarangBaru_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btnNomorBaru_Click(sender, e);
        }

        private void nudEtalaseBaru_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btnEtalaseBaru_Click(sender, e);
        }

        private void tbNamaBarangBaru_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) button4_Click(sender, e);
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnSearch_Click(sender, e);
        }

        private void tbChangeStockDesc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnChangeStock_Click(sender, e);
            }
        }

        private void btnKeluarGudang_Click(object sender, EventArgs e)
        {
            tbChangeStockDesc.Text = "keluar gudang";
            btnChangeStock_Click(sender, e);
        }

        private void btnMasukGudang_Click(object sender, EventArgs e)
        {
            tbChangeStockDesc.Text = "masuk gudang";
            btnChangeStock_Click(sender, e);
        }

        private void btnStockUlang_Click(object sender, EventArgs e)
        {
            tbChangeStockDesc.Text = "stock ulang";
            btnChangeStock_Click(sender, e);
        }

        private void btnBarangRusak_Click(object sender, EventArgs e)
        {
            tbChangeStockDesc.Text = "barang rusak";
            btnChangeStock_Click(sender, e);
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            tbChangeStockDesc.Text = "return";
            btnChangeStock_Click(sender, e);
        }

        private void tbJualBaruDesc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button2_Click(sender, e);
            }
        }

        private void tbNomorBarang_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                nudChangeStockValue.Focus();
                nudChangeStockValue.Select(0, 9);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (nudMin.Value >= 0)
            {
                ExecuteQuery("UPDATE MsBarang SET batasStock = '" + nudMin.Value + "' WHERE barangID = '" + tbNomorBarang.Text + "'");
                ExecuteQuery("INSERT INTO StationeryChangeValue (changeValueTime, employeeID, changeValueType, barangID, information, description) VALUES(now(), " + main.globalEmployeeID + ", 'BATAS STOCK', '" + tbNomorBarang.Text + "', 'From " + minStockLama + " To " + nudMin.Value + "', 'normal')");
                tbNomorBarang_TextChanged(sender, e);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (nudBeli.Value >= 0)
            {
                ExecuteQuery("UPDATE MsBarang SET buyPrice = '" + nudBeli.Value + "' WHERE barangID = '" + tbNomorBarang.Text + "'");
                ExecuteQuery("INSERT INTO StationeryChangeValue (changeValueTime, employeeID, changeValueType, barangID, information, description) VALUES(now(), " + main.globalEmployeeID + ", 'UBAH HARGA BELI', '" + tbNomorBarang.Text + "', 'From " + hargaBeliLama + " To " + nudBeli.Value + "', 'normal')");
                tbNomorBarang_TextChanged(sender, e);
            }
        }
    }
}
