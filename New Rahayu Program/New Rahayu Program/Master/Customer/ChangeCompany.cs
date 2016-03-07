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
    public partial class ChangeCompany : Form
    {
        MainForm main;
        int companyID;

        public ChangeCompany(MainForm main, int companyID)
        {
            this.main = main;
            this.companyID = companyID;

            InitializeComponent();
        }

        public DataTable ExecuteQuery(string query)
        {
            return main.ExecuteQuery(query);
        }

        private void ChangeCompany_Load(object sender, EventArgs e)
        {
            if (companyID != 0)
            {
                DataTable dt = ExecuteQuery("SELECT parentCompanyID, companyName, aliases, fax, phone, phone2, address, status FROM MsCompany WHERE companyID = '" + companyID + "'");

                if (dt != null)
                {
                    if (dt.Rows.Count == 1)
                    {
                        string parentCompanyID = dt.Rows[0]["parentCompanyID"].ToString();
                        string companyName = dt.Rows[0]["companyName"].ToString();
                        string aliases = dt.Rows[0]["aliases"].ToString();
                        string fax = dt.Rows[0]["fax"].ToString();
                        string phone = dt.Rows[0]["phone"].ToString();
                        string phone2 = dt.Rows[0]["phone2"].ToString();
                        string address = dt.Rows[0]["address"].ToString();
                        string status = dt.Rows[0]["status"].ToString();

                        tbCompanyName.Text = companyName;
                    }
                }
            }
            else
            {
                main.SetMessage("Tidak ada companyID sekian, ada error!");
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string status = "active";
            if (rbActive.Checked) status = "active";
            else if (rbBlock.Checked) status = "block";
            else if (rbWarning.Checked) status = "warning";

            ExecuteQuery("UPDATE MsCompany SET companyName = '" + tbCompanyName.Text 
                            + "', aliases = '" + tbAliases.Text + "', fax = '" 
                            + tbFax.Text + "', phone = '" + tbPhone1.Text 
                            + "', phone2 = '" + tbPhone2.Text + "', address = '" 
                            + tbAddress.Text + "', status = '" + status + "' WHERE companyID = '" + companyID + "'");
        }
    }
}
