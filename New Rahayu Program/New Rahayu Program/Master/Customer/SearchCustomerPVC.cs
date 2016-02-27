using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Rahayu_Program.DialogBox;

namespace Rahayu_Program.Master.Customer
{
    public partial class SearchCustomerPVC : Form
    {
        MainForm main;

        public SearchCustomerPVC(MainForm main)
        {
            this.main = main;

            InitializeComponent();
        }

        public DataTable ExecuteQuery(string query)
        {
            return main.ExecuteQuery(query);
        }

        private void refreshData()
        {
            treeCust.Nodes.Clear();
            try
            {
                DataTable dtParent = ExecuteQuery("SELECT * FROM MsParentCompany ORDER BY parentCompanyName");
                DataTable dtCompany, dtCustomer;
                if (dtParent.Rows.Count > 0)
                {
                    for (int i = 0; i < dtParent.Rows.Count; i++)
                    {
                        string parentID = dtParent.Rows[i]["parentCompanyID"].ToString();
                        string pAlias = dtParent.Rows[i]["parentAliases"].ToString();
                        string parentName = dtParent.Rows[i]["parentCompanyName"].ToString() + (pAlias.Trim() != "" ? "(" + pAlias + ")" : "");
                        treeCust.Nodes.Add(parentID, parentName);
                        dtCompany = ExecuteQuery("SELECT * FROM MsCompany WHERE parentCompanyID = " + parentID + " ORDER BY companyName");
                        for (int j = 0; j < dtCompany.Rows.Count; j++)
                        {
                            string companyID = dtCompany.Rows[j]["companyID"].ToString();
                            string alias = dtCompany.Rows[j]["aliases"].ToString();
                            string companyName = dtCompany.Rows[j]["companyName"].ToString() + (alias == "" ? "" : " (" + alias + ")");
                            treeCust.Nodes[i].Nodes.Add(companyID, companyName);
                            dtCustomer = ExecuteQuery("SELECT * FROM MsCustomer WHERE companyID = " + companyID + " ORDER BY customerName");
                            for (int k = 0; k < dtCustomer.Rows.Count; k++)
                            {
                                string customerID = dtCustomer.Rows[k]["customerID"].ToString();
                                treeCust.Nodes[i].Nodes[j].Nodes.Add(customerID, dtCustomer.Rows[k]["customerName"].ToString());
                            }
                            dtCustomer = null;
                        }
                        dtCompany = null;
                    }
                    dtParent = null;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            treeCust.ExpandAll();
        }

        private string customerEmail = "";

        private void refreshData(string search)
        {

            //CARI WHERE LIKEnya DI PAKE DI CODE C#, pake indexOF
            // kalo indexOF tidak -1, brarti di munculin, dan di continue
            // kalo indexOF hasilnya -1, brarti di search lagi di dalamnya
            // kalo ketemu, yang di munculin, anaknya + bapaknya juga

            search = search.ToLower();
            
            DataTable dtParent = ExecuteQuery("SELECT * FROM MsParentCompany ORDER BY parentCompanyName");
            DataTable dtCompany, dtCustomer;
            if(dtParent.Rows.Count > 0)
            {
                treeCust.Nodes.Clear();
                for (int i = 0; i < dtParent.Rows.Count; i++)
                {
                    string parentID = dtParent.Rows[i]["parentCompanyID"].ToString();
                    string pAlias = dtParent.Rows[i]["parentAliases"].ToString();
                    string parentName = dtParent.Rows[i]["parentCompanyName"].ToString() + (pAlias.Trim() != "" ? "(" + pAlias + ")" : "");

                    if(parentName.ToLower().IndexOf(search) != -1)
                    {
                        //KALO KETEMU DI PARENT, BRARTI DI MUNCULIN SEMUA
                        if (treeCust.Nodes.ContainsKey(parentID) == false) treeCust.Nodes.Add(parentID, parentName);
                        dtCompany = ExecuteQuery("SELECT * FROM MsCompany WHERE parentCompanyID = " + parentID + " ORDER BY companyName");
                        for (int j = 0; j < dtCompany.Rows.Count; j++)
                        {
                            string companyID = dtCompany.Rows[j]["companyID"].ToString();
                            string alias = dtCompany.Rows[j]["aliases"].ToString();
                            string companyName = dtCompany.Rows[j]["companyName"].ToString()+(alias == "" ? "" : " (" + alias + ")");
                            if (treeCust.Nodes[treeCust.Nodes.Count - 1].Nodes.ContainsKey(companyID) == false) treeCust.Nodes[treeCust.Nodes.Count - 1].Nodes.Add(companyID, companyName);
                            dtCustomer = ExecuteQuery("SELECT * FROM MsCustomer WHERE companyID = " + companyID + " ORDER BY customerName");
                            for (int k = 0; k < dtCustomer.Rows.Count; k++)
                            {
                                string customerID = dtCustomer.Rows[k]["customerID"].ToString();
                                string customerName = dtCustomer.Rows[k]["customerName"].ToString();
                                treeCust.Nodes[treeCust.Nodes.Count - 1].Nodes[treeCust.Nodes[treeCust.Nodes.Count - 1].Nodes.Count - 1].Nodes.Add(customerID, customerName);
                            }
                            dtCustomer = null;
                        }
                        dtCompany = null;
                    }
                    else
                    {
                        //KALO GA KETEMU DI PARENT, CARI LAGI DI COMPANY
                        //treeCust.Nodes.Add(parentID, parentName); <-- tidak boleh di add dulu
                        dtCompany = ExecuteQuery("SELECT * FROM MsCompany WHERE parentCompanyID = " + parentID + "  ORDER BY companyName");
                        for (int j = 0; j < dtCompany.Rows.Count; j++)
                        {
                            string companyID = dtCompany.Rows[j]["companyID"].ToString();
                            string alias = dtCompany.Rows[j]["aliases"].ToString();
                            string companyName = dtCompany.Rows[j]["companyName"].ToString() + (alias == "" ? "" : " (" + alias + ")");

                            if (companyName.ToLower().IndexOf(search) != -1)
                            {
                                //KALO KETEMU DI COMPANY, BRARTI DI MUNCULIN SEMUA
                                if (treeCust.Nodes.ContainsKey(parentID) == false) treeCust.Nodes.Add(parentID, parentName); // <-- jangan lupa add parentnya
                                if (treeCust.Nodes[treeCust.Nodes.Count - 1].Nodes.ContainsKey(companyID) == false) treeCust.Nodes[treeCust.Nodes.Count - 1].Nodes.Add(companyID, companyName);
                                dtCustomer = ExecuteQuery("SELECT * FROM MsCustomer WHERE companyID = " + companyID + " ORDER BY customerName");
                                for (int k = 0; k < dtCustomer.Rows.Count; k++)
                                {
                                    string customerID = dtCustomer.Rows[k]["customerID"].ToString();
                                    string customerName = dtCustomer.Rows[k]["customerName"].ToString();
                                    treeCust.Nodes[treeCust.Nodes.Count - 1].Nodes[treeCust.Nodes[treeCust.Nodes.Count - 1].Nodes.Count - 1].Nodes.Add(customerID, customerName);
                                }
                                dtCustomer = null;
                            }
                            else
                            {
                                //KALO TIDAK KETEMU DI COMPANY, BRARTI CARI LAGI DI CUSTOMER
                                //treeCust.Nodes[i].Nodes.Add(companyID, companyName); <-- tidak boleh di add dulu
                                dtCustomer = ExecuteQuery("SELECT * FROM MsCustomer WHERE companyID = " + companyID + " ORDER BY customerName");
                                for (int k = 0; k < dtCustomer.Rows.Count; k++)
                                {
                                    string customerID = dtCustomer.Rows[k]["customerID"].ToString();
                                    string customerName = dtCustomer.Rows[k]["customerName"].ToString();
                                    customerEmail = dtCustomer.Rows[k]["email"].ToString();

                                    if (customerName.ToLower().IndexOf(search) != -1)
                                    {
                                        //BRARTI KETEMU DI BAGIAN PALING UJUNG
                                        if (treeCust.Nodes.ContainsKey(parentID) == false) treeCust.Nodes.Add(parentID, parentName);
                                        if (treeCust.Nodes[treeCust.Nodes.Count - 1].Nodes.ContainsKey(companyID) == false) treeCust.Nodes[treeCust.Nodes.Count - 1].Nodes.Add(companyID, companyName);
                                        treeCust.Nodes[treeCust.Nodes.Count - 1].Nodes[treeCust.Nodes[treeCust.Nodes.Count - 1].Nodes.Count - 1].Nodes.Add(customerID, customerName);
                                    }
                                    else
                                    {
                                        //GA DI MASUKIN APA APA KARENA GA ADA DI NODE PARENT INI
                                    }
                                }
                                dtCustomer = null;
                            }
                        }
                        dtCompany = null;
                    }
                }
                dtParent = null;
            }

            treeCust.ExpandAll();
            //treeCust.scro
        }

        private void SearchCustomerPVC_Load(object sender, EventArgs e)
        {
            refreshData();
            tbSearch.Focus();
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            refreshData(tbSearch.Text.ToLower());
        }

        private void setParent(int parentID, string parentName)
        {
            tbParentID.Text = parentID == 0 ? "" : parentID + "";
            tbParentName.Text = parentName;
        }

        private void setCompany(int companyID, string companyName)
        {
            tbCompanyID.Text = companyID == 0 ? "" : companyID + "";
        }

        private void setCustomer(int customerID, string customerName)
        {
            tbCustomerID.Text = customerID == 0 ? "" : customerID + "";
        }

        private void treeCust_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode selectedNode = treeCust.SelectedNode;
            if (selectedNode.Level == 0)
            {
                setParent(Int32.Parse(selectedNode.Name.ToString()), selectedNode.Text.ToString());
                setCompany(0, "");
                setCustomer(0, "");
            }
            else if (selectedNode.Level == 1)
            {
                setParent(Int32.Parse(selectedNode.Parent.Name.ToString()), selectedNode.Parent.Text.ToString());
                setCompany(Int32.Parse(selectedNode.Name.ToString()), selectedNode.Text.ToString());
                setCustomer(0, "");
            }
            else if (selectedNode.Level == 2)
            {
                setParent(Int32.Parse(selectedNode.Parent.Parent.Name.ToString()), selectedNode.Parent.Parent.Text.ToString());
                setCompany(Int32.Parse(selectedNode.Parent.Name.ToString()), selectedNode.Parent.Text.ToString());
                setCustomer(Int32.Parse(selectedNode.Name.ToString()), selectedNode.Text.ToString());
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (tbCustomerID.Text != "")
            {
                main.globalParentCompanyID = Int32.Parse(tbParentID.Text);
                main.globalCompanyID = Int32.Parse(tbCompanyID.Text);
                main.globalCustomerID = Int32.Parse(tbCustomerID.Text);
                main.globalParentCompanyName = tbParentName.Text;
                main.globalCompanyName = tbCompanyName.Text;
                main.globalCustomerName = tbCustomerName.Text;

                DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            else
            {
                main.SetMessage("You Must Select Customer Name!");
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            tbSearch.Text = "";
            refreshData();
        }

        private void btnAddParent_Click(object sender, EventArgs e)
        {
            AddParentCompany addParentForm = new AddParentCompany(main);
            DialogResult result = addParentForm.ShowDialog();
            tbSearch.Text = main.globalParentCompanyName;
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                refreshData(tbSearch.Text);
                main.globalParentCompanyName = "";
            }
        }

        private void btnDeleteParent_Click(object sender, EventArgs e)
        {
            if (tbParentID.Text != "")
            {
                AnsBox ans = new AnsBox(main, "Yakin di HAPUS '" + tbParentName.Text + "'(" + tbParentID.Text + ")?", "WARNING!");
                DialogResult result = ans.ShowDialog();
                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    ExecuteQuery("DELETE FROM MsParentCompany WHERE parentCompanyID = " + tbParentID.Text + "");
                }
            }
        }

        private void btnDeleteCompany_Click(object sender, EventArgs e)
        {
            if (tbCompanyID.Text != "")
            {
                AnsBox ans = new AnsBox(main, "Yakin di HAPUS '" + tbCompanyName.Text + "'(" + tbCompanyID.Text + ")?", "WARNING!");
                DialogResult result = ans.ShowDialog();
                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    ExecuteQuery("DELETE FROM MsCompany WHERE companyID = " + tbCompanyID.Text + "");
                }
            }
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            if (tbCustomerID.Text != "")
            {
                AnsBox ans = new AnsBox(main, "Yakin di HAPUS '" + tbCustomerName.Text + "'(" + tbCustomerID.Text + ")?", "WARNING!");
                DialogResult result = ans.ShowDialog();
                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    ExecuteQuery("DELETE FROM MsCustomer WHERE customerID = " + tbCustomerID.Text + "");
                }
            }
        }

        private void btnAddCompany_Click(object sender, EventArgs e)
        {
            if (tbParentID.Text != "")
            {
                AddCompany addCompanyForm = new AddCompany(main, Int32.Parse(tbParentID.Text), tbParentName.Text);
                DialogResult result = addCompanyForm.ShowDialog();
                tbSearch.Text = main.globalCompanyName;
                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    // kalo abis di add, harus di refresh
                    refreshData(tbSearch.Text);
                    main.globalCompanyName = "";
                }
            }
            else
            {
                //GA BISA KALO GA ADA PARENT ID nya
                //HARUS DI BUAT MESSAGE ERROR
            }
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            if (tbCompanyID.Text != "")
            {
                AddCustomer addCustomerForm = new AddCustomer(main, Int32.Parse(tbCompanyID.Text), tbCompanyName.Text);
                DialogResult result = addCustomerForm.ShowDialog();
                tbSearch.Text = main.globalCustomerName;
                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    // kalo abis di add, harus di refresh
                    refreshData(tbSearch.Text);
                    main.globalCustomerName = "";
                }
            }
            else
            {
                //GA BISA KALO GA ADA PARENT ID nya
                //HARUS DI BUAT MESSAGE ERROR
            }
        }

        private void treeCust_DoubleClick(object sender, EventArgs e)
        {
            btnOK_Click(sender, e);
        }

        private void tbSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                DialogResult = System.Windows.Forms.DialogResult.Cancel;
            }
            else if (e.KeyCode == Keys.Enter)
            {
                refreshData(tbSearch.Text);
            }
        }

        private void tbCompanyID_TextChanged(object sender, EventArgs e)
        {
            if (tbCompanyID.Text.Trim() != "")
            {
                int companyID = Int32.Parse(tbCompanyID.Text.Trim());
                if (companyID != 0)
                {
                    DataTable dt = ExecuteQuery("SELECT companyName, phone, phone2, address FROM MsCompany WHERE companyID = '" + companyID + "'");
                    if (dt != null)
                    {
                        if (dt.Rows.Count == 1)
                        {
                            string name = dt.Rows[0]["companyName"].ToString().Trim();
                            string phone1 = dt.Rows[0]["phone"].ToString().Trim();
                            string phone2 = dt.Rows[0]["phone2"].ToString().Trim();
                            string address = dt.Rows[0]["address"].ToString().Trim();

                            tbCompanyPhone.Text = phone1 + (phone1 != "" && phone2 != "" ? " / " : "") + phone2;
                            tbCompanyAddress.Text = address;
                            tbCompanyName.Text = name;
                            return;
                        }
                    }
                }
            }
            tbCompanyPhone.Text = "";
            tbCompanyAddress.Text = "";
        }

        private void blockUpdate()
        {
            tbParentName.ReadOnly = false;
            tbCompanyAddress.ReadOnly = false;
            tbCompanyName.ReadOnly = false;
            tbCompanyPhone.ReadOnly = false;
            tbCustomerAddress.ReadOnly = false;
            tbCustomerName.ReadOnly = false;
            tbCustomerPhone.ReadOnly = false;
        }

        private void btnUpdateParentName_Click(object sender, EventArgs e)
        {
            if (tbParentID.Text != "")
                if (Int32.Parse(tbParentID.Text) != 0)
                {
                    blockUpdate();
                    if (tbParentName.ReadOnly)
                    {
                        tbParentName.ReadOnly = true;
                    }
                    else
                    {
                        ExecuteQuery("UPDATE MsParentCompany SET parentCompanyName = '" + tbParentName.Text + "' WHERE parentCompanyID = '" + tbParentID.Text + "'");
                    }
                }
        }

        private void btnUpdateCompanyName_Click(object sender, EventArgs e)
        {
            if (tbCompanyID.Text != "")
                if (Int32.Parse(tbCompanyID.Text) != 0)
                {
                    blockUpdate();
                    if (tbCompanyName.ReadOnly)
                    {
                        tbCompanyName.ReadOnly = true;
                    }
                    else
                    {
                        ExecuteQuery("UPDATE MsCompany SET companyName = '" + tbCompanyName.Text + "' WHERE companyID = '" + tbCompanyID.Text + "'");
                    }
                }
        }

        private void btnUpdateCustomerName_Click(object sender, EventArgs e)
        {
            if (tbCustomerID.Text != "")
                if (Int32.Parse(tbCustomerID.Text) != 0)
                {
                    blockUpdate();
                    if (tbCustomerName.ReadOnly)
                    {
                        tbCustomerName.ReadOnly = true;
                    }
                    else
                    {
                        ExecuteQuery("UPDATE MsCustomer SET customerName = '" + tbCustomerName.Text + "' WHERE customerID = '" + tbCustomerID.Text + "'");
                    }
                }
        }

        private void btnUpdateCompanyPhone_Click(object sender, EventArgs e)
        {
            if (tbCompanyID.Text != "")
                if (Int32.Parse(tbCompanyID.Text) != 0)
                {
                    blockUpdate();
                    if (tbCompanyPhone.ReadOnly)
                    {
                        tbCompanyPhone.ReadOnly = true;
                    }
                    else
                    {
                        string temp = tbCompanyPhone.Text;
                        string phone = temp.IndexOf("/") != -1 ? temp.Substring(0, temp.IndexOf("/") - 1).Trim() : temp;
                        string phone2 = temp.IndexOf("/") != -1 ? temp.Substring(temp.IndexOf("/") + 1).Trim() : "";
                        ExecuteQuery("UPDATE MsCompany SET phone = '" + phone + "', phone2 = '" + phone2 + "' WHERE companyID = '" + tbCompanyID.Text + "'");
                    }
                }
        }

        private void btnUpdateCompanyAddress_Click(object sender, EventArgs e)
        {
            if (tbCompanyID.Text != "")
                if (Int32.Parse(tbCompanyID.Text) != 0)
                {
                    blockUpdate();
                    if (tbCompanyAddress.ReadOnly)
                    {
                        tbCompanyAddress.ReadOnly = true;
                    }
                    else
                    {
                        ExecuteQuery("UPDATE MsCompany SET address = '" + tbCompanyAddress.Text + "' WHERE companyID = '" + tbCompanyID.Text + "'");
                    }
                }
        }

        private void btnUpdateCustomerPhone_Click(object sender, EventArgs e)
        {
            if (tbCustomerID.Text != "")
                if (Int32.Parse(tbCustomerID.Text) != 0)
                {
                    blockUpdate();
                    if (tbCustomerPhone.ReadOnly)
                    {
                        tbCustomerPhone.ReadOnly = true;
                    }
                    else
                    {
                        string temp = tbCustomerPhone.Text;
                        string phone = temp.IndexOf("/") != -1 ? temp.Substring(0, temp.IndexOf("/") - 1).Trim() : temp;
                        string phone2 = temp.IndexOf("/") != -1 ? temp.Substring(temp.IndexOf("/") + 1).Trim() : "";
                        ExecuteQuery("UPDATE MsCustomer SET phone = '" + phone + "', phone2 = '" + phone2 + "' WHERE customerID = '" + tbCustomerID.Text + "'");
                    }
                }
        }

        private void btnUpdateCustomerAddress_Click(object sender, EventArgs e)
        {
            if (tbCustomerID.Text != "")
                if (Int32.Parse(tbCustomerID.Text) != 0)
                {
                    blockUpdate();
                    if (tbCustomerAddress.ReadOnly)
                    {
                        tbCustomerAddress.ReadOnly = true;
                    }
                    else
                    {
                        ExecuteQuery("UPDATE MsCustomer SET address = '" + tbCustomerAddress.Text + "' WHERE customerID = '" + tbCustomerID.Text + "'");
                    }
                }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            refreshData(tbSearch.Text);
        }

        private void tbCustomerID_TextChanged(object sender, EventArgs e)
        {
            if (tbCustomerID.Text.Trim() != "")
            {
                DataTable dt = ExecuteQuery("SELECT customerName, phone, phone2, address FROM MsCustomer WHERE customerID = '" + tbCustomerID.Text + "'");
                if (dt != null)
                {
                    if (dt.Rows.Count == 1)
                    {
                        string phone = dt.Rows[0]["phone"].ToString();
                        string phone2 = dt.Rows[0]["phone2"].ToString();
                        string address = dt.Rows[0]["address"].ToString();
                        string name = dt.Rows[0]["customerName"].ToString();

                        tbCustomerPhone.Text = phone + (phone2.Trim() != "" ? " / " + phone2 : "");
                        tbCustomerAddress.Text = address;
                        tbCustomerName.Text = name;
                    }
                }
            }
            else
            {
                tbCustomerID.Text = "";
                tbCustomerPhone.Text = "";
                tbCustomerAddress.Text = "";
                tbCustomerName.Text = "";
            }
        }

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            if (tbCustomerID.Text.Trim() != "")
            {
                ChangeCustomer changeCust = new ChangeCustomer(main, Int32.Parse(tbCustomerID.Text.Trim()));
                DialogResult result = changeCust.ShowDialog();
                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    if (tbSearch.Text != "")
                        refreshData(tbSearch.Text);
                    else
                        refreshData();
                }
            }
        }
    }
}
