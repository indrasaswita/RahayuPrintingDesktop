using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Rahayu_Program.PVC.Report
{
    public partial class OpnameList : UserControl
    {
        PVCOpnameReport parent;
        private int pvcID;
        private string pvcName;
        private string pvcTypeUnit;
        private decimal pvcPerPack;
        private int index;
        private int input;

        public OpnameList(PVCOpnameReport parent, int pvcID, string pvcName, int input, decimal pvcPerPack, string pvcTypeUnit)
        {
            this.pvcID = pvcID;
            this.parent = parent;
            this.pvcName = pvcName;
            this.input = input;
            this.pvcPerPack = pvcPerPack;
            this.pvcTypeUnit = pvcTypeUnit;

            InitializeComponent();
        }

        private void OpnameList_Load(object sender, EventArgs e)
        {
            nudPerPack.Value = pvcPerPack;
            tbTypeUnit1.Text = pvcTypeUnit;
            tbTypeUnit2.Text = pvcTypeUnit;
            tbPVCName.Text = pvcName;
            nudQty.Value = input;
        }

        public string GetPVCName()
        {
            return pvcName;
        }

        public int GetPVCID()
        {
            return pvcID;
        }

        public int getQty()
        {
            return Convert.ToInt32(nudQty.Value);
        }

        public int getTotal()
        {
            return Convert.ToInt32(nudTotal.Value);
        }

        private void nudQty_Enter(object sender, EventArgs e)
        {
            nudQty.Select(0, 9);
        }

        public void SetIndex(int index)
        {
            this.index = index;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            parent.SetNext(index);
        }

        public void setFocus()
        {
            nudQty.Focus();
            nudQty.Select(0,9);
        }

        private void nudQty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnNext_Click(sender, e);
            }
        }

        private void nudQty_ValueChanged(object sender, EventArgs e)
        {
            nudTotal.Value = nudQty.Value * nudPerPack.Value;
        }

        private void nudPerPack_ValueChanged(object sender, EventArgs e)
        {
            nudTotal.Value = nudQty.Value * nudPerPack.Value;
        }
    }
}
