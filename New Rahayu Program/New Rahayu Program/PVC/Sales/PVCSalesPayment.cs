using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;
using Rahayu_Program.Util;

namespace Rahayu_Program.PVC.Sales
{
    public partial class PVCSalesPayment : Form
    {
        //private CreateSalesPVC parent;
        private MainForm main;
        private int total;
        private string paymentMethod;

        public PVCSalesPayment(MainForm main, int total)
        {
            this.main = main;
            this.total = total;

            InitializeComponent();
        }

        private void PVCSalesPayment_Load(object sender, EventArgs e)
        {
            nudTotal.Value = total;
            btnCash2_Click(sender, e);
            nudBayar.Focus();
            nudBayar.Select(0, 9);
        }

        public DataTable ExecuteQuery(string query)
        {
            return main.ExecuteQuery(query);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void nudTotal_Enter(object sender, EventArgs e)
        {
            nudBayar.Focus();
            nudBayar.Select(0, 9);
        }

        private void nudBayar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                btnCancel_Click(sender, e);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (nudBayar.Value == 0)
            {
                Rahayu_Program.DialogBox.AnsBox hutang = new Rahayu_Program.DialogBox.AnsBox(main, "Yakin HUTANG?");
                DialogResult result = hutang.ShowDialog();
                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    btnClose.Visible = true;
                    btnCancel.Visible = false;
                    btnSubmit.Visible = false;
                    nudBayar.ReadOnly = true;
                    nudBayar.TabStop = false;

                    btnCash2.Visible = false;
                    btnDebit2.Visible = false;
                    btnGiro2.Visible = false;
                    btnTransfer2.Visible = false;

                    InsertHeader();
                    InsertDetail();

                    main.PVCSalesPrintReceipt(pvcSalesID);

                    btnClose.Focus();
                }
                else
                {
                    nudBayar.Focus();
                    nudBayar.Select(0, 9);
                }
            }
            else
            {
                btnClose.Visible = true;
                btnCancel.Visible = false;
                btnSubmit.Visible = false;
                nudBayar.ReadOnly = true;
                nudBayar.TabStop = false;

                btnCash2.Visible = false;
                btnDebit2.Visible = false;
                btnGiro2.Visible = false;
                btnTransfer2.Visible = false;

                InsertHeader();
                InsertDetail();
                InsertPayment();

                if (paymentMethod == "CASH")
                {
                    RawPrinterHelper.SendStringToPrinter(@"\\RHY-SERVER-PC\EPSON TM-U220 Receipt", System.Text.ASCIIEncoding.ASCII.GetString(new byte[] { 27, 112, 48, 55, 121 }));
                }

                btnClose.Focus();
                main.PVCSalesPrintReceipt(pvcSalesID);
            }
        }

        public int pvcSalesID;

        private void InsertHeader()
        {
            ExecuteQuery("INSERT INTO PVCSalesHeader (employeeID, customerID, salesTime) VALUES (" + main.globalEmployeeID + ", " + main.globalCustomerID + ", now())");
            DataTable dt = ExecuteQuery("SELECT pvcSalesID FROM PVCSalesHeader ORDER BY pvcSalesID DESC LIMIT 0, 1");
            pvcSalesID = Int32.Parse(dt.Rows[0]["pvcSalesID"].ToString());
        }

        private void InsertDetail()
        {
            //CUMA TRANSFER DARI PAYMENT KE CREATE SALES PVC
            main.PVCCreateSalesAddDetail();
        }

        private void InsertPayment()
        {
            DataTable dt = ExecuteQuery("SELECT pvcPaymentID FROM PVCSalesPayment WHERE pvcSalesID = " + pvcSalesID + " ORDER BY pvcPaymentID DESC LIMIT 0, 1");
            string pvcPaymentID = dt == null ? "0" : dt.Rows.Count == 0 ? "0" : dt.Rows[0]["pvcPaymentID"].ToString();
            pvcPaymentID = (Int32.Parse(pvcPaymentID) + 1) + "";
            int bayar = nudBayar.Value >= nudTotal.Value ? Convert.ToInt32(nudTotal.Value) : Convert.ToInt32(nudBayar.Value);
            ExecuteQuery("INSERT INTO PVCSalesPayment VALUES (" + pvcSalesID + ", " + pvcPaymentID + ", '" + bayar + "', now(), '" + paymentMethod + "', 0)");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void btnCash2_Click(object sender, EventArgs e)
        {
            btnCash2.Visible = false;
            btnDebit2.Visible = true;
            btnGiro2.Visible = true;
            btnTransfer2.Visible = true;
            btnCash.Visible = true;
            btnDebit.Visible = false;
            btnGiro.Visible = false;
            btnTransfer.Visible = false;
            paymentMethod = "CASH";
        }

        private void btnDebit2_Click(object sender, EventArgs e)
        {
            btnCash2.Visible = true;
            btnDebit2.Visible = false;
            btnGiro2.Visible = true;
            btnTransfer2.Visible = true;
            btnCash.Visible = false;
            btnDebit.Visible = true;
            btnGiro.Visible = false;
            btnTransfer.Visible = false;
            paymentMethod = "DEBIT";
        }

        private void btnGiro2_Click(object sender, EventArgs e)
        {
            btnCash2.Visible = true;
            btnDebit2.Visible = true;
            btnGiro2.Visible = false;
            btnTransfer2.Visible = true;
            btnCash.Visible = false;
            btnDebit.Visible = false;
            btnGiro.Visible = true;
            btnTransfer.Visible = false;
            paymentMethod = "GIRO";
        }

        private void btnTransfer2_Click(object sender, EventArgs e)
        {
            btnCash2.Visible = true;
            btnDebit2.Visible = true;
            btnGiro2.Visible = true;
            btnTransfer2.Visible = false;
            btnCash.Visible = false;
            btnDebit.Visible = false;
            btnGiro.Visible = false;
            btnTransfer.Visible = true;
            paymentMethod = "TRANSFER";
        }

        private void nudBayar_KeyDown2(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                btnCancel_Click(sender, e);
            }
            else if (e.KeyCode == Keys.Enter)
            {
                int kembali = Convert.ToInt32(nudBayar.Value - nudTotal.Value);
                nudKembali.Value = kembali <= 0 ? 0 : kembali;
            }
        }

        private void nudBayar_ValueChanged(object sender, EventArgs e)
        {
            int kembali = Convert.ToInt32(nudBayar.Value - nudTotal.Value);
            nudKembali.Value = kembali <= 0 ? 0 : kembali;
        }

        private void nudBayar_Enter(object sender, EventArgs e)
        {
            if (nudBayar.ReadOnly == true)
            {
                btnClose.Focus();
            }
        }

        private void btnClose_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                btnClose_Click(sender, e);
            }
        }

        private void btnCancel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                btnCancel_Click(sender, e);
            }
        }
    }
}
