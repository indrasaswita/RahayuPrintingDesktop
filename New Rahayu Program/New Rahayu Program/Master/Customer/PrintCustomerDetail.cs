using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace Rahayu_Program.Master.Customer
{
    public partial class PrintCustomerDetail : Form
    {
        int customerID;
        MainForm main;

        public PrintCustomerDetail(MainForm main, int customerID)
        {
            this.main = main;
            this.customerID = customerID;

            InitializeComponent();
        }

        public DataTable ExecuteQuery(string query)
        {
            return main.ExecuteQuery(query);
        }

        private void PrintCustomerDetail_Load(object sender, EventArgs e)
        {
            DataTable dt = ExecuteQuery("SELECT companyName, aliases, mco.phone as coPhone, mco.phone2 as coPhone2, mco.address as coAdd, customerName, mcu.phone as cuPhone, mcu.phone2 as cuPhone2, mcu.address as cuAdd FROM MsCustomer mcu JOIN MsCompany mco ON mco.companyID = mcu.companyID WHERE customerID = '" + customerID + "'");

            if (dt != null)
            {
                if (dt.Rows.Count == 1)
                {
                    string companyName = dt.Rows[0]["companyName"].ToString();
                    string aliases = dt.Rows[0]["aliases"].ToString();
                    string coPhone = dt.Rows[0]["coPhone"].ToString();
                    string coPhone2 = dt.Rows[0]["coPhone2"].ToString();
                    string coAdd = dt.Rows[0]["coAdd"].ToString();
                    string customerName = dt.Rows[0]["customerName"].ToString();
                    string cuPhone = dt.Rows[0]["cuPhone"].ToString();
                    string cuPhone2 = dt.Rows[0]["cuPhone2"].ToString();
                    string cuAdd = dt.Rows[0]["cuAdd"].ToString();

                    tbNamaCompany.Text = companyName + (aliases != "" ? "(" + aliases + ")" : "");
                    tbPhoneCompany.Text = coPhone == "" ? (coPhone2 == "" ? "" : coPhone2) : (coPhone + (coPhone2 == "" ? "" : "/" + coPhone2));
                    tbAddCompany.Text = coAdd;

                    tbNamaCustomer.Text = customerName;
                    tbPhoneCustomer.Text = cuPhone == "" ? (cuPhone2 == "" ? "" : cuPhone2) : (cuPhone + (cuPhone2 == "" ? "" : "/" + cuPhone2));
                    tbAddCustomer.Text = cuAdd;
                }
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(printPage);
            pd.PrinterSettings.PrinterName = @"\\RHY-SERVER-PC\EPSON TM-U220 Receipt";
            pd.PrintController = new StandardPrintController();

            try
            {
                pd.Print();
            }
            catch (Exception ex)
            {
                if (ex.Message == "Settings to access printer '" + pd.PrinterSettings.PrinterName + "' are not valid.")
                {
                    MessageBox.Show("Printer IS NOT INSTALLED YET");
                }
                else
                    MessageBox.Show(ex.Message);
            }
        }

        private void printPage(object o, PrintPageEventArgs e)
        {
            Util.PrintingDetailCustomer.printDetailCustomer(e.Graphics, new Font("Courier New", 11, FontStyle.Regular), tbNamaCompany.Text, tbPhoneCompany.Text, tbAddCompany.Text, tbNamaCustomer.Text, tbPhoneCustomer.Text, tbAddCustomer.Text);
        }
    }
}
