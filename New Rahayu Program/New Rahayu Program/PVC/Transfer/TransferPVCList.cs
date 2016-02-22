using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Rahayu_Program.PVC.Transfer
{
    public partial class TransferPVCList : UserControl
    {
        public int pack, pvcID;
        public Decimal perPack;
        public PVCNewTransfer parent;
        public string pvcName;

        public TransferPVCList(PVCNewTransfer parent, int pvcID, string pvcName, int pack, Decimal perPack)
        {
            this.pvcID = pvcID;
            this.pvcName = pvcName;
            this.parent = parent;
            this.perPack = perPack;
            this.pack = pack;
            this.pvcName = pvcName;

            InitializeComponent();
        }

        public int GetPVCID()
        {
            return pvcID;
        }

        public int GetPack()
        {
            return Convert.ToInt32(nudPack.Value);
        }

        public Decimal GetPerPack()
        {
            return nudPerPack.Value;
        }

        public Decimal GetTotal()
        {
            return nudPack.Value * nudPerPack.Value;
        }

        private void TransferPVCList_Load(object sender, EventArgs e)
        {
            nudPerPack.Value = perPack;
            nudPack.Value = pack;
            nudQty.Value = pack * perPack;
            tbNamaPVC.Text = pvcName;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            parent.DeleteTransferList(this);
        }

        private void nudPack_ValueChanged(object sender, EventArgs e)
        {
            nudQty.Value = nudPack.Value * nudPerPack.Value;
        }
    }
}
