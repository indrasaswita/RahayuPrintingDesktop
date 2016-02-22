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
    public partial class SupervisorForm : Form
    {
        private MainForm main;

        public SupervisorForm(MainForm main)
        {
            this.main = main;

            InitializeComponent();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBox1.Text.ToLower() == "jumps over")
                {
                    DialogResult = System.Windows.Forms.DialogResult.OK;
                    this.Close();
                }
                else
                {
                    DialogResult = System.Windows.Forms.DialogResult.Cancel;
                    this.Close();
                }
            }
            else if (e.KeyCode == Keys.Escape)
            {
                DialogResult = System.Windows.Forms.DialogResult.Cancel;
                this.Close();
            }
        }

        private void SupervisorForm_Load(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
    }
}
