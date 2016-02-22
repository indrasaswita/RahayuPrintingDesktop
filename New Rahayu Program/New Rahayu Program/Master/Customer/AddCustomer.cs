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
    public partial class AddCustomer : Form
    {
        private MainForm main;
        private int companyID;
        private string companyName;

        public AddCustomer(MainForm main, int companyID, string companyName)
        {
            this.main = main;
            this.companyID = companyID;
            this.companyName = companyName;

            InitializeComponent();
        }

        public DataTable ExecuteQuery(string query)
        {
            return main.ExecuteQuery(query);
        }

        private void tbCustomerName_Leave(object sender, EventArgs e)
        {
            if (tbCustomerName.Text == "")
            {
                tbCustomerName.Text = "Customer Name";
                tbCustomerName.ForeColor = Color.DarkGray;
            }
        }

        private void AddCustomer_Load(object sender, EventArgs e)
        {
            gridView.Columns.Add("", "Customer Name");
            gridView.Columns[0].Width = 200;
            gridView.Columns.Add("", "Company Name");
            gridView.Columns[1].Width = 429;

            tbCompanyName.Text = companyName;
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

        private void tbEmail_Leave(object sender, EventArgs e)
        {
            if (tbEmail.Text == "")
            {
                tbEmail.Text = "Email";
                tbEmail.ForeColor = Color.DarkGray;
            }
        }

        private void tbCustomerName_Enter(object sender, EventArgs e)
        {
            if (tbCustomerName.Text == "Customer Name")
            {
                tbCustomerName.Text = "";
                tbCustomerName.ForeColor = Color.Black;
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

        private void tbEmail_Enter(object sender, EventArgs e)
        {
            if (tbEmail.Text == "Email")
            {
                tbEmail.Text = "";
                tbEmail.ForeColor = Color.Black;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            if (tbCustomerName.Text == "Customer Name")
            {
            }
            else if (tbCustomerName.Text.Length < 3)
            {
            }
            else
            {
                ExecuteQuery("INSERT INTO MsCustomer(companyID, customerName, phone, phone2, address, email, status) VALUES (" + companyID + ", '" + (tbCustomerName.Text == "CustomerName" ? "" : tbCustomerName.Text) + "', '" + (tbPhone.Text == "Phone 1" ? "" : tbPhone.Text) + "', '" + (tbPhone2.Text == "Phone 2" ? "" : tbPhone2.Text) + "', '" + (tbAddress.Text == "Address" ? "" : tbAddress.Text) + "', '" + (tbEmail.Text == "Email" ? "" : tbEmail.Text) + "', 'active')");
                main.globalCustomerName = tbCustomerName.Text;
                DialogResult = System.Windows.Forms.DialogResult.OK;
            }
        }

        private void tbCustomerName_TextChanged(object sender, EventArgs e)
        {
            if (tbCustomerName.Text == "Customer Name")
            {
                RefreshData();
            }
            else
            {
                RefreshData(tbCustomerName.Text);
            }
        }

        private void RefreshData()
        {
            RefreshData("");
        }

        private void RefreshData(string search)
        {
            gridView.Rows.Clear();
            DataTable dt = ExecuteQuery("SELECT customerName, companyName FROM MsCustomer a, MsCompany b WHERE a.companyID = b.companyID AND customerName LIKE '%" + search + "%'");
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                    gridView.Rows.Add(dt.Rows[i]["customerName"].ToString(), dt.Rows[i]["companyName"].ToString());
            }
        }

        private void tbCompanyName_Enter(object sender, EventArgs e)
        {
            tbCustomerName.Focus();
        }
    }
}
