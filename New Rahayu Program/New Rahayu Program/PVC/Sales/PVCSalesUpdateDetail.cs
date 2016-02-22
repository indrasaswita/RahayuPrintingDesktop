using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Rahayu_Program.PVC.Sales
{
    public partial class PVCSalesUpdateDetail : Form
    {
        public int pvcID;

        List<PVCSalesUpdateList> list;
        MainForm main;
        int pvcSalesID;

        public PVCSalesUpdateDetail(MainForm main, int pvcSalesID)
        {
            this.main = main;
            this.pvcSalesID = pvcSalesID;

            InitializeComponent();

            list = new List<PVCSalesUpdateList>();
        }

        public void LoadFromCart(int pvcID, string pvcName, decimal qty, int sellPrice, string typeUnit, decimal pvcPerPack)
        {
            nudQty.Value = 0;
            nudPrice.Value = 0;

            LblPVCType.Text = typeUnit;
            tbNamaPVC.Text = pvcName;
            nudPrice.Value = sellPrice;
            nudQty.Value = qty;
            nudTotal.Value = nudQty.Value * nudPrice.Value;
            nudPack.Value = nudQty.Value / pvcPerPack;
            nudPerPack.Value = pvcPerPack;

            this.pvcID = pvcID;

            nudPack.Focus();
            nudPack.Select(0, 9);
        }

        public void RefreshTotalBeli()
        {
            int total = 0;
            for (int i = 0; i < list.Count; i++)
            {
                total += Convert.ToInt32(list[i].getPrice() * list[i].getQty());
            }
            nudTotalBeli.Value = total;
        }

        public DataTable ExecuteQuery(string query)
        {
            return main.ExecuteQuery(query);
        }

        internal void DeleteCartList(PVCSalesUpdateList input)
        {
            list.Remove(input);
            RefreshCart();
        }

        private void PVCSalesUpdateDetail_Load(object sender, EventArgs e)
        {
            InitCart();
            RefreshCart();

            tbSalesID.Text = "Sales ID : " + String.Format("{0:D7}", pvcSalesID);
            btnSearchPVC.Focus();
        }

        private void InitCart()
        {
            DataTable dt = ExecuteQuery("SELECT psd.pvcID, pvcName, pvcPerPack, pvcTypeUnit, quantity, psd.sellPrice FROM MsPVC mp, PVCSalesDetail psd WHERE psd.pvcID = mp.pvcID AND pvcSalesID = " + pvcSalesID + " ORDER BY mp.pvcTypeID");


            if (dt != null)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    int pvcID = Int32.Parse(dt.Rows[i]["pvcID"].ToString());
                    string pvcName = dt.Rows[i]["pvcName"].ToString();
                    decimal pvcPerPack = Decimal.Parse(dt.Rows[i]["pvcPerPack"].ToString());
                    string pvcTypeUnit = dt.Rows[i]["pvcTypeUnit"].ToString();
                    decimal quantity = Decimal.Parse(dt.Rows[i]["quantity"].ToString());
                    int sellPrice = Int32.Parse(dt.Rows[i]["sellPrice"].ToString());

                    PVCSalesUpdateList temp = new PVCSalesUpdateList(this, pvcID, pvcName, quantity, sellPrice, pvcTypeUnit, pvcPerPack);

                    list.Add(temp);
                }
            }
        }

        public void RefreshCart()
        {
            panelCart.Controls.Clear();
            int total = 0;
            if (list != null)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    list[i].Location = new Point(1, 1 + (i * (list[i].Height + 1)));
                    total += Convert.ToInt32(list[i].getQty() * list[i].getPrice());
                    panelCart.Controls.Add(list[i]);
                }
            }
            else
            {
            }
            nudTotalBeli.Value = total;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Dispose();
        }

        private void nudPack_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
                if (nudPack.Value != 0)
                {
                    btnEnterQty.Focus();
                }
                else
                {
                    nudPack.Focus();
                    nudPack.Select(0, 9);
                }
        }

        private void btnEnterQty_Click(object sender, EventArgs e)
        {
            if (nudTotalQty.Value != 0)
                nudQty.Value = nudTotalQty.Value;
            else
            {
                main.SetMessage("Jumlah TIDAK boleh kosong");
                nudPack.Focus();
                nudPack.Select(0, 9);
            }
            nudPrice.Focus();
            nudPrice.Select(0, 9);
        }

        private void nudPack_ValueChanged(object sender, EventArgs e)
        {
            nudTotalQty.Value = nudPack.Value * nudPerPack.Value;
        }

        private void nudPrice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (nudQty.Value != 0)
                {
                    nudTotal.Value = nudQty.Value * nudPrice.Value;
                    btnAddToCart.Focus();
                }
                else
                {
                    main.SetMessage("Jumlah TIDAK boleh kosong");
                    nudPack.Focus();
                    nudPack.Select(0, 9);
                }
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            DataTable dt = ExecuteQuery("SELECT * FROM PVCSalesDetail WHERE pvcSalesID = " + pvcSalesID + "");
            if (dt != null)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ExecuteQuery("UPDATE MsPVC SET rahayuStock = rahayuStock + '" + dt.Rows[i]["quantity"].ToString() + "' WHERE pvcID = " + dt.Rows[i]["pvcID"].ToString() + "");
                }
                ExecuteQuery("DELETE FROM PVCSalesDetail WHERE pvcSalesID = " + pvcSalesID + "");
                for (int i = 0; i < list.Count; i++)
                {
                    ExecuteQuery("INSERT INTO PVCSalesDetail VALUES(" + pvcSalesID + ", " + list[i].getPVCID() + ", '" + list[i].getQty() + "', " + list[i].getPrice() + ", 0, 0, 0)");
                    ExecuteQuery("UPDATE MsPVC SET rahayuStock = rahayuStock - '" + list[i].getQty() + "' WHERE pvcID = " + list[i].getPVCID() + "");
                }
            }
            main.globalPVCSalesID = pvcSalesID;
            DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Dispose();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            nudPack.Focus();
            nudPack.Select(0, 9);
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if (nudQty.Value != 0)
            {

                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].getPVCID() == pvcID)
                    {
                        list.RemoveAt(i);
                    }
                }

                PVCSalesUpdateList temp = new PVCSalesUpdateList(this, pvcID, tbNamaPVC.Text, nudQty.Value, Convert.ToInt32(nudPrice.Value), LblPVCType.Text, nudPerPack.Value);
                list.Add(temp);

                RefreshCart();
            }
            else
            {
                main.SetMessage("Pilih PVC dan isi QTY dulu!");
                nudPack.Focus();
                nudPack.Select(0, 9);
            }
        }

        private void btnSearchPVC_Click(object sender, EventArgs e)
        {
            Master.PVC.SearchPVC searchPVC = new Master.PVC.SearchPVC(main);
            DialogResult result = searchPVC.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                pvcID = main.globalPVCID;

                DataTable dt = ExecuteQuery("SELECT pvcName, pvcPerPack, pvcTypeUnit, sellPrice FROM MsPVC WHERE pvcID = " + pvcID + "");
                if (dt != null)
                {
                    if (dt.Rows.Count == 1)
                    {
                        tbNamaPVC.Text = dt.Rows[0]["pvcName"].ToString();
                        nudPerPack.Value = Decimal.Parse(dt.Rows[0]["pvcPerPack"].ToString());
                        LblPVCType.Text = dt.Rows[0]["pvcTypeUnit"].ToString();
                        nudPrice.Value = Int32.Parse(dt.Rows[0]["sellPrice"].ToString());
                        nudPack.Value = 0;
                        nudQty.Value = 0;
                        nudTotal.Value = 0;
                        nudTotalQty.Value = 0;

                        nudPack.Focus();
                        nudPack.Select(0, 9);
                    }
                }
            }
        }

        private void nudQty_ValueChanged(object sender, EventArgs e)
        {
            if (nudQty.Value * nudPrice.Value < 99999999999)
                nudTotal.Value = nudQty.Value * nudPrice.Value;
            else
                main.SetMessage("Total terlalu besar");
        }
    }
}
