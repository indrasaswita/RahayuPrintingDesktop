using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Rahayu_Program.Printing.Sales.SubSales
{
    public partial class ChangePaymentSalesPrinting : Form
    {
        int printingSalesID;
        int paymentID;
        DateTime paymentTime;
        int ammount, ammount2;
        string method;
        MainForm main;

        public ChangePaymentSalesPrinting(MainForm main, int printingSalesID, int paymentID, DateTime paymentTime, int ammount, int ammount2, string method)
        {
            this.main = main;
            this.paymentID = paymentID;
            this.printingSalesID = printingSalesID;
            this.paymentTime = paymentTime;
            this.ammount = ammount;
            this.ammount2 = ammount2;
            this.method = method;

            InitializeComponent();
        }

        public DataTable ExecuteQuery(string query)
        {
            return main.ExecuteQuery(query);
        }

        private void ChangePaymentSalesPrinting_Load(object sender, EventArgs e)
        {
            tbSalesID.Text = string.Format("{0:D10}", printingSalesID);
            tbPaymentID.Text = String.Format("{0:D2}", paymentID);
            dtpPaymentTime.Value = paymentTime;
            nudAmmount.Value = ammount;
            nudAmmount2.Value = ammount2;
            cbMethod.SelectedItem = method;
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            ExecuteQuery("UPDATE PrintingSalesPayment SET paymentTime = '" + dtpPaymentTime.Value.ToString("yyyy-MM-dd HH:mm") + "', ammount = '" + nudAmmount.Value + "', ammount2 = '" + nudAmmount2.Value + "', method = '" + cbMethod.SelectedItem + "' WHERE printingSalesID = '" + tbSalesID.Text + "' AND paymentID = '" + tbPaymentID.Text + "'");
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void tbSalesID_Enter(object sender, EventArgs e)
        {
            dtpPaymentTime.Focus();
        }
    }
}
