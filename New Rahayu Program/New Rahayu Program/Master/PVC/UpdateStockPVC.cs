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
    public partial class UpdateStockPVC : Form
    {
        MainForm main;
        int pvcID;

        public UpdateStockPVC(MainForm main)
        {
            this.main = main;
            this.MdiParent = main;

            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (pvcID != 0)
            {
                if (area != "")
                {
                    //UPDATE STOCK
                    ExecuteQuery("UPDATE MsPVC SET " + area + "Stock = '" + nudQty.Value + "' WHERE pvcID = '" + pvcID + "'");
                    pvcID = 0;
                    tbNamaPVC.Text = "";
                    nudPack.Value = 0;
                    nudPerPack.Value = 0;
                    nudQty.Value = 0;
                    LblPVCType.Text = "";

                    btnSearchPVC.Focus();
                    main.SetMessage("Selesai update stocknya");
                }
                else
                {
                    main.SetMessage("Pilih dulu areanya, Rahayu / Rumah!");
                }
            }
            else
            {
                main.SetMessage("Pilih dulu pvcnya!");
            }
        }

        private void btnEnterQty_Click(object sender, EventArgs e)
        {
            nudQty.Value = nudTotalQty.Value;
        }

        private void nudPack_ValueChanged(object sender, EventArgs e)
        {
            nudTotalQty.Value = nudPack.Value * nudPerPack.Value;
        }

        private void nudPerPack_ValueChanged(object sender, EventArgs e)
        {
            nudTotalQty.Value = nudPack.Value * nudPerPack.Value;
        }

        private void nudPack_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnEnterQty_Click(sender, e);
            }
        }

        public DataTable ExecuteQuery(string query)
        {
            return main.ExecuteQuery(query);
        }

        private void btnSearchPVC_Click(object sender, EventArgs e)
        {
            Master.PVC.SearchPVC searchPVC = new Master.PVC.SearchPVC(main);
            DialogResult result = searchPVC.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                pvcID = main.globalPVCID;

                DataTable dt = ExecuteQuery("SELECT * FROM MsPVC WHERE pvcID = '" + pvcID + "'");
                tbNamaPVC.Text = dt.Rows[0]["pvcName"].ToString();
                nudPack.Value = 0;
                nudQty.Value = 0;
                nudPerPack.Value = Decimal.Parse(dt.Rows[0]["pvcPerPack"].ToString());
                LblPVCType.Text = dt.Rows[0]["pvcTypeUnit"].ToString();
            }
        }

        private void UpdateStockPVC_Load(object sender, EventArgs e)
        {
            pvcID = 0;
            LblPVCType.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private string area = "";

        private void btnHome_Click(object sender, EventArgs e)
        {
            area = "home";
            btnRahayu.BackColor = Color.DeepPink;
            btnRahayu.ForeColor = Color.White;
            btnHome.BackColor = Color.LawnGreen;
            btnHome.ForeColor = Color.Black;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            area = "rahayu";
            btnRahayu.BackColor = Color.LawnGreen;
            btnRahayu.ForeColor = Color.Black;
            btnHome.BackColor = Color.DeepPink;
            btnHome.ForeColor = Color.White;
        }
    }
}
