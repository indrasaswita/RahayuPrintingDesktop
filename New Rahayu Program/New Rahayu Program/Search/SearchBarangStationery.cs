using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Rahayu_Program.Search
{
    public partial class SearchBarangStationery : Form
    {
        MainForm main;

        public SearchBarangStationery(MainForm main)
        {
            this.main = main;

            InitializeComponent();
        }

        public DataTable ExecuteQuery(string query)
        {
            return main.ExecuteQuery(query);
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
                    gridBarangStationery.Rows.Clear();

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        gridBarangStationery.Rows.Add(dt.Rows[i]["barangID"].ToString(), dt.Rows[i]["namaBarang"].ToString(), Int32.Parse(dt.Rows[i]["sellPrice"].ToString()).ToString("#,##0"));
                    }
                }
            }
            else
            {
                gridBarangStationery.Rows.Clear();
            }
        }

        private void SearchBarangStationery_Load(object sender, EventArgs e)
        {
            gridBarangStationery.Columns.Add("", "Kode");
            gridBarangStationery.Columns[0].Width = 80;
            gridBarangStationery.Columns.Add("", "Nama Barang");
            gridBarangStationery.Columns[1].Width = 250;
            gridBarangStationery.Columns.Add("", "Harga");
            gridBarangStationery.Columns[2].Width = 170;
        }

        private void tbSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                DialogResult = System.Windows.Forms.DialogResult.Cancel;
            }
            else
            {
                if (gridBarangStationery.Rows.Count > 0)
                {
                    if (e.KeyCode == Keys.Down && gridBarangStationery.CurrentRow.Index < gridBarangStationery.Rows.Count - 1)
                    {
                        gridBarangStationery.CurrentCell = gridBarangStationery.Rows[gridBarangStationery.CurrentRow.Index + 1].Cells[0];
                    }
                    else if (e.KeyCode == Keys.Up && gridBarangStationery.CurrentRow.Index >= 1)
                    {
                        gridBarangStationery.CurrentCell = gridBarangStationery.Rows[gridBarangStationery.CurrentRow.Index - 1].Cells[0];
                    }
                    else if (e.KeyCode == Keys.Enter)
                    {
                        selectBarang();
                    }
                }
            }
        }

        private void selectBarang()
        {
            main.globalBarangID = gridBarangStationery.Rows[gridBarangStationery.CurrentRow.Index].Cells[0].Value.ToString();

            tbSearch.Text = "";
            gridBarangStationery.Rows.Clear();

            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void gridBarangStationery_DoubleClick(object sender, EventArgs e)
        {
            selectBarang();
        }

        private void gridBarangStationery_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                DialogResult = System.Windows.Forms.DialogResult.Cancel;
            }
            else if (e.KeyCode == Keys.Enter)
            {
                selectBarang();
            }
        }
    }
}
