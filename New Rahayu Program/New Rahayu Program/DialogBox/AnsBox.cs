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
    public partial class AnsBox : Form
    {
        public String MBOX_WARNING = "WARNING!";
        public String MBOX_CONFIRMATION = "CONFIRMATION";
        public String MBOX_ATTENTION = "ATTENTION";

        public AnsBox(MainForm main, String message)
        {
            InitializeComponent();
            textBox1.Text = MBOX_CONFIRMATION;
            textBox2.Text = message;
        }

        public AnsBox(MainForm main, String message, String title)
        {
            InitializeComponent();
            textBox1.Text = title;
            textBox2.Text = message;
        }

        private void MBox_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            close();
        }

        private void close()
        {
            this.Close();
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            button1.Focus();
        }

        private void button2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                button2_Click(sender, e);
            }
        }
    }
}
