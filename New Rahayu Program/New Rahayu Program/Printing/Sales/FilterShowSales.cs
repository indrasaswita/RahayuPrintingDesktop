using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Rahayu_Program.Printing.Sales
{
    public partial class FilterShowSales : Form
    {
        MainForm main;
        string query = "SELECT psh.printingSalesID, mcu.customerID, mcu.customerName, mco.companyName, DATE_FORMAT(psh.salesTime, '%d/%m/%Y %H:%i:%s') AS salesTime, psh.status, (SELECT SUM(hargaMaterial + hargaOngkosCetak) FROM PrintingSalesDetail WHERE printingSalesID = psh.printingSalesID) as total, IFNULL((SELECT SUM(ammount) FROM PrintingSalesPayment WHERE printingSalesID = psh.printingSalesID), 0) as bayar FROM PrintingSalesHeader psh JOIN MsCustomer mcu ON psh.customerID = mcu.customerID JOIN MsCompany mco ON mcu.companyID = mco.companyID WHERE psh.salesTime > DATE_SUB(now(), INTERVAL 6 MONTH) ";
        string lunasY = " AND IFNULL((SELECT SUM(ammount) FROM PrintingSalesPayment psp WHERE psp.printingSalesID = psh.printingSalesID), 0) >= IFNULL((SELECT SUM(hargaMaterial + hargaOngkosCetak) FROM PrintingSalesDetail psd WHERE psd.printingSalesID = psh.printingSalesID), 0) ";
        string lunasX = " AND IFNULL((SELECT SUM(ammount) FROM PrintingSalesPayment psp WHERE psp.printingSalesID = psh.printingSalesID), 0) < IFNULL((SELECT SUM(hargaMaterial + hargaOngkosCetak) FROM PrintingSalesDetail psd WHERE psd.printingSalesID = psh.printingSalesID), 0) ";
        string tempoY = " AND tempo < now() ";
        string tempoX = " AND tempo >= now() ";

        public FilterShowSales(MainForm main)
        {
            this.main = main;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            main.globalQuery = query + (ckbJatuhTempo.Checked ? tempoY : tempoX) + (ckbLunas.Checked ? lunasY : lunasX) + " ORDER BY psh.printingSalesID DESC ";
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
    }
}
