using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Rahayu_Program.DialogBox;
using System.Net.Sockets;

namespace Rahayu_Program.Printing.Sales
{
    public partial class CreateSalesPayment : Form
    {
        MainForm main;
        int salesID;
        int hargaAsli;
        int hargaPalsu;

        public CreateSalesPayment(MainForm main, int salesID, int hargaAsli, int hargaPalsu)
        {
            this.main = main;
            this.salesID = salesID;
            this.hargaAsli = hargaAsli;
            this.hargaPalsu = hargaPalsu;

            InitializeComponent();
        }

        public DataTable ExecuteQuery(string query)
        {
            return main.ExecuteQuery(query);
        }

        private void CreateSalesPayment_Load(object sender, EventArgs e)
        {
            tbViewSalesID.Text = "No. Nota : " + String.Format("{0:D10}", salesID);
            nudHargaAsli.Value = hargaAsli;
            nudHargaPalsu.Value = hargaPalsu;
            nudPembayaran.Focus();
            nudPembayaran.Select(0, 9);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (method == "" && nudPembayaran.Value != 0)
            {
                MsgBox temp = new MsgBox(main, "Pilih metode pembayaran! Wajib tepat!");
                temp.ShowDialog();
            }
            else
            {
                if (nudPembayaran.Value == 0)
                {
                    AnsBox hutang = new AnsBox(main, "Tidak melakukan pembayaran?");
                    DialogResult result = hutang.ShowDialog();
                    if (result == System.Windows.Forms.DialogResult.OK)
                    {
                        DialogResult = System.Windows.Forms.DialogResult.OK;
                    }
                    else
                    {
                        nudPembayaran.Focus();
                        nudPembayaran.Select(0, 9);
                    }
                }
                else
                {
                    DataTable dt = ExecuteQuery("SELECT paymentID FROM PrintingSalesPayment WHERE printingSalesID = '" + salesID + "' ORDER BY paymentID DESC LIMIT 0, 1");
                    int paymentID = (dt != null) ? (dt.Rows.Count == 1) ? (Int32.Parse(dt.Rows[0]["paymentID"].ToString()) + 1) : 1 : 1;
                    ExecuteQuery("INSERT INTO PrintingSalesPayment VALUES ('" + salesID + "', '" + paymentID + "', now(), '" + nudPembayaran.Value + "', '" + nudPembayaran2.Value + "', '', '" + method + "', '')");

                    if (method == "CASH")
                    {
                        ConnPrintingCashDrawer();
                        OpenPrintingCashDrawer();
                        ClosePrintingCashDrawer();
                    }

                    DialogResult = System.Windows.Forms.DialogResult.OK;
                }
            }
        }

        System.Net.Sockets.TcpClient clientSocket = new System.Net.Sockets.TcpClient();

        private void ConnPrintingCashDrawer()
        {

            clientSocket.Connect(@"RHY-INDRA-PC", 8888);
        }

        private void ClosePrintingCashDrawer()
        {
            clientSocket.Close();
        }

        private void OpenPrintingCashDrawer()
        {
            NetworkStream serverStream = clientSocket.GetStream();
            byte[] outStream = System.Text.Encoding.ASCII.GetBytes("BUKA" + "$");
            serverStream.Write(outStream, 0, outStream.Length);
            serverStream.Flush();

            byte[] inStream = new byte[10025];
            serverStream.Read(inStream, 0, (int)clientSocket.ReceiveBufferSize);
            /*string returndata = System.Text.Encoding.ASCII.GetString(inStream);
            msg(returndata);*/
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void nudPembayaran_ValueChanged(object sender, EventArgs e)
        {
            Decimal selisih = nudPembayaran.Value - nudHargaAsli.Value;
            nudKembali.Value = selisih < 0 ? 0 : selisih;
            nudPembayaran2.Minimum = nudPembayaran.Value;
        }

        string method = "";

        private void btnCash_Click(object sender, EventArgs e)
        {
            method = "CASH";
            btnCash.BackColor = Color.GreenYellow;
            btnDebit.BackColor = Color.Gainsboro;
            btnTransfer.BackColor = Color.Gainsboro;
            btnGiro.BackColor = Color.Gainsboro;
        }

        private void btnDebit_Click(object sender, EventArgs e)
        {
            method = "DEBIT";
            btnCash.BackColor = Color.Gainsboro;
            btnDebit.BackColor = Color.GreenYellow;
            btnTransfer.BackColor = Color.Gainsboro;
            btnGiro.BackColor = Color.Gainsboro;
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            method = "TRANSFER";
            btnCash.BackColor = Color.Gainsboro;
            btnDebit.BackColor = Color.Gainsboro;
            btnTransfer.BackColor = Color.GreenYellow;
            btnGiro.BackColor = Color.Gainsboro;
        }

        private void btnGiro_Click(object sender, EventArgs e)
        {
            method = "GIRO";
            btnCash.BackColor = Color.Gainsboro;
            btnDebit.BackColor = Color.Gainsboro;
            btnTransfer.BackColor = Color.Gainsboro;
            btnGiro.BackColor = Color.GreenYellow;
        }

        private void tbViewSalesID_Enter(object sender, EventArgs e)
        {
            nudPembayaran.Focus();
            nudPembayaran.Select(0, 99);
        }

        private void nudHargaPalsu_ValueChanged(object sender, EventArgs e)
        {
            nudPembayaran2.Maximum = nudHargaPalsu.Value;
        }

        private void btnLunas_Click(object sender, EventArgs e)
        {
            nudPembayaran.Value = nudHargaAsli.Value;
            nudPembayaran2.Value = nudHargaPalsu.Value;
        }
    }
}
