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
    public partial class ViewSalesPVCList : UserControl
    {
        private ViewAllSales viewAllSales;
        private string pvcName;
        private decimal qty;
        private decimal perPack;
        private int sellPrice;

        public ViewSalesPVCList(ViewAllSales viewAllSales, string pvcName, decimal qty, decimal perPack, int sellPrice)
        {
            this.viewAllSales = viewAllSales;
            this.pvcName = pvcName;
            this.qty = qty;
            this.perPack = perPack;
            this.sellPrice = sellPrice;

            InitializeComponent();
        }

        private void ViewSalesPVCList_Load(object sender, EventArgs e)
        {
            tbNamaPVC.Text = pvcName;
            nudQty.Value = qty;
            nudPrice.Value = sellPrice;
            nudTotal.Value = qty * sellPrice;
            toolTip1.SetToolTip(nudQty, "" + (qty / perPack));
        }
    }
}
