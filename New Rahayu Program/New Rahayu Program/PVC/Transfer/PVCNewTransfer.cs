using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Rahayu_Program.PVC.Transfer
{
    public partial class PVCNewTransfer : Form
    {
        List<TransferPVCList> list;
        int pvcID;
        Rahayu_Program.Master.PVC.SearchPVC searchPVC;
        MainForm main;

        public PVCNewTransfer(MainForm main)
        {
            searchPVC = new Rahayu_Program.Master.PVC.SearchPVC(main);
            list = new List<TransferPVCList>();
            this.main = main;
            this.MdiParent = main;

            InitializeComponent();
        }

        private void PVCNewTransfer_Load(object sender, EventArgs e)
        {

        }

        private void DeleteAllTransferList()
        {
            list.Clear();
            RefreshTransferList();
        }

        public void DeleteTransferList(TransferPVCList item)
        {
            list.Remove(item);
            RefreshTransferList();
        }

        private void RefreshTransferList()
        {
            panelCart.Controls.Clear();
            for (int i = 0; i < list.Count; i++)
            {
                list[i].Location = new Point(1, 1 + (i * (list[i].Height + 1)));
                panelCart.Controls.Add(list[i]);
            }
        }

        private void AddTransferList(Decimal jumlahSebelom)
        {
            if (pvcID == 0)
            {
                main.SetMessage("Pilih PVC dulu!");
            }
            else
            {
                TransferPVCList temp = new TransferPVCList(this, pvcID, tbNamaPVC.Text, Convert.ToInt32(nudPack.Value + jumlahSebelom), nudPerPack.Value);
                list.Add(temp);
            }
        }

        private void btnSearchPVC_Click(object sender, EventArgs e)
        {
            DialogResult result = searchPVC.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                pvcID = main.globalPVCID;
                DataTable dt = ExecuteQuery("SELECT pvcName, pvcPerPack, pvcTypeUnit FROM MsPVC WHERE pvcID = " + pvcID + "");
                tbNamaPVC.Text = dt.Rows[0]["pvcName"].ToString();
                nudPerPack.Value = Decimal.Parse(dt.Rows[0]["pvcPerPack"].ToString());
                tbTypeUnit.Text = dt.Rows[0]["pvcTypeUnit"].ToString();

                nudPack.Focus();
                nudPack.Select(0, 9);
            }
        }

        private DataTable ExecuteQuery(string query)
        {
            return main.ExecuteQuery(query);
        }

        private void tbTypeUnit_Enter(object sender, EventArgs e)
        {
            nudTotalQty.Focus();
        }

        private void nudPack_ValueChanged(object sender, EventArgs e)
        {
            nudTotalQty.Value = nudPack.Value * nudPerPack.Value;
        }

        private void nudPack_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAddToCart.Focus();
            }
        }

        private void btnClearField_Click(object sender, EventArgs e)
        {
            pvcID = 0;
            tbNamaPVC.Text = "";
            nudPerPack.Value = 0;
            nudPack.Value = 0;

            btnSearchPVC.Focus();
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            Decimal jumlahSebelom = 0;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].GetPVCID() == pvcID)
                {
                    jumlahSebelom = list[i].GetPack();
                    list.RemoveAt(i);
                    break;
                }
            }

            if (nudPack.Value == 0)
            {
                main.SetMessage("Input Qty, gak boleh 0 bro!");
                nudPack.Focus();
                nudPack.Select(0, 9);
            }
            else
            {
                AddTransferList(jumlahSebelom);
                RefreshTransferList();
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (tbPengirim.Text != "" && list.Count > 0)
            {
                ExecuteQuery("INSERT INTO PVCTransferHeader (deliveryOfficer, transferTime) VALUES ('" + tbPengirim.Text + "', now())");
                DataTable dt = ExecuteQuery("SELECT pvcTransferID FROM PVCTransferHeader ORDER BY pvcTransferID DESC LIMIT 0, 1");
                int pvcTransferID = Int32.Parse(dt.Rows[0]["pvcTransferID"].ToString());
                for (int i = 0; i < list.Count; i++)
                {
                    ExecuteQuery("INSERT INTO PVCTransferDetail VALUES (" + pvcTransferID + ", " + list[i].GetPVCID() + ", '" + list[i].GetTotal() + "')");
                    ExecuteQuery("UPDATE MsPVC SET homeStock = homeStock - '" + list[i].GetTotal()  + "', rahayuStock = rahayuStock + '" + list[i].GetTotal() + "' WHERE pvcID = " + list[i].GetPVCID() + "");
                }

                main.PVCTransferPrintReceipt(pvcTransferID);
            }
            else
            {
                main.SetMessage("Isi Nama Pengirim dan Masukkan Barang yang mau dikirim");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeleteAllTransferList();
        }
    }
}
