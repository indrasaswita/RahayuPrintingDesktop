using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Rahayu_Program.Master.PVC;
using Rahayu_Program.Master.Customer;
using Microsoft.PointOfService;
using Rahayu_Program.Util;

namespace Rahayu_Program.PVC.Sales
{
    public partial class CreateSalesPVC : Form
    {
        public MainForm main;
        Master.Customer.SearchCustomerPVC searchCustomer;
        SearchPVC searchPVC;
        public int parentCompanyID, companyID, customerID;
        int pvcID, pvcTypeID;
        public List<SalesPVCList> cart;

        public CreateSalesPVC(MainForm main)
        {
            this.main = main;
            this.MdiParent = main;
            this.searchCustomer = new Master.Customer.SearchCustomerPVC(main);
            this.searchPVC = new SearchPVC(main);
            this.cart = new List<SalesPVCList>();

            InitializeComponent();
        }

        public DataTable ExecuteQuery(string query)
        {
            return main.ExecuteQuery(query);
        }

        private void CreateSalesPVC_Load(object sender, EventArgs e)
        {
            gridHistory.Columns.Add("", "PVC");
            gridHistory.Columns[0].Width = 224;
            gridHistory.Columns.Add("", "Price");
            gridHistory.Columns[1].Width = 90;
            gridHistory.Columns.Add("", "Terakhir");
            gridHistory.Columns[2].Width = 80;

            foreach (DataGridViewColumn column in gridHistory.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        public void AddDetail()
        {
            DataTable dt = ExecuteQuery("SELECT pvcSalesID FROM PVCSalesHeader ORDER BY pvcSalesID DESC LIMIT 0, 1");
            int pvcSalesID = Int32.Parse(dt.Rows[0]["pvcSalesID"].ToString());
            for (int i = 0; i < cart.Count; i++)
            {
                if (cart[i].GetQty() != 0)
                {
                    ExecuteQuery("INSERT INTO PVCSalesDetail VALUES (" + pvcSalesID + ", " + cart[i].GetPVCID() + ", '" + cart[i].GetQty() + "', " + cart[i].GetPrice() + ", 0, 0, 0)");
                    // RULES: 
                    // 1. Kalo PVCTypeID = 8 atau 9 ga usa kurangin stock
                    // 2. Kalo 22 (Digital tanpa Overlay) -> Kurangin 4 (Digital Konica) x 2
                    // 3. Kalo 23 (Digital + Overlay) -> Kurangin 4 (Digital Konica) x 2 dan 13 (Overlay Coated CA) x 1
                    if (cart[i].GetPVCTypeID() != 8 && cart[i].GetPVCTypeID() != 9)
                    {
                        ExecuteQuery("UPDATE MsPVC SET rahayuStock = rahayuStock - '" + cart[i].GetQty() + "' WHERE pvcID = " + cart[i].GetPVCID() + "");
                    }
                    else
                    {
                        if (cart[i].GetPVCID() == 22 || cart[i].GetPVCID() == 23)
                        {
                            //kurangin 2x digital konica
                            ExecuteQuery("UPDATE MsPVC SET rahayuStock = rahayuStock - '" + (2 * cart[i].GetQty()) + "' WHERE pvcID = 4");
                        }
                        if (cart[i].GetPVCID() == 23)
                        {
                            //kurangin 1x overlay coated ca
                            ExecuteQuery("UPDATE MsPVC SET rahayuStock = rahayuStock - '" + cart[i].GetQty() + "' WHERE pvcID = 13");
                        }
                    }
                }
            }
        }

        public void RefreshTotalBeli()
        {
            int total = 0;
            for (int i = 0; i < cart.Count; i++)
            {
                total += Convert.ToInt32(cart[i].GetQty() * cart[i].GetPrice());
            }
            nudTotalBeli.Value = total;
        }

        private void ClearCustomer()
        {
            tbParentCompany.Text = "Parent Company";
            tbNamaCompany.Text = "Nama Company";
            tbPhoneCompany.Text = "Telepon Company";
            tbAlamatCompany.Text = "Alamat Company";
            tbCustomerName.Text = "Nama Customer";
            tbPhoneCustomer.Text = "Telepon Customer";
            tbAddressCustomer.Text = "Alamat Customer";
            gridHistory.Rows.Clear();
        }

        private void ClearCart()
        {
            cart.Clear();
            panelCart.Controls.Clear();
            nudTotalBeli.Value = 0;
        }

        private void ClearField()
        {
            tbNamaPVC.Text = "";
            nudQty.Value = 0;
            nudPack.Value = 0;
            nudPerPack.Value = 0;
            nudTotal.Value = 0;
            nudTotalQty.Value = 0;
            nudPrice.Value = 0;
            pvcID = 0;
        }

        private void btnSearchCustomer_Click(object sender, EventArgs e)
        {
            DialogResult result = searchCustomer.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                parentCompanyID = main.globalParentCompanyID;
                companyID = main.globalCompanyID;
                customerID = main.globalCustomerID;

                DataTable dt = ExecuteQuery("SELECT parentCompanyName FROM MsParentCompany WHERE parentCompanyID = " + parentCompanyID + "");
                tbParentCompany.Text = dt.Rows[0]["parentCompanyName"].ToString();
                dt = ExecuteQuery("SELECT companyName, phone, address FROM MsCompany WHERE companyID = " + companyID + "");
                tbNamaCompany.Text = dt.Rows[0]["companyName"].ToString();
                tbPhoneCompany.Text = dt.Rows[0]["phone"].ToString();
                tbAlamatCompany.Text = dt.Rows[0]["address"].ToString();
                dt = ExecuteQuery("SELECT customerName, phone, address FROM MsCustomer WHERE customerID = " + customerID + "");
                tbCustomerName.Text = dt.Rows[0]["customerName"].ToString();
                tbPhoneCustomer.Text = dt.Rows[0]["phone"].ToString();
                tbAddressCustomer.Text = dt.Rows[0]["address"].ToString();

                //MASUKIN DATA HISTORY BELI BY CUSTOMER ID
                dt = ExecuteQuery("SELECT pvcName, MAX(psd.sellPrice) As sellPrice, DATE_FORMAT(psh.salesTime, '%d/%m/%Y %H:%i:%s') AS salesTime FROM MsPVC mp,PVCSalesHeader psh, PVCSalesDetail psd WHERE psd.pvcID = mp.pvcID AND psh.pvcSalesID = psd.pvcSalesID AND customerID = " + customerID + " GROUP BY pvcName ORDER BY pvcName");
                gridHistory.Rows.Clear();
                if (dt != null)
                {
                    if (dt.Rows.Count > 0)
                    {
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            gridHistory.Rows.Add(dt.Rows[i]["pvcName"].ToString(), Int32.Parse(dt.Rows[i]["sellPrice"].ToString()).ToString("#,##0"), Other.Parser.TimeFromString(dt.Rows[i]["salesTime"].ToString()).ToString("dd/MM/yy"));
                        }
                    }
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (tbParentCompany.ReadOnly == true)
            {
                if (tbParentCompany.Text == "Parent Company")
                {
                    tbParentCompany.Text = "";
                }
                tbParentCompany.ReadOnly = false;
                tbParentCompany.Focus();
            }
            else
            {
                if (tbParentCompany.Text != "" && tbParentCompany.Text != "Parent Company")
                {
                    ExecuteQuery("UPDATE MsParentCompany SET parentCompanyName = '" + tbParentCompany.Text + "' WHERE parentCompanyID = " + parentCompanyID + "");
                    tbParentCompany.ReadOnly = true;
                    nudPack.Focus();
                }
                else
                {
                    tbParentCompany.Text = "Parent Company";
                    tbParentCompany.ReadOnly = true;
                    nudPack.Focus();
                }
            }
        }

        private void btnUpdateNamaCompany_Click(object sender, EventArgs e)
        {
            if (tbNamaCompany.ReadOnly == true)
            {
                if (tbNamaCompany.Text == "Nama Company")
                {
                    tbNamaCompany.Text = "";
                }
                tbNamaCompany.ReadOnly = false;
                tbNamaCompany.Focus();
            }
            else
            {
                if (tbNamaCompany.Text != "" && tbNamaCompany.Text != "Nama Company")
                {
                    ExecuteQuery("UPDATE MsCompany SET companyName = '" + tbNamaCompany.Text + "' WHERE companyID = " + companyID + "");
                    tbNamaCompany.ReadOnly = true;
                    nudPack.Focus();
                }
                else
                {
                    tbNamaCompany.Text = "Nama Company";
                    tbNamaCompany.ReadOnly = true;
                    nudPack.Focus();
                }
            }
        }

        private void btnUpdatePhoneCompany_Click(object sender, EventArgs e)
        {
            if (tbPhoneCompany.ReadOnly == true)
            {
                if (tbPhoneCompany.Text == "Phone Company")
                {
                    tbPhoneCompany.Text = "";
                }
                tbPhoneCompany.ReadOnly = false;
                tbPhoneCompany.Focus();
            }
            else
            {
                if (tbPhoneCompany.Text != "" && tbPhoneCompany.Text != "Phone Company")
                {
                    ExecuteQuery("UPDATE MsCompany SET phone = '" + tbPhoneCompany.Text + "' WHERE companyID = " + companyID + "");
                    tbPhoneCompany.ReadOnly = true;
                    nudPack.Focus();
                }
                else
                {
                    tbPhoneCompany.Text = "Phone Company";
                    tbPhoneCompany.ReadOnly = true;
                    nudPack.Focus();
                }
            }
        }

        private void btnUpdateAlamatCompany_Click(object sender, EventArgs e)
        {
            if (tbAlamatCompany.ReadOnly == true)
            {
                if (tbAlamatCompany.Text == "Alamat Company")
                {
                    tbAlamatCompany.Text = "";
                }
                tbAlamatCompany.ReadOnly = false;
                tbAlamatCompany.Focus();
            }
            else
            {
                if (tbAlamatCompany.Text != "" && tbAlamatCompany.Text != "Alamat Company")
                {
                    ExecuteQuery("UPDATE MsCompany SET address = '" + tbAlamatCompany.Text + "' WHERE companyID = " + companyID + "");
                    tbAlamatCompany.ReadOnly = true;
                    nudPack.Focus();
                }
                else
                {
                    tbAlamatCompany.Text = "Alamat Company";
                    tbAlamatCompany.ReadOnly = true;
                    nudPack.Focus();
                }
            }
        }

        private void btnUpdateNamaCustomer_Click(object sender, EventArgs e)
        {
            if (tbCustomerName.ReadOnly == true)
            {
                if (tbCustomerName.Text == "Nama Customer")
                {
                    tbCustomerName.Text = "";
                }
                tbCustomerName.ReadOnly = false;
                tbCustomerName.Focus();
            }
            else
            {
                if (tbCustomerName.Text != "" && tbCustomerName.Text != "Nama Customer")
                {
                    ExecuteQuery("UPDATE MsCustomer SET customerName = '" + tbCustomerName.Text + "' WHERE customerID = " + customerID + "");
                    tbCustomerName.ReadOnly = true;
                    nudPack.Focus();
                }
                else
                {
                    tbCustomerName.Text = "Nama Customer";
                    tbCustomerName.ReadOnly = true;
                    nudPack.Focus();
                }
            }
        }

        private void btnUpdatePhoneCustomer_Click(object sender, EventArgs e)
        {
            if (tbPhoneCustomer.ReadOnly == true)
            {
                if (tbPhoneCustomer.Text == "Phone Customer")
                {
                    tbPhoneCustomer.Text = "";
                }
                tbPhoneCustomer.ReadOnly = false;
                tbPhoneCustomer.Focus();
            }
            else
            {
                if (tbPhoneCustomer.Text != "" && tbPhoneCustomer.Text != "Phone Customer")
                {
                    ExecuteQuery("UPDATE MsCustomer SET phone = '" + tbPhoneCustomer.Text + "' WHERE customerID = " + customerID + "");
                    tbPhoneCustomer.ReadOnly = true;
                    nudPack.Focus();
                }
                else
                {
                    tbPhoneCustomer.Text = "Phone Customer";
                    tbPhoneCustomer.ReadOnly = true;
                    nudPack.Focus();
                }
            }
        }

        private void btnUpdateAlamatCustomer_Click(object sender, EventArgs e)
        {
            if (tbAddressCustomer.ReadOnly == true)
            {
                if (tbAddressCustomer.Text == "Alamat Customer")
                {
                    tbAddressCustomer.Text = "";
                }
                tbAddressCustomer.ReadOnly = false;
                tbAddressCustomer.Focus();
            }
            else
            {
                if (tbAddressCustomer.Text != "" && tbAddressCustomer.Text != "Alamat Customer")
                {
                    ExecuteQuery("UPDATE MsCustomer SET address = '" + tbAddressCustomer.Text + "' WHERE customerID = " + customerID + "");
                    tbAddressCustomer.ReadOnly = true;
                    nudPack.Focus();
                }
                else
                {
                    tbAddressCustomer.Text = "Alamat Customer";
                    tbAddressCustomer.ReadOnly = true;
                    nudPack.Focus();
                }
            }
        }

        private int defaultPrice;

        private void btnSearchPVC_Click(object sender, EventArgs e)
        {
            if (customerID > 0)
            {
                DialogResult result = searchPVC.ShowDialog();
                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    pvcID = main.globalPVCID;

                    DataTable dt = ExecuteQuery("SELECT pvcName, pvcTypeID, pvcPerPack, pvcTypeUnit, sellPrice FROM MsPVC WHERE pvcID = " + pvcID + "");

                    nudPerPack.Value = 0;
                    nudPrice.Value = 0;
                    nudQty.Value = 0;
                    nudTotal.Value = 0;
                    nudPack.Value = 0;
                    nudTotalQty.Value = 0;

                    pvcTypeID = Int32.Parse(dt.Rows[0]["pvcTypeID"].ToString());
                    tbNamaPVC.Text = dt.Rows[0]["pvcName"].ToString();
                    nudPerPack.Value = Decimal.Parse(dt.Rows[0]["pvcPerPack"].ToString());
                    defaultPrice = Int32.Parse(dt.Rows[0]["sellPrice"].ToString());
                    nudPrice.Value = defaultPrice;
                    LblPVCType.Text = dt.Rows[0]["pvcTypeUnit"].ToString();

                    nudPack.Focus();
                    nudPack.Select(0, 9);
                }
            }
            else
            {
                btnSearchCustomer_Click(sender, e);
            }
        }

        private void btnEnterQty_Click(object sender, EventArgs e)
        {
            if (nudPack.Value == 0)
            {
                main.SetMessage("TIDAK BISA QTY 0");
            }
            else
            {
                nudQty.Value = nudTotalQty.Value;
                nudPrice.Focus();
                nudPrice.Select(0, 9);
            }
        }

        private void nudPack_ValueChanged(object sender, EventArgs e)
        {
            nudTotalQty.Value = nudPack.Value * nudPerPack.Value;
        }

        private void nudPack_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnEnterQty.Focus();
            }
        }

        private void updateTotalHarga()
        {
            if (nudQty.Value * nudPrice.Value < 99999999999)
            {
                nudTotal.Value = nudQty.Value * nudPrice.Value;
            }
            else
            {
                main.SetMessage("QTY IS TOOOOOO LARGE!");
            }
        }

        private void nudQty_ValueChanged(object sender, EventArgs e)
        {
            updateTotalHarga();
        }

        private void nudPrice_ValueChanged(object sender, EventArgs e)
        {
            updateTotalHarga();
        }

        private void nudPrice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAddToCart.Focus();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                nudPrice.Value = defaultPrice;
            }
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if (customerID > 0)
            {
                if (pvcID > 0)
                {
                    if (nudQty.Value != 0)
                    {
                        decimal awal = 0;
                        for (int i = 0; i < cart.Count; i++)
                        {
                            if (cart[i].GetPVCID() == pvcID)
                            {
                                //awal = cart[i].GetQty();
                                RemoveCartList(i);
                                break;
                            }
                        }

                        SalesPVCList temp = new SalesPVCList(this, pvcID, pvcTypeID, tbNamaPVC.Text, nudQty.Value + awal, nudPerPack.Value, Convert.ToInt32(nudPrice.Value));
                        cart.Add(temp);
                        RefreshCartList();
                        ClearField();

                        btnSearchPVC.Focus();
                    }
                    else
                    {
                        main.SetMessage("Qty tidak bisa 0");
                        nudPack.Focus();
                    }
                }
                else
                {
                    btnSearchPVC_Click(sender, e);
                }
            }
            else
            {
                btnSearchCustomer_Click(sender, e);
            }
        }

        private void RefreshCartList()
        {
            panelCart.Controls.Clear();
            int total = 0;
            for (int i = 0; i < cart.Count; i++)
            {
                cart[i].Location = new Point(1, 1 + (i * (1 + cart[i].Height)));
                panelCart.Controls.Add(cart[i]);
                total += cart[i].getTotal();
            }
            nudTotalBeli.Value = total;
        }

        private void btnClearField_Click(object sender, EventArgs e)
        {
            if (customerID > 0)
            {
                if (pvcID > 0)
                {
                    ClearField();
                }
                else
                {
                    btnSearchPVC_Click(sender, e);
                }
            }
            else
            {
                btnSearchCustomer_Click(sender, e);
            }
        }

        private void RemoveCartList(int i)
        {
            cart.RemoveAt(i);
            RefreshCartList();
        }

        private void RemoveCartList()
        {
            cart.Clear();
            panelCart.Controls.Clear();
        }

        internal void RemoveCart(SalesPVCList salesPVCList)
        {
            for (int i = 0; i < cart.Count; i++)
            {
                if (cart[i].GetPVCID() == salesPVCList.GetPVCID())
                {
                    RemoveCartList(i);
                    break;
                }
            }
        }

        private void ClearCustomerField()
        {
            tbParentCompany.Text = "";
            tbNamaCompany.Text = "";
            tbAlamatCompany.Text = "";
            tbPhoneCompany.Text = "";
            tbCustomerName.Text = "";
            tbPhoneCustomer.Text = "";
            tbAddressCustomer.Text = "";

            parentCompanyID = 0;
            companyID = 0;
            customerID = 0;
        }

        private void tbParentCompany_Enter(object sender, EventArgs e)
        {
            if (tbParentCompany.ReadOnly == true)
                btnSearchCustomer.Focus();
        }

        private void tbNamaCompany_Enter(object sender, EventArgs e)
        {
            if (tbNamaCompany.ReadOnly == true)
                btnSearchCustomer.Focus();
        }

        private void tbPhoneCompany_Enter(object sender, EventArgs e)
        {
            if (tbPhoneCompany.ReadOnly == true)
                btnSearchCustomer.Focus();
        }

        private void tbAlamatCompany_Enter(object sender, EventArgs e)
        {
            if (tbAlamatCompany.ReadOnly == true)
                btnSearchCustomer.Focus();
        }

        private void tbCustomerName_Enter(object sender, EventArgs e)
        {
            if (tbCustomerName.ReadOnly == true)
                btnSearchCustomer.Focus();
        }

        private void tbPhoneCustomer_Enter(object sender, EventArgs e)
        {
            if (tbPhoneCustomer.ReadOnly == true)
                btnSearchCustomer.Focus();
        }

        private void tbAddressCustomer_Enter(object sender, EventArgs e)
        {
            if (tbAddressCustomer.ReadOnly == true)
                btnSearchCustomer.Focus();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (customerID > 0)
            {
                main.globalCustomerID = customerID;
                if (cart.Count > 0)
                {
                    PVCSalesPayment payment = new PVCSalesPayment(main, Convert.ToInt32(nudTotalBeli.Value));
                    DialogResult result = payment.ShowDialog();
                    if (result == System.Windows.Forms.DialogResult.OK)
                    {
                        main.SetMessage("Data sudah di input dengan baik");
                        CreateSalesPVC_Activated(sender, e);
                    }
                }
                else
                {
                    main.SetMessage("Fill CART first!");
                }
            }
            else
            {
                btnSearchCustomer_Click(sender, e);
            }
        }

        private void btnViewAllSales_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (main.viewSalesPVC == null) main.viewSalesPVC = new Rahayu_Program.PVC.Sales.ViewAllSales(main);
            main.viewSalesPVC.Show();
        }

        private void CreateSalesPVC_Activated(object sender, EventArgs e)
        {
            ClearField();
            ClearCart();
            ClearCustomer();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (customerID != 0)
            {
                PrintCustomerDetail printCustomerDetail = new PrintCustomerDetail(main, customerID);
                printCustomerDetail.ShowDialog();
            }
        }

        private void btnOpenCashDrawer_Click(object sender, EventArgs e)
        {
            
        }
    }
}
