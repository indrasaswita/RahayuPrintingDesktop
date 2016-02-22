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
    public partial class AddCompany : Form
    {
        MainForm main;
        private int parentCompanyID;
        private string parentCompanyName;

        public AddCompany(MainForm main, int parentCompanyID, string parentCompanyName)
        {
            this.main = main;
            this.parentCompanyID = parentCompanyID;
            this.parentCompanyName = parentCompanyName;
            InitializeComponent();
        }

        public DataTable ExecuteQuery(string query)
        {
            return main.ExecuteQuery(query);
        }

        public void RefreshData()
        {
            RefreshData("");
        }

        public void RefreshData(string search)
        {
            gridView.Rows.Clear();
            DataTable dt = ExecuteQuery("SELECT companyName FROM MsCompany WHERE companyName LIKE '%" + search + "%'");
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                    gridView.Rows.Add(dt.Rows[i]["companyName"].ToString());
            }
        }

        private void AddCompany_Load(object sender, EventArgs e)
        {
            gridView.Columns.Add("", "Company Name");
            gridView.Columns[0].Width = 429;

            tbParentCompany.Text = parentCompanyName;
            tbCompanyName.Focus();
        }

        private void btnAddCompany_Click(object sender, EventArgs e)
        {
            if (tbCompanyName.Text != "Company Name")
                if (tbCompanyName.Text.Length < 3)
                {
                }
                else
                {
                    ExecuteQuery("INSERT INTO MsCompany(parentCompanyID, companyName, aliases, fax, phone, phone2, address) VALUES (" + parentCompanyID + ", '" + (tbCompanyName.Text == "Company Name" ? "" : tbCompanyName.Text) + "', '" + (tbAlias.Text == "Alias" ? "" : tbAlias.Text) + "', '" + (tbFax.Text == "Fax" ? "" : tbFax.Text) + "', '" + (tbPhone.Text == "Phone 1" ? "" : tbPhone.Text) + "', '" + (tbPhone2.Text == "Phone 2" ? "" : tbPhone2.Text) + "', '" + (tbAddress.Text == "Address" ? "" : tbAddress.Text) + "')");
                    main.globalCompanyName = tbCompanyName.Text;
                    DialogResult = System.Windows.Forms.DialogResult.OK;
                }
        }

        private void tbCompanyName_Leave(object sender, EventArgs e)
        {
            if (tbCompanyName.Text == "")
            {
                tbCompanyName.Text = "Company Name";
                tbCompanyName.ForeColor = Color.DarkGray;
            }
        }

        private void tbAlias_Leave(object sender, EventArgs e)
        {
            if (tbAlias.Text == "")
            {
                tbAlias.Text = "Alias";
                tbAlias.ForeColor = Color.DarkGray;
            }
        }

        private void tbFax_Leave(object sender, EventArgs e)
        {
            if (tbFax.Text == "")
            {
                tbFax.Text = "Fax";
                tbFax.ForeColor = Color.DarkGray;
            }

        }

        private void tbPhone_Leave(object sender, EventArgs e)
        {
            if (tbPhone.Text == "")
            {
                tbPhone.Text = "Phone 1";
                tbPhone.ForeColor = Color.DarkGray;
            }
        }

        private void tbPhone2_Leave(object sender, EventArgs e)
        {
            if (tbPhone2.Text == "")
            {
                tbPhone2.Text = "Phone 2";
                tbPhone2.ForeColor = Color.DarkGray;
            }
        }

        private void tbAddress_Leave(object sender, EventArgs e)
        {
            if (tbAddress.Text == "")
            {
                tbAddress.Text = "Address";
                tbAddress.ForeColor = Color.DarkGray;
            }
        }

        private void tbCompanyName_Enter(object sender, EventArgs e)
        {
            if (tbCompanyName.Text == "Company Name")
            {
                tbCompanyName.Text = "";
                tbCompanyName.ForeColor = Color.Black;
            }
        }

        private void tbAlias_Enter(object sender, EventArgs e)
        {
            if (tbAlias.Text == "Alias")
            {
                tbAlias.Text = "";
                tbAlias.ForeColor = Color.Black;
            }
        }

        private void tbFax_Enter(object sender, EventArgs e)
        {
            if (tbFax.Text == "Fax")
            {
                tbFax.Text = "";
                tbFax.ForeColor = Color.Black;
            }
        }

        private void tbPhone_Enter(object sender, EventArgs e)
        {
            if (tbPhone.Text == "Phone 1")
            {
                tbPhone.Text = "";
                tbPhone.ForeColor = Color.Black;
            }
        }

        private void tbPhone2_Enter(object sender, EventArgs e)
        {
            if (tbPhone2.Text == "Phone 2")
            {
                tbPhone2.Text = "";
                tbPhone2.ForeColor = Color.Black;
            }
        }

        private void tbAddress_Enter(object sender, EventArgs e)
        {
            if (tbAddress.Text == "Address")
            {
                tbAddress.Text = "";
                tbAddress.ForeColor = Color.Black;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void tbCompanyName_TextChanged(object sender, EventArgs e)
        {
            if (tbCompanyName.Text != "Company Name") RefreshData(tbCompanyName.Text);
            else RefreshData();
        }

        private void tbParentCompany_Enter(object sender, EventArgs e)
        {
            tbCompanyName.Focus();
        }

        private void tbCompanyName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tbAlias.Focus();
            }
        }

        private void tbAlias_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tbFax.Focus();
            }
        }

        private void tbFax_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tbPhone.Focus();
            }
        }

        private void tbPhone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tbPhone2.Focus();
            }
        }

        private void tbPhone2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tbAddress.Focus();
            }
        }

        private void tbAddress_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAddCompany.Focus();
            }
        }
    }
}
