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
    public partial class StationeryCashierForm : Form
    {
        MainForm main;

        public StationeryCashierForm(MainForm main)
        {
            this.main = main;
            InitializeComponent();
        }

        private DataTable ExecuteQuery(string query)
        {
            return main.ExecuteQuery(query);
        }

        private void tbPass_KeyDown(object sender, KeyEventArgs e)
        {
            DataTable dt = ExecuteQuery("SELECT password FROM MsEmployee WHERE employeeID = 9");
            if (dt != null)
            {
                if (dt.Rows.Count == 1)
                {
                    string pass = dt.Rows[0]["password"].ToString();
                    if (e.KeyCode == Keys.Enter)
                        if (Util.Converter.MD5Hash(tbPass.Text) == pass)
                            DialogResult = System.Windows.Forms.DialogResult.OK;
                        else ;
                    else if (e.KeyCode == Keys.Escape)
                        DialogResult = System.Windows.Forms.DialogResult.Cancel;
                }
            }
        }

        private void StationeryCashierForm_Load(object sender, EventArgs e)
        {

        }
    }
}
