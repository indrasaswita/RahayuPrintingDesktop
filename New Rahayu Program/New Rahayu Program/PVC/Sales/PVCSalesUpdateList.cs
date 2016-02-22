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
    public partial class PVCSalesUpdateList : UserControl
    {
        public PVCSalesUpdateDetail parent;
        public int pvcID, sellPrice, total;
        public string pvcName, typeUnit;
        public Decimal qty, pvcPerPack;

        public PVCSalesUpdateList(PVCSalesUpdateDetail parent, int pvcID, string pvcName, Decimal qty, int sellPrice, string typeUnit, Decimal pvcPerPack)
        {
            this.parent = parent;
            this.pvcID = pvcID;
            this.pvcName = pvcName;
            this.qty = qty;
            this.sellPrice = sellPrice;
            this.typeUnit = typeUnit;
            this.total = 0;
            this.pvcPerPack = pvcPerPack;

            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            parent.LoadFromCart(pvcID, pvcName, nudQty.Value, Convert.ToInt32(nudPrice.Value), typeUnit, pvcPerPack);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            parent.DeleteCartList(this);
        }

        private void PVCSalesUpdateList_Load(object sender, EventArgs e)
        {
            tbNamaPVC.Text = pvcName;
            nudPrice.Value = sellPrice;
            nudQty.Value = qty;
            nudQty.Increment = pvcPerPack;
        }

        private void nudQty_ValueChanged(object sender, EventArgs e)
        {
            nudTotal.Value = nudPrice.Value * nudQty.Value;
            qty = nudQty.Value;
        }

        public int getPVCID()
        {
            return pvcID;
        }

        public string getPVCName()
        {
            return pvcName;
        }

        public Decimal getQty()
        {
            return qty;
        }

        public int getPrice()
        {
            return sellPrice;
        }

        private void nudTotal_ValueChanged(object sender, EventArgs e)
        {
            parent.RefreshTotalBeli();
        }

        private void nudPrice_ValueChanged(object sender, EventArgs e)
        {
            sellPrice = Convert.ToInt32(nudPrice.Value);
        }
    }
}
