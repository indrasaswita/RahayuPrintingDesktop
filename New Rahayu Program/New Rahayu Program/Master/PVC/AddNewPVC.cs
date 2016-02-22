using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Rahayu_Program.Master.PVC
{
    public partial class AddNewPVC : Form
    {
        int pvcTypeID;
        string pvcTypeName;
        MainForm main;

        public AddNewPVC(MainForm main, int pvcTypeID, string pvcTypeName)
        {
            this.main = main;
            this.pvcTypeID = pvcTypeID;
            this.pvcTypeName = pvcTypeName;
            this.MdiParent = main;

            gridView.Columns.Add("", "PVC NAME");
            gridView.Columns[0].Width = 497;
            gridView.Columns.Add("", "");
            gridView.Columns[1].Visible = false;
            gridView.Columns.Add("", "");
            gridView.Columns[2].Visible = false;
            gridView.Columns.Add("", "");
            gridView.Columns[3].Visible = false;

            InitializeComponent();
        }

        public DataTable ExecuteQuery(string query)
        {
            return ExecuteQuery(query);
        }

        private void AddNewPVC_Load(object sender, EventArgs e)
        {
            tbPVCTypeName.Text = pvcTypeName;
            cbTypeUnit.SelectedIndex = 0;
        }

        private void showLike(string pvcName)
        {
            DataTable dt = ExecuteQuery("SELECT pvcName, pvcPerPack, pvcTypeUnit, sellPrice FROM MsPVC WHERE pvcName LIKE '%" + pvcName + "%' AND pvcTypeID = " + pvcTypeID + "");
            gridView.Rows.Clear();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                gridView.Rows.Add(dt.Rows[i]["pvcName"].ToString(), dt.Rows[i]["pvcPerPack"].ToString(), dt.Rows[i]["pvcTypeUnit"].ToString(), dt.Rows[i]["sellPrice"].ToString());
            }
        }

        private void tbPVCName_TextChanged(object sender, EventArgs e)
        {
            showLike(tbPVCName.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (gridView.Rows.Count == 0)
                if (nudPerPack.Value != 0)
                    if (nudSellPrice.Value != 0)
                    {
                        ExecuteQuery("INSERT INTO MsPVC (pvcTypeID, pvcName, pvcPerPack, pvcTypeUnit, sellPrice, homeStock, rahayuStock) VALUES (" + pvcTypeID + ", '" + tbPVCName.Text + "', '" + nudPerPack.Value + "', '" + cbTypeUnit.Text + "', '" + nudSellPrice.Value + "', 0, 0)");
                        DialogResult = System.Windows.Forms.DialogResult.OK;
                    }
                    else main.SetMessage("PVC Sell Price tidak boleh nol bro");
                else main.SetMessage("PVC Per Pak tidak boleh nol");
            else main.SetMessage("Buat Nama Yang UNIK");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
    }
}
