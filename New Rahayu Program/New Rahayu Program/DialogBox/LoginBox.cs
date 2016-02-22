using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Rahayu_Program.DialogBox
{
    public partial class LoginBox : Form
    {
        private Config.Conn conn;
        private DataTable dt;
        private MainForm main;

        public LoginBox(MainForm main)
        {
            this.main = main;

            InitializeComponent();
            conn = new Config.Conn();
            conn.Connect();
        }


        private void tbPass_Leave(object sender, EventArgs e)
        {
            if (tbPass.Text == "")
            {
                tbPass.PasswordChar = '\0';
                tbPass.Text = "Password";
                tbPass.ForeColor = System.Drawing.Color.FromArgb(0,64, 64, 64);
            }
        }

        private void tbPass_Enter(object sender, EventArgs e)
        {
            
            if (tbPass.Text == "Password")
            {
                tbPass.PasswordChar = '●';
                tbPass.Text = "";
                tbPass.ForeColor = Color.Black;
            }
        }

        private void tbUser_Enter(object sender, EventArgs e)
        {

            if (tbUser.Text == "Username")
            {
                tbUser.Text = "";
                tbUser.ForeColor = Color.Black;
            }
        }

        private void tbUser_Leave(object sender, EventArgs e)
        {
            if (tbUser.Text == "")
            {
                tbUser.Text = "Username";
                tbUser.ForeColor = System.Drawing.Color.FromArgb(0, 64, 64, 64);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //CEK DATABASE
            dt = conn.ExecuteQuery("SELECT * FROM MsEmployee WHERE EmployeeID = '" + tbUser.Text + "' AND Password = '" + Other.Parser.StringToMD5(tbPass.Text) + "'");

            if (dt.Rows.Count == 1)
            {
                main.SetMessage("WELCOME, "+dt.Rows[0]["employeeName"].ToString());
                DialogResult = DialogResult.OK;
                this.Close();
            }
            else if (dt.Rows.Count == 0)
            {
                main.SetMessage("User tidak ditemukan");
                tbUser.Focus();
                tbUser.Select(0, 99);
            }
            else
            {
                main.SetMessage("Double User, coba kontak boy ya!");
                DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        public int Value
        {
            get { return int.Parse(dt.Rows[0]["employeeID"].ToString()); }
        }

        private void tbTitle_Enter(object sender, EventArgs e)
        {
            btnOK.Focus();
        }

        private void tbTitle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                DialogResult = DialogResult.Cancel;
                this.Close();
            }


            if (e.KeyCode == Keys.Enter && tbUser.Focused == true)
            {
                if (tbUser.Text != "Username" && tbPass.Text != "Password")
                {
                    tbPass.Focus();// button1_Click(sender, e);
                    tbPass.SelectAll();
                }
                else tbPass.Focus();
            }
            else if (e.KeyCode == Keys.Enter && tbPass.Focused == true)
            {
                if (tbUser.Text != "Username" && tbPass.Text != "Password") button1_Click(sender, e);
                else btnOK.Focus();
            }
        }

        private void tbUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginBox_Load(object sender, EventArgs e)
        {
            tbUser.Focus();
        }

    }
}
