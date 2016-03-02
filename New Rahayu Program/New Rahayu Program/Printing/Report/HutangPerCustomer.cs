using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Rahayu_Program.Report;
using CrystalDecisions.Shared;
using Rahayu_Program.Master.Customer;
using System.IO;
using System.Net.Mail;
using System.Net;

namespace Rahayu_Program.Printing.Report
{
    public partial class HutangPerCustomer : Form
    {
        MainForm main;
        int customerID;

        public HutangPerCustomer(MainForm main)
        {
            this.main = main;
            this.MdiParent = main;
            customerID = 0;

            InitializeComponent();
        }

        public HutangPerCustomer(MainForm main, int customerID)
        {
            this.main = main;
            this.MdiParent = main;
            this.customerID = customerID;

            InitializeComponent();
        }

        public void ClearAll()
        {
            filename = "";
            laporan = null;
            tbAttachment.Text = "";
            tbCustomerCompany.Text = "";
            tbCustomerName.Text = "";
            tbCustomerPhone.Text = "";
            tbInsertEmail.Text = "";
            tbJudulEmail.Text = "";
            rtbIsiEmail.Text = "";
            gridAddress.Rows.Clear();
        }

        private void buatLaporanByQuery(object laporan, DateTime startTime, DateTime endTime)
        {
            ReportForm reportForm = new ReportForm(main);
            reportForm.MdiParent = main;
            reportForm.WindowState = FormWindowState.Maximized;

            reportForm.GetCrystalReportViewer().ReportSource = laporan;

            ParameterField field1 = new ParameterField();
            ParameterDiscreteValue value1 = new ParameterDiscreteValue();
            field1.Name = "startTime";
            value1.Value = startTime;
            field1.CurrentValues.Add(value1);

            ParameterField field2 = new ParameterField();
            ParameterDiscreteValue value2 = new ParameterDiscreteValue();
            field2.Name = "endTime";
            value2.Value = endTime;
            field2.CurrentValues.Add(value2);

            ParameterFields fields = new ParameterFields();
            fields.Add(field1);
            fields.Add(field2);

            reportForm.GetCrystalReportViewer().ParameterFieldInfo = fields;
            reportForm.GetCrystalReportViewer().Refresh();
            reportForm.Show();
        }

        Rahayu_Program.Report.PrintingSales.PrintingSalesDebtPerCustomer laporan;
        string filename = "";

        private void setCustomerFromID(int customerID)
        {
            DataTable dd = main.ExecuteQuery("SELECT phone, phone2, email FROM MsCustomer WHERE customerID = '" + customerID + "'");
            if (dd != null)
                if (dd.Rows.Count == 1)
                {
                    string email = dd.Rows[0]["email"].ToString();
                    if (email.Trim() != "")
                        gridAddress.Rows.Add(email);
                    tbCustomerCompany.Text = main.globalCompanyName;
                    tbCustomerName.Text = main.globalCustomerName;
                    tbCustomerPhone.Text = dd.Rows[0]["phone"].ToString() + (dd.Rows[0]["phone2"].ToString().Trim() == "" ? "" : "/" + dd.Rows[0]["phone2"].ToString());
                }
        }

        private void createDebtReport(int customerID)
        {
            string filter = "";
            if (radJatuhTempo.Checked)
            {
                filter = " AND psh.tempo <= now() ";
            }
            else
            {
                filter = "";
            }

            DataTable dt = main.ExecuteQuery("SELECT psh.printingSalesID, salesTime, "
                    + "'' AS customerName, "
                    + "tempo, printingType, printingTitle, jobType, "
                    + "CONCAT(material, '; ', quantity, '; ', quantityType, '; ', sidePrint, ')') AS detail"
                    + ", hargaMaterial, hargaOngkosCetak, hargaAsli, "
                    + "IFNULL((SELECT SUM(ammount) FROM PrintingSalesPayment "
                    + "WHERE printingSalesID = psh.printingSalesID), 0) AS paymentTotal "
                + "FROM PrintingSalesHeader psh "
                    + "JOIN PrintingSalesDetail psd ON psh.printingSalesID = psd.printingSalesID "
                    + "JOIN MsCustomer cu ON cu.customerID = psh.customerID "
                + "WHERE psh.customerID = '" + customerID + "' " + filter
                + "AND hargaAsli > IFNULL((SELECT SUM(ammount) FROM PrintingSalesPayment "
                + "WHERE printingSalesID = psh.printingSalesID), 0)");

            if (dt == null)
            {
                MessageBox.Show("ERROR PRINT REPORT (LAPORAN HUTANG PERCUSTOMER)");
                this.Dispose();
            }
            else
            {
                if (dt.Rows.Count > 0)
                {
                    laporan = new Rahayu_Program.Report.PrintingSales.PrintingSalesDebtPerCustomer();

                    laporan.SetDataSource(dt);
                    filename = @"C:\laporan" + tbCustomerName.Text.Replace(" ", "") + "(" + DateTime.Now.ToString("ddMMyy") + ").pdf";
                    tbAttachment.Text = filename;
                    laporan.SetParameterValue("startTime", DateTime.MinValue);
                    laporan.SetParameterValue("endTime", DateTime.MaxValue);
                    laporan.ExportToDisk(ExportFormatType.PortableDocFormat, filename);

                    rtbIsiEmail.Text = "Kepada Yth.,\nBapak/Ibu " + tbCustomerName.Text + ".\ndi tempat."
                        + "\n\nBerikut ini kami kirimkan data kekurangan bayar untuk transaksi di Rahayu."
                        + "\nTerima kasih atas kerja samanya, kami berharap secepatnya dapat dilunasi."
                        + "\n\nUntuk transfer,"
                        + "\nRekening BCA:"
                        + "\nNO. 419 152 6168"
                        + "\na/n. Wahyuni Saswita";
                }
                else
                {
                    filename = "";
                    MessageBox.Show("CUSTOMER INI TIDAK PUNYA HUTANG BROOO");
                }
            }
        }

        private void btnSearchCustomer_Click(object sender, EventArgs e)
        {
            SearchCustomerPVC searchCust = new SearchCustomerPVC(main);
            DialogResult result = searchCust.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                setCustomerFromID(main.globalCustomerID);
                createDebtReport(main.globalCustomerID);
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            buatLaporanByQuery(laporan, DateTime.MinValue, DateTime.MaxValue);
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (gridAddress.Rows.Count == 0)
            {
                main.SetMessage("Isi dulu alamat emailnya");
            }
            else if(tbJudulEmail.Text.Trim() == "")
            {
                main.SetMessage("Isi judul emailnya");
            }
            else if (!File.Exists(filename))
            {
                main.SetMessage("File attachment tidak ada, tidak ditemukan");
            }
            else
            {
                try
                {
                    //MailMessage mail = new MailMessage();
                    //SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                    //mail.From = new MailAddress("indrasaswita@gmail.com");
                    //mail.To.Add("rahayu_printing@yahoo.co.id");
                    //mail.Subject = "Test Mail";
                    //mail.Body = "This is for testing SMTP mail from GMAIL";

                    //SmtpServer.Port = 587;
                    //SmtpServer.Credentials = new System.Net.NetworkCredential("indrasaswita@gmail.com", "s@swita23");
                    //SmtpServer.EnableSsl = true;

                    //SmtpServer.Send(mail);

                    MailMessage mail = new MailMessage();
                    SmtpClient SmtpServer = new SmtpClient("smtp.mail.yahoo.com");

                    mail.From = new MailAddress("rahayu_printing@yahoo.co.id");
                    foreach (DataGridViewRow i in gridAddress.Rows)
                        mail.To.Add(i.Cells[0].Value.ToString());
                    mail.Subject = tbJudulEmail.Text;
                    mail.Body = rtbIsiEmail.Text;

                    if (tbAttachment.Text != null)
                        mail.Attachments.Add(new Attachment(tbAttachment.Text));

                    SmtpServer.Port = 587;
                    SmtpServer.Credentials = new System.Net.NetworkCredential("rahayu_printing@yahoo.co.id", "layarkaca");
                    SmtpServer.EnableSsl = true;

                    SmtpServer.Send(mail);

                    mail.Dispose(); // kalo ga di dispose, ga bisa di delete filenya..
                }
                catch (Exception ex) { main.SetMessage("error : " + ex.Message); }
            }
        }

        private void HutangPerCustomer_Load(object sender, EventArgs e)
        {
            gridAddress.Columns.Add("", "E-mail Address");
            gridAddress.Columns[0].Width = 343;
            tbJudulEmail.Text = "Kekurangan Pembayaran";

            if (customerID != 0)
            {
                setCustomerFromID(customerID);
                createDebtReport(customerID);
            }
        }

        private void HutangPerCustomer_FormClosed(object sender, FormClosedEventArgs e)
        {
            //delete file
            if (filename != "")
                if (File.Exists(filename))
                    File.Delete(filename);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbInsertEmail.Text.Trim() != "")
                gridAddress.Rows.Add(tbInsertEmail.Text.Trim());
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (gridAddress.Rows.Count != 0)
            {
                int index = gridAddress.CurrentRow.Index;
                if (index >= 0 && index < gridAddress.Rows.Count)
                {
                    gridAddress.Rows.RemoveAt(index);
                }
            }
        }
    }
}
