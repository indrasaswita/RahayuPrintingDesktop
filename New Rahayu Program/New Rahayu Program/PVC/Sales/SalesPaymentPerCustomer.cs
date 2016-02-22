using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Rahayu_Program.PVC.Sales
{
    public partial class SalesPaymentPerCustomer : Form
    {
        MainForm main;
        int customerID;

        public SalesPaymentPerCustomer(MainForm main, int customerID)
        {
            this.main = main;
            this.customerID = customerID;

            InitializeComponent();
        }

        private void SalesPaymentPerCustomer_Load(object sender, EventArgs e)
        {
            gridPayment.Columns.Add("", "SalesID");
            gridPayment.Columns[0].Width = 52;
            gridPayment.Columns.Add("", "Waktu");
            gridPayment.Columns[1].Width = 115;
            gridPayment.Columns.Add("", "Hutang");
            gridPayment.Columns[2].Width = 100;
            gridPayment.Columns.Add("", "Bayar");
            gridPayment.Columns[3].Width = 77;

            comboBox1.SelectedIndex = 0;
            RefreshHutang();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void RefreshHutang()
        {
            DataTable dt = ExecuteQuery("SELECT pvcSalesID, DATE_FORMAT(salesTime, '%d/%m/%Y %H:%i:%s') AS salesTime, ((SELECT SUM(sellPrice * quantity) FROM PVCSalesDetail WHERE pvcSalesID = a.pvcSalesID) - IFNULL((SELECT SUM(ammount) FROM PVCSalesPayment WHERE a.pvcSalesID = pvcSalesID), 0)) AS hutang FROM PVCSalesHeader a, MsCustomer b WHERE b.customerID = a.customerID AND a.customerID = " + customerID + " AND NOT((SELECT SUM(sellPrice * quantity) FROM PVCSalesDetail WHERE pvcSalesID = a.pvcSalesID) - IFNULL((SELECT SUM(ammount) FROM PVCSalesPayment WHERE a.pvcSalesID = pvcSalesID), 0)) = 0 ORDER BY pvcSalesID ASC");
            if (dt != null)
            {
                gridPayment.Rows.Clear();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    int pvcSalesID = Int32.Parse(dt.Rows[i]["pvcSalesID"].ToString());
                    DateTime salesTime = Other.Parser.TimeFromString(dt.Rows[i]["salesTime"].ToString());
                    int hutang = Convert.ToInt32(Decimal.Parse(dt.Rows[i]["hutang"].ToString()));
                    gridPayment.Rows.Add(pvcSalesID, salesTime.ToString("dd MMM HH:ss"), hutang, "0");
                }
            }
        }

        private DataTable ExecuteQuery(string query)
        {
            return main.ExecuteQuery(query);
        }
    }
}
