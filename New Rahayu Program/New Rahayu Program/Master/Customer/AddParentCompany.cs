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
    public partial class AddParentCompany : Form
    {
        MainForm main;

        public AddParentCompany(MainForm main)
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

        private void btnAddParent_Click(object sender, EventArgs e)
        {
            if (tbParentCompanyName.Text != "Parent Company Name")
                if (tbParentCompanyName.Text.Length > 3)
                {
                    ExecuteQuery("INSERT INTO MsParentCompany(parentCompanyName) VALUES ('" + tbParentCompanyName.Text + "')");

                    DialogResult = System.Windows.Forms.DialogResult.OK;
                }
        }

        private void tbParentCompanyName_TextChanged(object sender, EventArgs e)
        {
            refreshData(tbParentCompanyName.Text);
        }

        private void refreshData()
        {
            refreshData("");
        }

        private void refreshData(string search)
        {
            DataTable dt = ExecuteQuery("SELECT parentCompanyName FROM MsParentCompany WHERE parentCompanyName LIKE '%" + search + "%'");

            dataGridView1.Rows.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dataGridView1.Rows.Add(dt.Rows[i]["parentCompanyName"].ToString());
            }
        }

        private void tbParentCompanyName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAddParent.Focus();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                btnCancel_Click(sender, e);
            }
        }

        private void btnCancel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                btnCancel_Click(sender, e);
            }
        }

        private void AddParentCompany_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("", "Parent Company Name");
            dataGridView1.Columns[0].Width = 429;

            refreshData();
        }

        private void tbParentCompanyName_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAddParent.Focus();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                btnCancel_Click(sender, e);
            }
        }
    }
}
