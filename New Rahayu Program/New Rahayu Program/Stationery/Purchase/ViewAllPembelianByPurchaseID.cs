using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Rahayu_Program.Stationery.Purchase
{
    public partial class ViewAllPembelianByPurchaseID : Form
    {
        MainForm main;

        public ViewAllPembelianByPurchaseID(MainForm main)
        {
            this.main = main;
            this.MdiParent = main;
            InitializeComponent();
        }

        public DataTable ExecuteQuery(string query)
        {
            return main.ExecuteQuery(query);
        }

        private void ViewAllPembelianByPurchaseID_Load(object sender, EventArgs e)
        {
            gridPurchaseHeader.Columns.Add("id", "ID");
            gridPurchaseHeader.Columns["id"].Width = 60;
            gridPurchaseHeader.Columns.Add("status", "Status");
            gridPurchaseHeader.Columns["status"].Width = 130;

            gridPurchaseDetail.Columns.Add("barangid", "No.");
            gridPurchaseDetail.Columns["barangid"].Width = 90;
            gridPurchaseDetail.Columns.Add("namabarang", "Nama");
            gridPurchaseDetail.Columns["namabarang"].Width = 250;
            gridPurchaseDetail.Columns.Add("qty", "Qty");
            gridPurchaseDetail.Columns["qty"].Width = 70;
            gridPurchaseDetail.Columns.Add("kode", "Kd");
            gridPurchaseDetail.Columns["kode"].Width = 70;

            fillHeader();
        }

        private void fillHeader()
        {
            DataTable dt = ExecuteQuery("SELECT stationeryPurchaseID, status FROM StationeryPurchaseHeader");
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        int id = Int32.Parse(dt.Rows[i]["stationeryPurchaseID"].ToString());
                        string status = dt.Rows[i]["status"].ToString();

                        gridPurchaseHeader.Rows.Add(String.Format("{0:D4}", id), status);
                    }
                }
            }
        }

        private void gridPurchaseHeader_SelectionChanged(object sender, EventArgs e)
        {
            if (gridPurchaseHeader.Rows.Count > 0)
            {
                int index = gridPurchaseHeader.CurrentRow.Index;
                if (index >= 0 && index < gridPurchaseHeader.Rows.Count)
                {
                    int id = Int32.Parse(gridPurchaseHeader.Rows[index].Cells[0].Value.ToString());
                    fillDetail(id);
                }
            }
        }

        private void fillDetail(int id)
        {
            DataTable dt = ExecuteQuery("SELECT mb.barangID, namaBarang, qty, spd.buyPrice FROM StationeryPurchaseDetail spd JOIN MsBarang mb ON spd.barangID = mb.barangID WHERE stationeryPurchaseID = '" + id + "'");
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        int qty = Int32.Parse(dt.Rows[i]["qty"].ToString());
                        int buyPrice = Int32.Parse(dt.Rows[i]["buyPrice"].ToString());
                        string barangName = dt.Rows[i]["namaBarang"].ToString();
                        string barangID = dt.Rows[i]["barangID"].ToString();

                        gridPurchaseDetail.Rows.Add(barangID, barangName, qty, buyPrice);
                    }
                }
            }
        }
    }
}
