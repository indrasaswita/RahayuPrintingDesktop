using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Rahayu_Program.Stationery.Sales
{
    public partial class PaymentForm : Form
    {
        private MainForm main;
        private int total;

        public PaymentForm(MainForm main, int total)
        {
            this.main = main;
            this.total = total;

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //PRINT RECEIPT
            main.StationerySalesPrintReceipt(Convert.ToInt32(nudBayar.Value));

            btnOK.Visible = false;
            btnOK.Enabled = false;
            btnCancel.Visible = false;
            btnCancel.Enabled = false;
            btnClose.Visible = true;
            btnClose.Enabled = true;
            this.AcceptButton = btnClose;
        }

        private void PaymentForm_Load(object sender, EventArgs e)
        {
            btnOK.Visible = true;
            btnOK.Enabled = true;
            btnClose.Visible = false;
            btnClose.Enabled = false;
            btnCancel.Visible = true;
            btnCancel.Enabled = true;
            this.AcceptButton = btnOK;

            nudBayar.Minimum = total;

            nudHargaTotal.Value = total;
            nudBayar.Value = total;
            nudKembali.Value = nudBayar.Value - nudHargaTotal.Value;
            nudBayar.Focus();
            nudBayar.Select(0, 9);
        }

        private void nudBayar_ValueChanged(object sender, EventArgs e)
        {
            nudKembali.Value = nudBayar.Value - nudHargaTotal.Value;
        }

        private void nudHargaTotal_Enter(object sender, EventArgs e)
        {
            nudBayar.Focus();
            nudBayar.Select(0, 9);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void nudBayar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                btnCancel_Click(sender, e);
            }
            else if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}
