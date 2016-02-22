using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Rahayu_Program.Util;

namespace Rahayu_Program.PVC.Sales
{
    public partial class ViewSalesPVCCreatePayment : Form
    {
        private MainForm main;
        private int setPVCSalesID, totalBeli;
        private string paymentMethod;
        
        public ViewSalesPVCCreatePayment(MainForm main, int setPVCSalesID, int totalBeli)
        {
            this.main = main;
            this.setPVCSalesID = setPVCSalesID;
            this.totalBeli = totalBeli;
            result = System.Windows.Forms.DialogResult.Cancel;
            paymentMethod = "";

            InitializeComponent();
        }

        public DataTable ExecuteQuery(string query)
        {
            return main.ExecuteQuery(query);
        }

        private void ViewSalesPVCCreatePayment_Load(object sender, EventArgs e)
        {
            gridPayment.Columns.Clear();
            gridPayment.Columns.Add("", "ID");
            gridPayment.Columns[0].Width = 40;
            gridPayment.Columns.Add("", "Waktu");
            gridPayment.Columns[1].Width = 115;
            gridPayment.Columns.Add("", "Jumlah");
            gridPayment.Columns[2].Width = 100;
            gridPayment.Columns.Add("", "VIA");
            gridPayment.Columns[3].Width = 77;

            foreach (DataGridViewColumn column in gridPayment.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            DataTable dt = ExecuteQuery("SELECT pvcPaymentID, ammount, DATE_FORMAT(paymentTime, '%d/%m/%Y %H:%i:%s') AS paymentTime, paymentMethod FROM PVCSalesPayment WHERE pvcSalesID = " + setPVCSalesID + "");
            gridPayment.Rows.Clear();
            int totalBayar = 0;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string pvcPaymentID = dt.Rows[i]["pvcPaymentID"].ToString();
                int ammount = Int32.Parse(dt.Rows[i]["ammount"].ToString());
                DateTime paymentTime = Other.Parser.TimeFromString(dt.Rows[i]["paymentTime"].ToString());
                string paymentMethod = dt.Rows[i]["paymentMethod"].ToString();
                gridPayment.Rows.Add(pvcPaymentID, paymentTime.ToString("dd MMM HH:mm"), ammount, paymentMethod);
                totalBayar += ammount;
            }
            nudBayar.Value = totalBayar < 0 ? 0 : totalBayar;
            int hutang = totalBeli - totalBayar;
            tbHutang.Text = hutang <= 0 ? "LUNAS" : hutang.ToString("#,##0");
            if (tbHutang.Text == "LUNAS")
            {
                nudSisaBayar.Value = 0;
                tbHutang.TextAlign = HorizontalAlignment.Center;
            }
            else
            {
                nudSisaBayar.Value = hutang;
                tbHutang.TextAlign = HorizontalAlignment.Right;
            }
        }

        private void numericUpDown1_Enter(object sender, EventArgs e)
        {
            nudJumlahBayar.Focus();
            nudJumlahBayar.Select(0, 9);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = result;
        }

        private void nudSisaBayar_ValueChanged(object sender, EventArgs e)
        {
            nudJumlahBayar.Maximum = nudSisaBayar.Value;
        }

        DialogResult result;

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (nudJumlahBayar.Value == 0)
            {
                main.SetMessage("Bayar tidak boleh 0");
                nudBayar.Focus();
                nudBayar.Select(0, 9);
            }
            else if (paymentMethod == "")
            {
                main.SetMessage("Metode harus dipilih");
                nudBayar.Focus();
                nudBayar.Select(0, 9);
            }
            else
            {
                DataTable dt = ExecuteQuery("SELECT pvcPaymentID FROM PVCSalesPayment WHERE pvcSalesID = " + setPVCSalesID + " ORDER BY pvcPaymentID DESC LIMIT 0, 1");
                string pvcPaymentID = dt == null ? "0" : dt.Rows.Count == 0 ? "0" : dt.Rows[0]["pvcPaymentID"].ToString();
                pvcPaymentID = (Int32.Parse(pvcPaymentID) + 1) + "";
                int bayar = Convert.ToInt32(nudJumlahBayar.Value);
                //MessageBox.Show("INSERT INTO PVCSalesPayment VALUES (" + setPVCSalesID + ", " + pvcPaymentID + ", '" + bayar + "', now(), '" + paymentMethod + "', 0)");
                ExecuteQuery("INSERT INTO PVCSalesPayment VALUES (" + setPVCSalesID + ", " + pvcPaymentID + ", '" + bayar + "', now(), '" + paymentMethod + "', 0)");

                if (paymentMethod == "CASH")
                {
                    RawPrinterHelper.SendStringToPrinter(@"\\RHY-SERVER-PC\EPSON TM-U220 Receipt", System.Text.ASCIIEncoding.ASCII.GetString(new byte[] { 27, 112, 48, 55, 121 }));
                }

                result = System.Windows.Forms.DialogResult.OK;

                nudJumlahBayar.Value = 0;
                ClearButtonBack();
                paymentMethod = "";
                ViewSalesPVCCreatePayment_Load(sender, e);
            }
        }

        private void ClearButtonBack()
        {
            btnCash.BackColor = Color.DimGray;
            btnDebit.BackColor = Color.DimGray;
            btnGiro.BackColor = Color.DimGray;
            btnTransfer.BackColor = Color.DimGray;
        }

        private void btnCash_Click(object sender, EventArgs e)
        {
            ClearButtonBack();
            paymentMethod = "CASH";
            btnCash.BackColor = Color.DeepPink;
        }

        private void btnDebit_Click(object sender, EventArgs e)
        {
            ClearButtonBack();
            paymentMethod = "DEBIT";
            btnDebit.BackColor = Color.DeepPink;
        }

        private void btnGiro_Click(object sender, EventArgs e)
        {
            ClearButtonBack();
            paymentMethod = "GIRO";
            btnGiro.BackColor = Color.DeepPink;
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            ClearButtonBack();
            paymentMethod = "TRANSFER";
            btnTransfer.BackColor = Color.DeepPink;
        }
    }
}
