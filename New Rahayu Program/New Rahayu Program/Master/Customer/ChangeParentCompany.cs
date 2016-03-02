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
    public partial class ChangeParentCompany : Form
    {
        MainForm main;
        int parentCompanyID;

        public ChangeParentCompany(MainForm main, int parentCompanyID)
        {
            this.main = main;
            this.parentCompanyID = parentCompanyID;

            InitializeComponent();
        }

        public DataTable ExecuteQuery(string query)
        {
            return main.ExecuteQuery(query);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (tbParentName.Text.Trim().Length < 3)
            {
                main.SetMessage("TIDAK BISA KOSONG");
            }
            else
            {
                string status = "active";

                if (rbActive.Checked) status = "active";
                else if (rbBlock.Checked) status = "block";
                else if (rbWarning.Checked) status = "warning";

                ExecuteQuery("UPDATE MsParentCompany SET parentCompanyName = '" + (cbHidden.Checked ? "No ParentCompany" : tbParentName.Text.Trim()) + "', parentAliases = '" + (cbHidden.Checked ? tbParentName.Text.Trim() : "") + "', status = '" + status + "' WHERE parentCompanyID = '" + parentCompanyID + "'");
                DialogResult = System.Windows.Forms.DialogResult.OK;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void ChangeParentCompany_Load(object sender, EventArgs e)
        {
            rbActive.Checked = true;
            if (parentCompanyID == 0) DialogResult = System.Windows.Forms.DialogResult.Cancel;

            DataTable dt = ExecuteQuery("SELECT parentCompanyName, parentAliases, status FROM MsParentCompany WHERE parentCompanyID = '" + parentCompanyID + "'");
            if (dt != null)
            {
                if (dt.Rows.Count == 1)
                {
                    string name = dt.Rows[0]["parentCompanyName"].ToString();
                    string alias = dt.Rows[0]["parentAliases"].ToString();
                    string status = dt.Rows[0]["status"].ToString();

                    tbParentName.Text = name == "No ParentCompany" ? alias : name;
                    if (alias == "") cbHidden.Checked = false;
                    else cbHidden.Checked = true;
                    if (status == "active") rbActive.Checked = true;
                    else if (status == "block") rbBlock.Checked = true;
                    else if (status == "warning") rbWarning.Checked = true;
                }
            }
            else
            {
                main.SetMessage("Data parent Company Tidak bisa ke load, ada error");
                DialogResult = System.Windows.Forms.DialogResult.Cancel;
            }
        }
    }
}
