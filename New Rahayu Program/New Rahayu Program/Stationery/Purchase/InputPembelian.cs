using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Rahayu_Program.Stationery.Purchase;

namespace Rahayu_Program.Stationery.Purchase
{
    public partial class InputPembelian : Form
    {
        private MainForm main;
        private List<DetailBarangInputPembelian> list;
        private List<DetailPembelian> listBeli;

        public InputPembelian(MainForm main)
        {
            this.main = main;

            InitializeComponent();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                //TIDAK ADA DATA YANG BISA DIPILIH
            }
            else
            {
                if (dataGridView1.CurrentRow.Index >= 0 && dataGridView1.CurrentRow.Index < dataGridView1.Rows.Count)
                {
                    SelectSupplier(Int32.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString()));
                }
            }
        }

        public DataTable ExecuteQuery(string query)
        {
            return main.ExecuteQuery(query);
        }

        private void SelectSupplier(int supplierID)
        {
            DataTable dt = ExecuteQuery("SELECT * FROM MsBarang WHERE supplierID = " + supplierID +" AND stock < batasStock");
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    list.Clear();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        DetailBarangInputPembelian temp;
                        string barangID = dt.Rows[i]["barangID"].ToString();
                        string namaBarang = dt.Rows[i]["namaBarang"].ToString();
                        int qty = 0;
                        int hargaBeli = Int32.Parse(dt.Rows[i]["buyPrice"].ToString());
                        temp = new DetailBarangInputPembelian(this, barangID, namaBarang, qty, hargaBeli);
                        list.Add(temp);
                    }
                    RefreshData();
                }
                else
                {
                    list.Clear();
                    panel1.Controls.Clear();
                }
            }
            else
            {
                MessageBox.Show("Eror: (INPUT PEMBELIAN) Tidak dapat munculin data dari msBarang berdasarkan supplierID");
            }
        }

        private void RefreshData()
        {
            panel1.Controls.Clear();
            for (int i = 0; i < list.Count; i++)
            {
                list[i].Location = new Point(1, 1 + ((list[i].Height + 1) * i));
                panel1.Controls.Add(list[i]);
            }
        }

        public void InputBeliKeCart(string barangID, string namaBarang, int qty, int hargaBeli)
        {
            Boolean dobel = false;
            int indexDobel = -1;
            for(int i = 0; i < listBeli.Count; i++)
            {
                if (listBeli[i].GetBarangID() == barangID)
                {
                    dobel = true;
                    indexDobel = i;
                    break;
                }
            }

            if (dobel && indexDobel != -1)
            {
                listBeli.RemoveAt(indexDobel);
            }

            DetailPembelian temp = new DetailPembelian(this, barangID, namaBarang, qty, hargaBeli);
            listBeli.Add(temp);
            RefreshListBeli();
        }

        private void InputPembelian_Load(object sender, EventArgs e)
        {
            this.MdiParent = main;

            list = new List<DetailBarangInputPembelian>();
            listBeli = new List<DetailPembelian>();

            dataGridView1.Columns.Add("", "id");
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns.Add("", "supplier");
            dataGridView1.Columns[1].Width = 192;

            gridSearch.Columns.Clear();
            gridSearch.Columns.Add("", "ID");
            gridSearch.Columns.Add("", "Nama Barang");
            gridSearch.Columns[0].Width = 65;
            gridSearch.Columns[1].Width = 240;

            DataTable dt = ExecuteQuery("SELECT * FROM MsSupplier");
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                        dataGridView1.Rows.Add(dt.Rows[i]["supplierID"].ToString(), dt.Rows[i]["supplierName"].ToString());
                }
            }
            else
            {
                MessageBox.Show("Eror: (INPUT PEMBELIAN) Tidak dapat munculin data dari MsSupplier berdasarkan supplierID");
            }
        }

        private void RefreshListBeli()
        {
            if (listBeli.Count > 0)
            {
                panel2.Controls.Clear();
                int totalHargaBeli = 0;
                for (int i = 0; i < listBeli.Count; i++)
                {
                    listBeli[i].Location = new Point(1, 1 + ((listBeli[i].Height + 1) * i));
                    listBeli[i].SetIndex(i);
                    totalHargaBeli += listBeli[i].GetTotal();
                    panel2.Controls.Add(listBeli[i]);
                }
                tbTotal.Text = totalHargaBeli.ToString("#,##0");
            }
            else
            {
                panel2.Controls.Clear();
                tbTotal.Text = "0";
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        internal void DeleteListBeliByIndex(int index)
        {
            listBeli.RemoveAt(index);
            RefreshListBeli();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            if (listBeli.Count > 0)
            {
                for (int i = 0; i < listBeli.Count; i++)
                {
                    MakeNewPurchase();
                }
            }
        }

        private void MakeNewPurchase()
        {
            if (listBeli.Count > 0)
            {
                ExecuteQuery("INSERT INTO StationeryPurchaseHeader(purchaseTime) VALUES (now())");
                DataTable dt = ExecuteQuery("SELECT stationeryPurchaseID FROM StationeryPurchaseHeader ORDER BY stationeryPurchaseID DESC LIMIT 0, 1");
                if (dt.Rows.Count == 1)
                {
                    int id = Int32.Parse(dt.Rows[0]["stationeryPurchaseID"].ToString());
                    int hargaBeliSebelom = 0;
                    DataTable dt2;
                    for (int i = 0; i < listBeli.Count; i++)
                    {
                        dt2 = ExecuteQuery("SELECT buyPrice FROM MsBarang WHERE barangID = '" + listBeli[i].GetBarangID() + "'");
                        if (dt2.Rows.Count == 0)
                        {
                            //belom ada harga beli
                            hargaBeliSebelom = 0;
                        }
                        else
                        {
                            hargaBeliSebelom = Int32.Parse(dt2.Rows[0]["buyPrice"].ToString());
                        }
                        ExecuteQuery("INSERT INTO StationeryChangeValue (changeValueTime, employeeID, changeValueType, barangID, information, description) VALUES (now(), " + main.globalEmployeeID + ", 'PURCHASE ITEM', '" + listBeli[i].GetBarangID() + "', 'BELI " + listBeli[i].GetQty() + " (" + hargaBeliSebelom + " -> " + listBeli[i].GetBuyPrice() + ")', 'normal')");
                        ExecuteQuery("UPDATE MsBarang SET stock = stock + " + listBeli[i].GetQty() + ", buyPrice = " + listBeli[i].GetBuyPrice() + " WHERE barangID = '" + listBeli[i].GetBarangID() + "'");
                        ExecuteQuery("INSERT INTO StationeryPurchaseDetail VALUES (" + id + ", '" + listBeli[i].GetBarangID() + "', " + listBeli[i].GetQty() + ", " + listBeli[i].GetBuyPrice() + ", " + hargaBeliSebelom + ")");
                    }
                }
                listBeli.Clear();
                panel2.Controls.Clear();
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            InputBeliKeCart(tbNomorBarang.Text, tbNamaBarang.Text, Convert.ToInt32(nudQty.Value), Util.Barcode.Barcode.buatHargaDariKode(tbKode.Text, Convert.ToInt32(nudPrice.Value)));
            tbNomorBarang.Text = "";
            tbNamaBarang.Text = "";
            nudPrice.Value = 0;
            tbBarcodeAsli.Text = "";
            nudQty.Value = 1;
            tbKode.Text = "";
            tbNomorBarang.Focus();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnSearch_Click(sender, e);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            tbSearch.Text = "";
            tbSearch.Focus();
        }

        private void tbSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (gridSearch.Rows.Count > 0)
                if (e.KeyCode == Keys.Down)
                {
                    int index = gridSearch.CurrentRow.Index;
                    if (index < gridSearch.Rows.Count - 1)
                    {
                        gridSearch.CurrentCell = gridSearch.Rows[index + 1].Cells[0];
                    }
                }
                else if (e.KeyCode == Keys.Up)
                {
                    int index = gridSearch.CurrentRow.Index;
                    if (index > 0)
                    {
                        gridSearch.CurrentCell = gridSearch.Rows[index - 1].Cells[0];
                    }
                }
                else if (e.KeyCode == Keys.Enter)
                {
                    int index = gridSearch.CurrentRow.Index;
                    tbNomorBarang.Text = gridSearch.Rows[index].Cells[0].Value.ToString();

                    tbNomorBarang.Focus();
                    nmrBarangDiEnter();
                }
                else { }
            else if (e.KeyCode == Keys.Enter)
            {
                tbNomorBarang.Focus();
                nmrBarangDiEnter();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                tbNomorBarang.Focus();
                tbNomorBarang.SelectAll();
            }
        }

        private void tbNomorBarang_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                nmrBarangDiEnter();
            }
        }

        private void nmrBarangDiEnter()
        {
            if (tbNomorBarang.Text.Length == 6 && Other.Validasi.isDigit(tbNomorBarang.Text))
            {
                DataTable dt = ExecuteQuery("SELECT * FROM MsBarang WHERE barangID = '" + tbNomorBarang.Text + "'");
                if (dt.Rows.Count == 1)
                {
                    tbNomorBarang.Text = dt.Rows[0]["barangID"].ToString();
                    tbNamaBarang.Text = dt.Rows[0]["namaBarang"].ToString();
                    nudPrice.Value = Int32.Parse(dt.Rows[0]["sellPrice"].ToString());
                    tbKode.Text = Util.Barcode.Barcode.buatKodeHuruf(dt.Rows[0]["buyPrice"].ToString());
                    tbBarcodeAsli.Text = dt.Rows[0]["barangBarcode"].ToString();
                    nudQty.Value = 1;
                    nudQty.Focus();
                    nudQty.Select(0, 9);
                }
            }
            else
            {
                tbNomorBarang.Text = "";
                tbNomorBarang.Focus();
            }
        }

        private void nudQty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tbKode.Focus();
                tbKode.Select(0, 9);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            tbNomorBarang.Text = "";
            tbSearch.Text = "";
            tbNamaBarang.Text = "";
            nudPrice.Value = 0;
            tbBarcodeAsli.Text = "";
            nudQty.Value = 1;
            tbNomorBarang.Focus();
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            if (tbSearch.Text != "")
            {
                DataTable dt = new DataTable();
                if (Char.IsLetter(tbSearch.Text[0]))
                    dt = ExecuteQuery("SELECT * FROM MsBarang WHERE namaBarang LIKE '%" + tbSearch.Text + "%'");
                else if (Char.IsDigit(tbSearch.Text[0]))
                {
                    if (tbSearch.Text.Length <= 6)
                        dt = ExecuteQuery("SELECT * FROM MsBarang WHERE barangID LIKE '%" + tbSearch.Text + "%'");
                    else
                        dt = ExecuteQuery("SELECT * FROM MsBarang WHERE barangBarcode LIKE '%" + tbSearch.Text + "%'");
                }
                if (dt.Rows.Count != 0)
                {
                    gridSearch.Rows.Clear();

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        gridSearch.Rows.Add(dt.Rows[i]["barangID"].ToString(), dt.Rows[i]["namaBarang"].ToString());
                    }
                }
            }
            else
            {
                gridSearch.Rows.Clear();
            }
        }

        internal void CalculateTotal()
        {
            int total = 0;
            for (int i = 0; i < listBeli.Count; i++)
            {
                total += listBeli[i].GetTotal();
            }
            tbTotal.Text = total.ToString("#,##0");
        }

        private void nudPrice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnOK.Focus();
            }
        }

        private void gridSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (gridSearch.Rows.Count > 0)
                {
                    tbNomorBarang.Text = gridSearch.Rows[gridSearch.CurrentRow.Index].Cells[0].Value.ToString();
                    tbNomorBarang.Focus();
                    tbNomorBarang.Select(0, 9);
                    nmrBarangDiEnter();
                    nudQty.Focus();
                    nudQty.Select(0, 9);
                }
            }
        }

        private void tbNomorBarang_TextChanged(object sender, EventArgs e)
        {

        }

        private void gridSearch_DoubleClick(object sender, EventArgs e)
        {
            if (gridSearch.Rows.Count > 0)
            {
                tbNomorBarang.Text = gridSearch.Rows[gridSearch.CurrentRow.Index].Cells[0].Value.ToString();
                tbNomorBarang.Focus();
                tbNomorBarang.Select(0, 9);
                nmrBarangDiEnter();
                nudQty.Focus();
                nudQty.Select(0, 9);
            }
        }

        private void tbSearch_Enter(object sender, EventArgs e)
        {
            if (tbSearch.Text == "Cari Disini!")
            {
                tbSearch.Text = "";
            }
        }

        private void tbKode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnOK_Click(sender, e);
            }
        }
    }
}
