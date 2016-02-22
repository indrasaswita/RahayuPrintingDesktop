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
    public partial class UpdatePricePVC : Form
    {
        MainForm main;
        int pvcID;

        public UpdatePricePVC(MainForm main)
        {
            this.main = main;
            InitializeComponent();
        }

        public DataTable ExecuteQuery(string query)
        {
            return main.ExecuteQuery(query);
        }

        private void btnSearchPVC_Click(object sender, EventArgs e)
        {
            SearchPVC searchPVC = new SearchPVC(main);
            DialogResult result  = searchPVC.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                pvcID = main.globalPVCID;

                DataTable dt = ExecuteQuery("SELECT * FROM MsPVC WHERE pvcID = '" + pvcID + "'");
                tbNamaPVC.Text = dt.Rows[0]["pvcName"].ToString();
                nudPrice.Value = Decimal.Parse(dt.Rows[0]["sellPrice"].ToString());
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (pvcID != 0)
            {
                ExecuteQuery("UPDATE MsPVC SET sellPrice = '" + nudNewPrice.Value + "' WHERE pvcID = '" + pvcID + "'");
                main.SetMessage("Harga PVC telah diupdate");
            }
            else
            {
                main.SetMessage("Belom pilih PVC, Pilih dulu baru ganti!");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
