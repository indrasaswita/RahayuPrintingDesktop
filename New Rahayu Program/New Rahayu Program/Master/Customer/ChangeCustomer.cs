using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Rahayu_Program.Master.Customer
{
    public partial class ChangeCustomer : Form
    {
        MainForm main;
        int customerID;

        public ChangeCustomer(MainForm main, int customerID)
        {
            this.main = main;
            this.customerID = customerID;
            InitializeComponent();
        }

        public DataTable ExecuteQuery(string query)
        {
            return main.ExecuteQuery(query);
        }

        private void ChangeCustomer_Load(object sender, EventArgs e)
        {
            searchParent();
            if (parentID != 0)
            {
                FillParentCompany(); // <-- HARUS DULUAN DARI CUSTOMER
                FillCustomerData();
            }
        }

        int parentID = 0;
        int companyID = 0;

        private void searchParent()
        {
            DataTable dt = ExecuteQuery("SELECT parentCompanyID, co.companyID FROM MsCompany co JOIN MsCustomer cu ON co.companyID = cu.companyID WHERE customerID = '" + customerID + "'");
            if (dt != null)
            {
                if (dt.Rows.Count == 1)
                {
                    parentID = Int32.Parse(dt.Rows[0]["parentCompanyID"].ToString());
                    companyID = Int32.Parse(dt.Rows[0]["companyID"].ToString());
                }
            }
        }

        private void FillCustomerData()
        {
            DataTable dt = ExecuteQuery("SELECT parentCompanyID, cu.companyID, customerName, cu.phone, cu.phone2, cu.pinBB, cu.lineID, cu.email, cu.position, cu.address, cu.catatan FROM MsCustomer cu JOIN MsCompany co ON cu.companyID = co.companyID WHERE customerID = '" + customerID + "'");
            if (dt != null)
            {
                if (dt.Rows.Count == 1)
                {
                    parentID = Int32.Parse(dt.Rows[0]["parentCompanyID"].ToString());
                    companyID = Int32.Parse(dt.Rows[0]["companyID"].ToString());
                    tbCustName.Text = dt.Rows[0]["customerName"].ToString();
                    tbPhone1.Text = dt.Rows[0]["phone"].ToString();
                    tbPhone2.Text = dt.Rows[0]["phone2"].ToString();
                    tbPinBB.Text = dt.Rows[0]["pinBB"].ToString();
                    tbLineID.Text = dt.Rows[0]["lineID"].ToString();
                    tbEmail.Text = dt.Rows[0]["email"].ToString();
                    tbPosition.Text = dt.Rows[0]["position"].ToString();
                    tbAlamat.Text = dt.Rows[0]["address"].ToString();
                    tbCatatan.Text = dt.Rows[0]["catatan"].ToString();
                }
            }
        }

        private void FillParentCompany()
        {
            DataTable dt = ExecuteQuery("SELECT parentCompanyID, parentCompanyName, parentAliases FROM MsParentCompany WHERE status = 'active'");
            lbParentCompany.Items.Clear();
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    int selected = 0;
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        string id = dt.Rows[i]["parentCompanyID"].ToString();
                        string name = dt.Rows[i]["parentCompanyName"].ToString();
                        string alias = dt.Rows[i]["parentAliases"].ToString();

                        lbParentCompany.Items.Add(String.Format("{0:D4}", id) + "#" + (name == "No ParentCompany" ? alias : name));
                        if (parentID == Int32.Parse(id)) selected = i;
                    }
                    lbParentCompany.SelectedIndex = selected;
                }
            }
        }

        private void FillCompany(string parentCompanyID)
        {
            DataTable dt = ExecuteQuery("SELECT companyID, companyName, aliases FROM MsCompany WHERE status = 'active' AND parentCompanyID = '" + parentCompanyID + "'");
            lbCompany.Items.Clear();
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    int selected = 0;
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        string id = dt.Rows[i]["companyID"].ToString();
                        string name = dt.Rows[i]["companyName"].ToString();
                        string alias = dt.Rows[i]["aliases"].ToString();

                        lbCompany.Items.Add(String.Format("{0:D4}", id) + "#" + (name + (alias == "" ? "" : " (" + alias + ")")));
                        if (companyID == Int32.Parse(id)) selected = i;
                    }
                    lbCompany.SelectedIndex = selected;
                }
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (tbCustName.Text.Length < 3)
            {
                main.SetMessage("Customer Name tidak boleh kosong!");
            }
            else if (tbPhone1.Text.Length < 5)
            {
                main.SetMessage("Telepon tidak boleh kosong");
            }
            else
            {
                string selected = lbCompany.SelectedItem.ToString();
                int companyID = Int32.Parse(selected.Substring(0, selected.IndexOf('#')));

                ExecuteQuery("UPDATE MsCustomer SET customerName = '" + tbCustName.Text + "', phone = '" + tbPhone1.Text + "', phone2 = '" + tbPhone2.Text + "', address = '" + tbAlamat.Text + "', email = '" + tbEmail.Text + "', pinBB = '" + tbPinBB.Text + "', lineID = '" + tbLineID.Text + "', catatan = '" + tbCatatan.Text + "', position = '" + tbPosition.Text + "', companyID = '" + companyID + "' WHERE customerID = '" + customerID + "'");
            }

            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void lbParentCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = lbParentCompany.SelectedItem.ToString();
            FillCompany(selected.Substring(0, selected.IndexOf('#')));
        }
    }
}
