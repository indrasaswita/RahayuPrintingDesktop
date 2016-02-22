using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Rahayu_Program.Master.Employee
{
    public partial class ChangePassword : Form
    {
        MainForm main;

        public ChangePassword(MainForm main)
        {
            this.main = main;

            InitializeComponent();
        }

        public DataTable ExecuteQuery(string query)
        {
            return main.ExecuteQuery(query);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (tbOldPass.Text == "")
            {
                main.SetMessage("masukkan PASSWORD LAMA disini!");
                tbOldPass.Focus();
            }
            else if (tbNewPass.Text.Length < 6)
            {
                main.SetMessage("masukkan PASSWORD BARU disini (Minimal 6 karakter) !");
                tbNewPass.Focus();
            }
            else if (tbNewPass.Text == "")
            {
                main.SetMessage("ketik ulang PASSWORD BARUnya!");
                tbNewPass2.Focus();
            }
            else
            {
                string pass = "";
                DataTable dt = ExecuteQuery("SELECT password FROM MsEmployee WHERE employeeID = '" + main.globalEmployeeID + "'");
                if (dt != null)
                    if (dt.Rows.Count == 1)
                    {
                        pass = dt.Rows[0]["password"].ToString();
                    }
                if (pass == Other.Parser.StringToMD5(tbOldPass.Text))
                {
                    ExecuteQuery("UPDATE MsEmployee SET password = '" + Other.Parser.StringToMD5(tbNewPass.Text) + "' WHERE employeeID = '" + main.globalEmployeeID + "'");
                }
                else
                {
                    main.SetMessage("PASSWORD LAMA anda Salah!");
                    tbOldPass.Focus();
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbOldPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tbNewPass.Focus();
                tbNewPass.Select(0, 9);
            }
        }

        private void tbNewPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tbNewPass2.Focus();
                tbNewPass2.Select(0, 9);
            }
        }

        private void tbNewPass2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.Focus();
            }
        }
    }
}
