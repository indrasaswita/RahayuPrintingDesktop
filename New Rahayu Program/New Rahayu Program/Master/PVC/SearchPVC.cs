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
    public partial class SearchPVC : Form
    {
        MainForm main;
        int pvcID;

        public SearchPVC(MainForm main)
        {
            this.main = main;

            InitializeComponent();
        }

        public DataTable ExecuteQuery(string query)
        {
            return main.ExecuteQuery(query);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (tbPVCID.Text != "")
            {
                main.globalPVCID = Int32.Parse(tbPVCID.Text);
                DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            else
            {
                main.SetMessage("Tolong Pilih PVC-nya!");
            }
        }

        private void btnAddPVC_Click(object sender, EventArgs e)
        {
            Master.PVC.AddNewPVC addNewPVC = new Master.PVC.AddNewPVC(main, Int32.Parse(tbPVCTypeID.Text), tbPVCTypeName.Text);
            DialogResult result = addNewPVC.ShowDialog();
            addNewPVC.BringToFront();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                RefreshPVC();
            }
        }

        private void SearchPVC_Load(object sender, EventArgs e)
        {
            RefreshPVC();
        }

        private void RefreshPVC()
        {
            DataTable dt = ExecuteQuery("SELECT * FROM MsPVCType");
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    treePVC.Nodes.Clear();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        int pvcTypeID = Int32.Parse(dt.Rows[i]["pvcTypeID"].ToString());
                        treePVC.Nodes.Add(pvcTypeID + "", dt.Rows[i]["pvcTypeName"].ToString());
                        DataTable dt2 = ExecuteQuery("SELECT PVCID, pvcTypeID, pvcName, pvcPerPack, pvcTypeUnit, rahayuStock FROM MsPVC WHERE pvcTypeID = " + pvcTypeID + "");
                        if (dt2 != null)
                        {
                            for (int j = 0; j < dt2.Rows.Count; j++)
                            {
                                int pvcID = Int32.Parse(dt2.Rows[j]["pvcID"].ToString());
                                treePVC.Nodes[treePVC.Nodes.Count - 1].Nodes.Add(pvcID + "", dt2.Rows[j]["pvcName"].ToString());
                                if (Decimal.Parse(dt2.Rows[j]["rahayuStock"].ToString()) <= 0 && dt2.Rows[j]["pvcTypeID"].ToString() != "8" && dt2.Rows[j]["pvcTypeID"].ToString() != "9")
                                {
                                    treePVC.Nodes[treePVC.Nodes.Count - 1].Nodes[j].BackColor = Color.Red;
                                    treePVC.Nodes[treePVC.Nodes.Count - 1].Nodes[j].ForeColor = Color.White;
                                }
                            }
                        }
                    }
                }
                treePVC.ExpandAll();
                treePVC.SelectedNode = treePVC.Nodes[0];
            }
        }

        private void treePVC_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treePVC.SelectedNode.Level == 0)
            {
                tbPVCTypeID.Text = treePVC.SelectedNode.Name;
                tbPVCTypeName.Text = treePVC.SelectedNode.Text;
                tbPVCName.Text = "";
                tbPVCID.Text = "";
                tbPVCTypeUnit.Text = "";
                tbPVCPerPack.Text = "";
            } 
            else if (treePVC.SelectedNode.Level == 1)
            {
                tbPVCTypeID.Text = treePVC.SelectedNode.Parent.Name;
                tbPVCTypeName.Text = treePVC.SelectedNode.Parent.Text;
                tbPVCName.Text = treePVC.SelectedNode.Text;
                tbPVCID.Text = treePVC.SelectedNode.Name;

                pvcID = Int32.Parse(tbPVCID.Text);
                DataTable dt = ExecuteQuery("SELECT pvcPerPack, pvcTypeUnit, sellPrice FROM MsPVC WHERE pvcID = " + pvcID + "");
                tbPVCTypeUnit.Text = dt.Rows[0]["pvcTypeUnit"].ToString();
                tbPVCPerPack.Text = dt.Rows[0]["pvcPerPack"].ToString();
                nudSellPrice.Value = Int32.Parse(dt.Rows[0]["sellPrice"].ToString());
            }
        }

        private void treePVC_DoubleClick(object sender, EventArgs e)
        {
            btnOK_Click(sender, e);
        }

        private void treePVC_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                btnCancel_Click(sender, e);
            }
        }
    }
}
