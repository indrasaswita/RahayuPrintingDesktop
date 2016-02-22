using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Rahayu_Program.PVC.Sales
{
    public partial class SalesPVCList : UserControl
    {
        private int pvcID, price, pvcTypeID;
        private decimal pvcPerPack, qty;
        private CreateSalesPVC parent;
        private string pvcName;

        public SalesPVCList(CreateSalesPVC parent, int pvcID, int pvcTypeID, string pvcName, decimal qty, decimal pvcPerPack, int price)
        {
            this.parent = parent;
            this.pvcID = pvcID;
            this.pvcTypeID = pvcTypeID;
            this.qty = qty;
            this.price = price;
            this.pvcName = pvcName;
            this.pvcPerPack = pvcPerPack;

            InitializeComponent();
        }

        public DataTable ExecuteQuery(string query)
        {
            return parent.ExecuteQuery(query);
        }

        private void SalesPVCList_Load(object sender, EventArgs e)
        {
            tbNamaPVC.Text = pvcName;
            nudPrice.Value = price;
            nudQty.Value = qty;
            nudQty.Increment = pvcPerPack;
        }

        private void nudQty_ValueChanged(object sender, EventArgs e)
        {
            nudTotal.Value = nudQty.Value * nudPrice.Value;
            qty = nudTotal.Value;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            parent.RemoveCart(this);
        }

        public int GetPVCTypeID()
        {
            return pvcTypeID;
        }

        public int GetPVCID()
        {
            return pvcID;
        }

        public int GetPrice()
        {
            return Convert.ToInt32(nudPrice.Value);
        }

        public decimal GetQty()
        {
            return nudQty.Value;
        }

        public int getTotal()
        {
            return Convert.ToInt32(nudPrice.Value * nudQty.Value);
        }

        public string getPVCName()
        {
            return pvcName;
        }

        private void tbNamaPVC_Enter(object sender, EventArgs e)
        {
            nudQty.Focus();
            nudQty.Select(0, 9);
        }

        private void nudTotal_ValueChanged(object sender, EventArgs e)
        {
            parent.RefreshTotalBeli();
        }
    }
}
