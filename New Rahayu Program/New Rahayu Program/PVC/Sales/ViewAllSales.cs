using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Rahayu_Program.Report;

namespace Rahayu_Program.PVC.Sales
{
    public partial class ViewAllSales : Form
    {
        MainForm main;
        List<ViewSalesPVCList> detail;
        Master.Customer.SearchCustomerPVC searchCust;
        int setCustomerID, customerID;
        string setCustomerName;
        DialogBox.SupervisorForm super;

        int setPVCSalesID;
        public PVCSalesUpdateDetail updateDetail;

        public ViewAllSales(MainForm main)
        {
            this.main = main;
            this.MdiParent = main;
            detail = new List<ViewSalesPVCList>();
            searchCust = new Master.Customer.SearchCustomerPVC(main);
            super = new DialogBox.SupervisorForm(main);

            InitializeComponent();
        }

        private void ViewAllSales_Load(object sender, EventArgs e)
        {
            gridHeader.Columns.Clear();
            gridHeader.Columns.Add("", "ID");
            gridHeader.Columns[0].Width = 52;
            gridHeader.Columns.Add("", "Waktu");
            gridHeader.Columns[1].Width = 115;
            gridHeader.Columns.Add("", "Cust");
            gridHeader.Columns[2].Visible = false;
            gridHeader.Columns.Add("", "Cust");
            gridHeader.Columns[3].Width = 90;
            gridHeader.Columns.Add("", "Hutang");
            gridHeader.Columns[4].Width = 100;

            foreach (DataGridViewColumn column in gridHeader.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

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

            detail.Clear();
            panelDetail.Controls.Clear();
             
            count = 0;
        }

        public DataTable ExecuteQuery(string query)
        {
            return main.ExecuteQuery(query);
        }

        private void RefreshHeader()
        {
            tbSearch.Text = "";
            RefreshHeader("");
        }

        private void RefreshHeader(string custName)
        {
            DataTable dt = ExecuteQuery("SELECT a.pvcSalesID, DATE_FORMAT(salesTime, '%d/%m/%Y %H:%i:%s') AS salesTime, a.customerID, customerName, IFNULL(((SELECT SUM(sellPrice * quantity) FROM PVCSalesDetail WHERE pvcSalesID = a.pvcSalesID) - IFNULL((SELECT SUM(ammount) FROM PVCSalesPayment WHERE a.pvcSalesID = pvcSalesID), 0)), 0) AS hutang FROM PVCSalesHeader a, MsCustomer b WHERE b.customerID = a.customerID AND customerName LIKE '%" + custName + "%' ORDER BY pvcSalesID ASC");
            RefreshHeaderUI(dt);
            setCustomerName = custName;
            setCustomerID = 0;
        }

        private void RefreshHeaderUI(DataTable dt)
        {
            gridHeader.Rows.Clear();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string time = dt.Rows[i]["salesTime"].ToString();
                DateTime temp = Rahayu_Program.Other.Parser.TimeFromString(time);
                gridHeader.Rows.Add(dt.Rows[i]["pvcSalesID"].ToString(), temp.ToString("dd MMM HH:mm"), dt.Rows[i]["customerID"].ToString(), dt.Rows[i]["customerName"].ToString(), Convert.ToInt32(Decimal.Parse(dt.Rows[i]["hutang"].ToString())).ToString("#,##0"));
            }

            gridHeader.CurrentCell = gridHeader.Rows[gridHeader.Rows.Count - 1].Cells[0];
            GridHeaderSelectionChanged();
        }

        private void RefreshHeader(int customerID)
        {
            DataTable dt = ExecuteQuery("SELECT a.pvcSalesID, salesTime, a.customerID, customerName, ((SELECT SUM(sellPrice * quantity) FROM PVCSalesDetail WHERE pvcSalesID = a.pvcSalesID) - IFNULL((SELECT SUM(ammount) FROM PVCSalesPayment WHERE a.pvcSalesID = pvcSalesID), 0)) AS hutang FROM PVCSalesHeader a, MsCustomer b WHERE b.customerID = a.customerID AND a.customerID = " + customerID + " ORDER BY pvcSalesID ASC");
            RefreshHeaderUI(dt);
            setCustomerName = "";
            setCustomerID = customerID;
            tbSearch.Text = "";
        }

        private void btnGoToBottom_Click(object sender, EventArgs e)
        {
            if (gridHeader.Rows.Count > 0)
            {
                gridHeader.CurrentCell = gridHeader.Rows[gridHeader.Rows.Count - 1].Cells[0];
                GridHeaderSelectionChanged();
            }
        }

        private void btnGoToTop_Click(object sender, EventArgs e)
        {
            if (gridHeader.Rows.Count > 0)
            {
                gridHeader.CurrentCell = gridHeader.Rows[0].Cells[0];
                GridHeaderSelectionChanged();
            }
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            RefreshHeader(tbSearch.Text);
        }

        private void RefreshDetail()
        {
            panelDetail.Controls.Clear();
            for (int i = 0; i < detail.Count; i++)
            {
                detail[i].Location = new Point(1, 1 + (i * (detail[i].Height + 1)));
                panelDetail.Controls.Add(detail[i]);
            }
        }

        ViewSalesPVCList dTemp;
        
        private void GridHeaderSelectionChanged()
        {
            int index = gridHeader.CurrentRow.Index;
            if (index >= 0 && index < gridHeader.Rows.Count)
            {
                //REFRESH DETAIL
                setPVCSalesID = Int32.Parse(gridHeader.Rows[index].Cells[0].Value.ToString());
                customerID = Int32.Parse(gridHeader.Rows[index].Cells[2].Value.ToString());
                DataTable dt = ExecuteQuery("SELECT mp.pvcName, psd.quantity, mp.pvcPerPack, psd.sellPrice FROM PVCSalesDetail psd, MsPVC mp WHERE psd.pvcID = mp.pvcID AND pvcSalesID = " + setPVCSalesID + " ORDER BY pvcTypeID, mp.pvcID");
                
                //DETAIL CLEAR
                if (count > 100)
                {
                    Point location = panelDetail.Location;
                    Size size = panelDetail.Size;
                    Color bg = panelDetail.BackColor;

                    this.Controls.Remove(panelDetail);
                    panelDetail.Dispose();
                    panelDetail = new Panel();

                    panelDetail.Location = location;
                    panelDetail.Size = size;
                    panelDetail.BackColor = bg;
                    panelDetail.AutoScroll = true;

                    this.Controls.Add(panelDetail);
                    count = 0;
                }
                panelDetail.Controls.Clear();
                detail.Clear();

                int totalBeli = 0;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string pvcName = dt.Rows[i]["pvcName"].ToString();
                    decimal qty = Decimal.Parse(dt.Rows[i]["quantity"].ToString());
                    decimal perPack = Decimal.Parse(dt.Rows[i]["pvcPerPack"].ToString());
                    int sellPrice = Int32.Parse(dt.Rows[i]["sellPrice"].ToString());

                    dTemp = new ViewSalesPVCList(this, pvcName, qty, perPack, sellPrice);
                    detail.Add(dTemp);
                    totalBeli += Convert.ToInt32(qty * sellPrice);
                    count++;
                }
                RefreshDetail();
                nudTotal.Value = totalBeli < 0 ? 0 : totalBeli;

                //REFRESH PAYMENT
                RefreshPaymentBySalesID(setPVCSalesID);

                //REFRESH HEADER
                dt = ExecuteQuery("SELECT a.customerID, (SELECT customerName FROM MsCustomer WHERE a.customerID = customerID) AS customerName, SUM((SELECT SUM(sellPrice * quantity) FROM PVCSalesDetail WHERE pvcSalesID = a.pvcSalesID) - IFNULL((SELECT SUM(ammount) FROM PVCSalesPayment WHERE a.pvcSalesID = pvcSalesID), 0)) AS hutang, phone FROM PVCSalesHeader a, MsCustomer mc WHERE a.customerID = mc.customerID AND a.customerID = " + customerID + " GROUP BY a.customerID");
                main.globalCustomerID = Int32.Parse(dt.Rows[0]["customerID"].ToString());
                tbCustomerName.Text = dt.Rows[0]["customerName"].ToString();
                tbTotalHutang.Text = Decimal.Parse(dt.Rows[0]["hutang"].ToString()).ToString("#,##0");
                tbPhone.Text = dt.Rows[0]["phone"].ToString();
            }
        }

        private void gridHeader_SelectionChanged(object sender, EventArgs e)
        {
            GridHeaderSelectionChanged();
        }

        private void btnShowCustomer_Click(object sender, EventArgs e)
        {

        }

        private void btnSearchCustomer_Click(object sender, EventArgs e)
        {
            DialogResult result = searchCust.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                RefreshHeader(main.globalCustomerID);
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            RefreshHeader();
        }

        private void tbHutang_TextChanged(object sender, EventArgs e)
        {
            if (tbHutang.Text == "LUNAS")
            {
                btnBayar.Enabled = false;
                btnBayar2.Visible = true;
            }
            else
            {
                btnBayar.Enabled = true;
                btnBayar2.Visible = false;
            }
        }

        int count;

        SalesPaymentPerCustomer paymentCustomer;

        private void btnPayPerCustomer_Click(object sender, EventArgs e)
        {
            paymentCustomer = new SalesPaymentPerCustomer(main, customerID);
            paymentCustomer.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnDeleteHeader_Click(object sender, EventArgs e)
        {
            if (gridHeader.Rows.Count > 0)
            {
                DialogResult res = MessageBox.Show("Yakin Mau Delete?", "Confirmation", MessageBoxButtons.OKCancel);
                if (res == System.Windows.Forms.DialogResult.OK)
                {
                    if (main.GetLevel() < 4)
                    {
                        //CUMA BOLEH ADMIN + ADANG
                        DeleteSelectedHeader();
                    }
                    else
                    {
                        super.ShowDialog();
                        if (super.DialogResult == System.Windows.Forms.DialogResult.OK)
                        {
                            DeleteSelectedHeader();
                        }
                    }
                }
            }
        }

        private void DeleteSelectedHeader()
        {
            int index = gridHeader.CurrentRow.Index;
            if (index >= 0 && index < gridHeader.Rows.Count)
            {
                ExecuteQuery("DELETE FROM PVCSalesHeader WHERE pvcSalesID = " + setPVCSalesID + "");
                ExecuteQuery("DELETE FROM PVCSalesDetail WHERE pvcSalesID = " + setPVCSalesID + "");
                ExecuteQuery("DELETE FROM PVCSalesPayment WHERE pvcSalesID = " + setPVCSalesID + "");
            }
        }

        private void btnDeletePayment_Click(object sender, EventArgs e)
        {
            if (gridHeader.Rows.Count > 0)
            {
                DialogResult res = MessageBox.Show("Yakin Mau Delete?", "Confirmation", MessageBoxButtons.OKCancel);
                if (res == System.Windows.Forms.DialogResult.OK)
                {
                    if (main.GetLevel() < 4)
                    {
                        //CUMA BOLEH ADMIN + ADANG
                        DeleteSelectedPayment();
                    }
                    else
                    {
                        super.ShowDialog();
                        if (super.DialogResult == System.Windows.Forms.DialogResult.OK)
                        {
                            DeleteSelectedPayment();
                        }
                    }
                }
            }
        }

        private void DeleteSelectedPayment()
        {
            int index = gridHeader.CurrentRow.Index;
            if (index >= 0 && index < gridHeader.Rows.Count)
            {
                index = gridPayment.CurrentRow.Index;
                if (index >= 0 && index < gridPayment.Rows.Count)
                {
                    int paymentID = Int32.Parse(gridPayment.Rows[index].Cells[0].Value.ToString());
                    DeletePaymentByID(setPVCSalesID, paymentID);
                }
            }
        }

        private void DeletePaymentByID(int salesID, int paymentID)
        {
            ExecuteQuery("DELETE FROM PVCSalesPayment WHERE pvcSalesID = " + salesID + " AND pvcPaymentID = "+paymentID+"");
            RefreshPaymentBySalesID(salesID);
        }

        private void RefreshPaymentBySalesID(int salesID)
        {
            DataTable dt = ExecuteQuery("SELECT pvcPaymentID, ammount, DATE_FORMAT(paymentTime, '%d/%m/%Y %H:%i:%s') AS paymentTime, paymentMethod FROM PVCSalesPayment WHERE pvcSalesID = " + salesID + "");
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
            int hutang = Convert.ToInt32(nudTotal.Value) - totalBayar;
            tbHutang.Text = hutang <= 0 ? "LUNAS" : hutang.ToString("#,##0");
            if (tbHutang.Text == "LUNAS")
            {
                tbHutang.TextAlign = HorizontalAlignment.Center;
            }
            else
            {
                tbHutang.TextAlign = HorizontalAlignment.Right;
            }
        }

        private void btnBayar_Click(object sender, EventArgs e)
        {
            ViewSalesPVCCreatePayment payment = new ViewSalesPVCCreatePayment(main, setPVCSalesID, Convert.ToInt32(nudTotal.Value));
            DialogResult result = payment.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                RefreshPaymentBySalesID(setPVCSalesID);
                gridHeader.Rows[gridHeader.CurrentRow.Index].Cells[4].Value = tbHutang.Text == "LUNAS" ? "0" : tbHutang.Text;
            }
        }

        private void btnTransferPVC_Click(object sender, EventArgs e)
        {

        }

        private void btnCreateSales_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (main.createSalesPVC == null) main.createSalesPVC = new Rahayu_Program.PVC.Sales.CreateSalesPVC(main);
            main.createSalesPVC.Show();
        }

        private void ViewAllSales_Activated(object sender, EventArgs e)
        {
            RefreshHeader();
            gridHeader.CurrentCell = gridHeader.Rows[gridHeader.Rows.Count - 1].Cells[0];
            GridHeaderSelectionChanged();
        }

        private void btnPrintNota_Click(object sender, EventArgs e)
        {
            int index = gridHeader.CurrentRow.Index;
            if (index >= 0 && index < gridHeader.Rows.Count)
            {
                main.PVCSalesPrintReceipt(setPVCSalesID);
            }
        }

        private void btnUpdateDetail_Click(object sender, EventArgs e)
        {
            updateDetail = new PVCSalesUpdateDetail(main, setPVCSalesID);
            DialogResult result = updateDetail.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                RefreshHeader();
                SelectHeaderBySalesID(main.globalPVCSalesID);
            }
        }

        private void SelectHeaderBySalesID(int pvcSalesID)
        {
            DataGridViewCell temp;
            for (int i = 0; i < gridHeader.Rows.Count; i++)
            {
                temp = gridHeader.Rows[i].Cells[0];
                if (Int32.Parse(temp.Value.ToString()) == pvcSalesID)
                {
                    gridHeader.CurrentCell = temp;
                    break;
                }
            }
        }

        private void btnRefreshHeader_Click(object sender, EventArgs e)
        {
            RefreshHeader();
            SelectHeaderBySalesID(setPVCSalesID);
        }

        private void buatLaporanByQuery(object laporan)
        {
            ReportForm reportForm = new ReportForm(main);
            reportForm.MdiParent = main;
            reportForm.WindowState = FormWindowState.Maximized;

            reportForm.GetCrystalReportViewer().ReportSource = laporan;
            reportForm.GetCrystalReportViewer().Refresh();
            reportForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //sisa bayar : , ((SELECT SUM(quantity * sellPrice) FROM PVCSalesDetail WHERE pvcSalesID = psh.pvcSalesID) - (SELECT IFNULL(SUM(psp.ammount),0) FROM PVCSalesPayment psp WHERE psh.pvcSalesID = pvcSalesID)) AS sisaBayar
            DataTable dt = main.ExecuteQuery("SELECT DISTINCT psh.pvcSalesID, DATE_FORMAT(psh.salesTime, '%d/%m/%Y %H:%i:%s') AS salesTime, mc.customerName, (SELECT SUM(quantity * sellPrice) FROM PVCSalesDetail WHERE pvcSalesID = psh.pvcSalesID) AS totalPrice, (SELECT IFNULL(SUM(psp.ammount),0) FROM PVCSalesPayment psp WHERE psh.pvcSalesID = pvcSalesID) AS paymentPaid FROM PVCSalesHeader psh JOIN MsCustomer mc ON psh.customerID = mc.customerID JOIN PVCSalesDetail psd ON psh.pvcSalesID = psd.pvcSalesID WHERE psh.customerID = " + main.globalCustomerID + " AND psh.pvcSalesID IN (SELECT psh.pvcSalesID FROM PVCSalesHeader psh, PVCSalesPayment psp WHERE NOT psh.pvcSalesID IN (SELECT pvcSalesID FROM PVCSalesPayment WHERE psh.pvcSalesID = pvcSalesID) GROUP BY psh.pvcSalesID UNION SELECT psh.pvcSalesID FROM PVCSalesHeader psh WHERE (SELECT SUM(ammount) FROM PVCSalesPayment WHERE pvcSalesID = psh.pvcSalesID) < (SELECT SUM(quantity * sellPrice) FROM PVCSalesDetail WHERE pvcSalesID = psh.pvcSalesID))");

            if (dt == null)
            {
                MessageBox.Show("ERROR PRINT REPORT (LAPORAN HARIAN DI CLOSING FORM PVC)");
                this.Dispose();
            }
            else
            {
                if (dt.Rows.Count > 0)
                {
                    Rahayu_Program.Report.PVC.LaporanHutangKeseluruhan laporan = new Rahayu_Program.Report.PVC.LaporanHutangKeseluruhan();
                    laporan.SetDataSource(dt);
                    laporan.SummaryInfo.ReportTitle = "Laporan Hutang Keseluruhan";

                    buatLaporanByQuery(laporan);
                }
                else
                {
                    MessageBox.Show("DATA TIDAK ADA (LAPORAN HARIAN DI CLOSING FORM PVC)");
                }
            }
        }
    }
}
