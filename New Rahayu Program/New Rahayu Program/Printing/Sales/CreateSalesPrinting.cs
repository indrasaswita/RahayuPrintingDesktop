using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Rahayu_Program.Printing.Sales.SubSales;
using Rahayu_Program.Printing.Sales.PurchaseOrder;

namespace Rahayu_Program.Printing.Sales
{
    public partial class CreateSalesPrinting : Form
    {
        MainForm main;
        List<PrintingCreateSalesList> cart;

        int parentCompanyID = 0;
        int companyID = 0;
        int customerID, employeeID;
        string noPO, imgPO;

        public CreateSalesPrinting(MainForm main)
        {
            this.main = main;
            this.MdiParent = main;
            cart = new List<PrintingCreateSalesList>();

            InitializeComponent();
        }

        public DataTable ExecuteQuery(string query)
        {
            return main.ExecuteQuery(query);
        }

        private void CreateSalesPrinting_Load(object sender, EventArgs e)
        {
            RefreshWindow();
            ckbTempo.Checked = true;
            ckbTempo.Checked = false;
            
            refreshCartList();
        }

        public void RefreshWindow(int printingSalesID)
        {
            RefreshWindow();
            this.tbNoJob.Text = String.Format("{0:D10}", printingSalesID);

            dtpSalesTime.Visible = true;
            dtpSalesTime.Enabled = true;

            DataTable dt = ExecuteQuery("SELECT cu.customerID, cu.customerName, cu.phone as customerPhone, DATE_FORMAT(psh.salesTime, '%d/%m/%Y %H:%i:%s') AS salesTime, purchaseOrderID, deliveryNote, DATE_FORMAT(tempo, '%d/%m/%Y %H:%i:%s') AS tempo, co.companyID, co.companyName, co.parentCompanyID, psh.status FROM PrintingSalesHeader psh JOIN MsCustomer cu ON cu.customerID = psh.customerID JOIN MsCompany co ON cu.companyID = co.companyID WHERE printingSalesID = '" + printingSalesID + "'");
            if (dt != null)
            {
                if (dt.Rows.Count == 1)
                {
                    customerID = main.globalCustomerID = Int32.Parse(dt.Rows[0]["customerID"].ToString());
                    parentCompanyID = main.globalParentCompanyID = Int32.Parse(dt.Rows[0]["parentCompanyID"].ToString());
                    companyID = main.globalCompanyID = Int32.Parse(dt.Rows[0]["companyID"].ToString());
                    string customerCompany = dt.Rows[0]["companyName"].ToString();
                    string customerName = dt.Rows[0]["customerName"].ToString();
                    string customerPhone = dt.Rows[0]["customerPhone"].ToString();
                    DateTime salesTime = Other.Parser.TimeFromString(dt.Rows[0]["salesTime"].ToString());
                    noPO = dt.Rows[0]["purchaseOrderID"].ToString();
                    string deliveryNote = dt.Rows[0]["deliveryNote"].ToString();
                    DateTime tempo = Other.Parser.TimeFromString(dt.Rows[0]["tempo"].ToString());
                    string status = dt.Rows[0]["status"].ToString();

                    if (tempo < salesTime)
                    {
                        dtpTempo.Value = DateTime.Now;
                        ckbTempo.Checked = false;
                    }
                    else
                    {
                        dtpTempo.Value = tempo;
                        ckbTempo.Checked = true;
                    }
                    if (status == "SALE") rbNota.Checked = true;
                    else if (status == "OFFER") rbNota.Checked = true;

                    tbNoPO.Text = noPO;

                    dtpSalesTime.Checked = false;
                    dtpSalesTime.Value = salesTime;

                    if (deliveryNote.Trim() != "")
                    {
                        int dex = deliveryNote.LastIndexOf("; U/p. ");
                        if (dex != 1)
                        {
                            tbAlamatAntar.Text = deliveryNote.Substring(0, dex);
                            tbPenerima.Text = deliveryNote.Substring(dex + 7);
                        }
                        else
                        {
                            tbAlamatAntar.Text = deliveryNote;
                        }
                    }

                    tbCustomerCompany.Text = customerCompany;
                    tbCustomerName.Text = customerName;
                    tbCustomerPhone.Text = customerPhone;

                    // DETAIL BROOOOOOOOOO =================================================
                    dt = ExecuteQuery("SELECT jobType, printingType, printingTitle, previewFile, quantity, quantityType, " 
                                        + "offsetCounter, digitalCounter, inschiet, inschietType, material, "
                                        + "paperSize, imageSize, sidePrint, totalPlat, description, note, hargaAsli, hargaMaterial, "
                                        + "hargaOngkosCetak, DATE_FORMAT(deadline, '%d/%m/%Y %H:%i:%s') AS deadline " 
                                        + "FROM PrintingSalesDetail "
                                        + "WHERE printingSalesID = '" + printingSalesID + "'");
                    if (dt != null)
                    {
                        if (dt.Rows.Count > 0)
                        {
                            for(int i = 0; i < dt.Rows.Count; i++)
                            {
                                string jobType = dt.Rows[i]["jobType"].ToString();
                                string printingType = dt.Rows[i]["printingType"].ToString();
                                string printingTitle = dt.Rows[i]["printingTitle"].ToString();
                                string previewFile = dt.Rows[i]["previewFile"].ToString();
                                int quantity = Int32.Parse(dt.Rows[i]["quantity"].ToString());
                                string quantityType = dt.Rows[i]["quantityType"].ToString();
                                int offsetCounter = Int32.Parse(dt.Rows[i]["offsetCounter"].ToString());
                                int digitalCounter = Int32.Parse(dt.Rows[i]["digitalCounter"].ToString());
                                int inschiet = Int32.Parse(dt.Rows[i]["inschiet"].ToString());
                                string inschietType = dt.Rows[i]["inschietType"].ToString();
                                string material = dt.Rows[i]["material"].ToString();
                                string paperSize = dt.Rows[i]["paperSize"].ToString();
                                string imageSize = dt.Rows[i]["imageSize"].ToString();
                                string sidePrint = dt.Rows[i]["sidePrint"].ToString();
                                int totalPlat = Int32.Parse(dt.Rows[i]["totalPlat"].ToString());
                                string description = dt.Rows[i]["description"].ToString();
                                string note = dt.Rows[i]["note"].ToString();
                                int hargaAsli = Int32.Parse(dt.Rows[i]["hargaAsli"].ToString());
                                int hargaMaterial = Int32.Parse(dt.Rows[i]["hargaMaterial"].ToString());
                                int hargaOngkosCetak = Int32.Parse(dt.Rows[i]["hargaOngkosCetak"].ToString());
                                DateTime deadline = Other.Parser.TimeFromString(dt.Rows[i]["deadline"].ToString());

                                List<string[]> finishing = new List<string[]>();

                                DataTable dt2 = ExecuteQuery("SELECT finishingType, detail, note FROM PrintingSalesDetailFinishing WHERE printingSalesID = '" 
                                                                + printingSalesID + "' AND printingType = '" + printingType + "' AND printingTitle = '" 
                                                                + printingTitle + "'");
                                if (dt2 != null)
                                {
                                    if (dt2.Rows.Count > 0)
                                    {
                                        for(int j = 0; j < dt2.Rows.Count; j++)
                                        {
                                            string finishingType = dt2.Rows[j]["finishingType"].ToString();
                                            string detail = dt2.Rows[j]["detail"].ToString();
                                            string finishingNote = dt2.Rows[j]["note"].ToString();
                                            finishing.Add(new string[3] {finishingType, detail, finishingNote});
                                        }
                                    }
                                }

                                cart.Add(new PrintingCreateSalesList(this, jobType, printingType, printingTitle, previewFile, quantity, 
                                    quantityType, (jobType == "DG" ? digitalCounter : offsetCounter), inschiet, inschietType, material, paperSize, imageSize, sidePrint, totalPlat, description, 
                                    note, hargaAsli, hargaMaterial, hargaOngkosCetak, deadline, finishing));
                            }
                            refreshCartList();
                        }
                    }
                }
            }
        }

        public void RefreshWindow()
        {
            parentCompanyID = 0;
            companyID = 0;
            noPO = "";
            customerID = 0;
            employeeID = 0;
            imgPO = "";

            tbCustomerCompany.Text = "";
            tbCustomerName.Text = "";
            tbCustomerPhone.Text = "";

            tbPenerima.Text = "";
            tbAlamatAntar.Text = "";

            tbNoPO.Text = "";
            tbNoJob.Text = "";

            cart.Clear();
            panelCart.Controls.Clear();
            dtpTempo.Value = DateTime.Now;
            ckbTempo.Checked = false;

            nudTotalBelanja.Value = 0;
            nudTotalMaterial.Value = 0;
            nudTotalNota.Value = 0;
            nudTotalOngkosCetak.Value = 0;
            nudTotalPPh.Value = 0;

            dtpSalesTime.Visible = false;
            dtpSalesTime.Enabled = false;
            rbNota.Checked = true;
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            noPO = tbNoPO.Text;
            CekStatusPO();
        }

        private void CekStatusPO()
        {
            if (noPO == "")
                lblPO.Text = "Status : Tidak Ada PO!";
            else
            {
                if (imgPO == "")
                    lblPO.Text = "Harus Upload File!";
                else
                    lblPO.Text = "PO sudah tersimpan";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        public void addNewCart(string jobType, string printingType, string printingTitle, string previewFile, decimal quantity, string quantityType, decimal counter, decimal inschiet, string inschietType, string material, string paperSize, string imageSize, string sidePrint, decimal totalPlat, string description, string note, decimal hargaAsli, decimal hargaMaterial, decimal hargaOngkosCetak, DateTime deadline, List<string[]> finishing)
        {
            PrintingCreateSalesList temp = new PrintingCreateSalesList(this, jobType, printingType, printingTitle, previewFile, quantity, quantityType, counter, inschiet, inschietType, material, paperSize, imageSize, sidePrint, totalPlat, description, note, hargaAsli, hargaMaterial, hargaOngkosCetak, deadline, finishing);
            cart.Add(temp);
            refreshCartList();
        }

        public void refreshCartList()
        {
            panelCart.Controls.Clear();

            int y = 2;
            long totalAsli = 0, totalMaterial = 0, totalOngkosCetak = 0;
            for (int i = 0; i < cart.Count; i++)
            {
                cart[i].Location = new Point(2, y);
                panelCart.Controls.Add(cart[i]);
                y += cart[i].Height + 4;

                totalAsli += cart[i].GetHargaAsli();
                totalMaterial += cart[i].GetHargaMaterial();
                totalOngkosCetak += cart[i].GetHargaOngkosCetak();
            }
            nudTotalBelanja.Value = totalAsli;
            nudTotalMaterial.Value = totalMaterial;
            nudTotalOngkosCetak.Value = totalOngkosCetak;
            nudTotalNota.Value = totalMaterial + totalOngkosCetak;
            nudTotalPPh.Value = Convert.ToDecimal(0.04 * totalOngkosCetak);
        }

        private void tbAlamatAntar_TextChanged(object sender, EventArgs e)
        {
            if (tbAlamatAntar.Text != "" && tbPenerima.Text != "")
            {
                label3.Text = "Status : Diantar!";
            }
            else
            {
                label3.Text = "Status : Diantar!";
            }
        }

        private void btnAddOffset_Click(object sender, EventArgs e)
        {
            SubSalesOffset offset = new SubSalesOffset(main, this, "insert");
            offset.Show();
            offset.BringToFront();
        }

        private void btnAddSetting_Click(object sender, EventArgs e)
        {
            SubSalesSetting offset = new SubSalesSetting(main, this, "insert");
            offset.Show();
            offset.BringToFront();
        }

        private void btnAddPlotter_Click(object sender, EventArgs e)
        {

        }

        private void btnAddOngkos_Click(object sender, EventArgs e)
        {

        }

        private void btnAddLainLain_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            employeeID = main.globalEmployeeID;

            if (cart.Count == 0)
                main.SetMessage("Isi keranjang belanjaan dulu");
            else if (employeeID == 0)
                main.SetMessage("Belom pilih karyawan");
            else if (customerID == 0)
                main.SetMessage("Belom pilih customer");
            else
            {
                //KALO SUDAH DI ISI SEMUA
                if (tbNoJob.Text == "")
                {
                    string status = "SALE";
                    if (rbPenawaran.Checked) status = "OFFER";


                    //INSERT DATA TRANSACTION
                    // 1 > HEADER
                    ExecuteQuery("INSERT INTO PrintingSalesHeader(customerID, salesTime, purchaseOrderID, deliveryNote, tempo, status) VALUES ('" + customerID +
                        "', now(), '" + noPO + "', '" + tbAlamatAntar.Text + "; U/p. " + tbPenerima.Text + "', '" +
                        (ckbTempo.Checked ? dtpTempo.Value.ToString("yyyy-MM-dd") : "1900-01-01") + "', '" + status + "')");
                    DataTable dt = ExecuteQuery("SELECT printingSalesID FROM PrintingSalesHeader ORDER BY printingSalesID DESC LIMIT 0, 1"); // ambil id terakhir
                    if (dt != null)
                    {
                        if (dt.Rows.Count == 1)
                        {
                            tbNoJob.Text = String.Format("{0:D6}", Int32.Parse(dt.Rows[0]["printingSalesID"].ToString()));
                        }

                        //harus di dalam soalnya kalo ga kecari ga boleh di execute
                        // 2 > DETAIL
                        foreach (PrintingCreateSalesList i in cart)
                        {
                            int printApproval = 0;
                            string printApprovalImage = "", printApprovalSigner = "";
                            string deadline = "";

                            if (i.deadline > dtpSalesTime.Value.AddHours(1))
                            {
                                deadline = i.deadline.ToString("yyyy-MM-dd HH:mm:ss");
                            }
                            else
                            {
                                deadline = "1900-01-01 00:00:00";
                            }

                            if (i.jobType == "ST")
                            {
                                int timerID = Int32.Parse(i.paperSize.Substring(i.paperSize.LastIndexOf(" ")));
                                ExecuteQuery("UPDATE PrintingTimerHeader SET status = 1 WHERE printingTimerID = '" + timerID + "'");
                            }

                            ExecuteQuery("INSERT INTO PrintingSalesDetail(printingSalesID, printingType, printingTitle, jobType, previewFile, quantity, " +
                                "quantityType, inschiet, inschietType, material, paperSize, imageSize, sidePrint, totalPlat, description, note, " +
                                "hargaAsli, hargaMaterial, hargaOngkosCetak, deadline, printApproval, printApprovalImage, " +
                                "printApprovalSigner, status, digitalCounter, offsetCounter) " +
                                "VALUES " +
                                "('" + tbNoJob.Text + "', '" + i.printingType + "', '" + i.printingTitle + "', '" + i.jobType + "', '" + i.previewFile +
                                "', '" + i.quantity + "', '" + i.quantityType + "', '" + i.inschiet + "', '" + i.inschietType +
                                "', '" + i.material + "', '" + i.paperSize + "', '" + i.imageSize + "', '" + i.sidePrint +
                                "', '" + i.totalPlat + "', '" + i.description + "', '" + i.note + "', '" + i.hargaAsli +
                                "', '" + i.hargaMaterial + "', '" + i.hargaOngkosCetak + "', '" + deadline +
                                "', '" + printApproval + "', '" + printApprovalImage + "', '" + printApprovalSigner + "', 'none', '" + i.digitalCounter + "', '"+ i.offsetCounter +"')");

                            if (i.finishing != null)
                                foreach (string[] j in i.finishing)
                                {
                                    ExecuteQuery("INSERT INTO PrintingSalesDetailFinishing(printingSalesID, printingType, printingTitle, finishingType, detail, note, process) " +
                                        "VALUES " +
                                        "('" + tbNoJob.Text + "', '" + i.printingType + "', '" + i.printingTitle + "', '" + j[0] + "', '" + j[1] + "', '" + j[2] + "', '0')");
                                }
                        }
                    }

                    int hargaAsli = Convert.ToInt32(nudTotalBelanja.Value);
                    int hargaPalsu = Convert.ToInt32(nudTotalNota.Value);
                    CreateSalesPayment salesPayment = new CreateSalesPayment(main, Int32.Parse(tbNoJob.Text), hargaAsli, hargaPalsu);
                    DialogResult result = salesPayment.ShowDialog();
                    if (result == System.Windows.Forms.DialogResult.OK)
                    {
                        main.SetMessage("Pembayaran sudah dimasukkan..");
                        closeWindow();
                    }
                    main.ShowSalesPrintingRefresh();
                }
                else
                {
                    string tempoTemp;
                    //UPDATE DATA TRANSACTION
                    if (ckbTempo.Checked == true)
                    {
                        tempoTemp = dtpTempo.Value.ToString("yyyy-MM-dd");
                    }
                    else
                    {
                        tempoTemp = "1900-01-01";
                    }

                    ExecuteQuery("UPDATE PrintingSalesHeader SET customerID = '" + customerID + (dtpSalesTime.Checked == true ? "', salesTime = '" + dtpSalesTime.Value.ToString("yyyy-MM-dd HH:mm:ss") : "") + "', purchaseOrderID = '" + noPO + "', deliveryNote = '" + tbAlamatAntar.Text + "; U/p. " + tbPenerima.Text + "', tempo = '" + tempoTemp + "' WHERE printingSalesID = '" + Int32.Parse(tbNoJob.Text) + "'");

                    ExecuteQuery("DELETE FROM PrintingSalesDetail WHERE printingSalesID = '" + tbNoJob.Text + "'");
                    ExecuteQuery("DELETE FROM PrintingSalesDetailFinishing WHERE printingSalesID = '" + tbNoJob.Text + "'");

                    foreach (PrintingCreateSalesList i in cart)
                    {
                        int printApproval = 0;
                        string printApprovalImage = "", printApprovalSigner = "";
                        string deadline = "";

                        if (i.deadline > dtpSalesTime.Value.AddHours(1))
                        {
                            deadline = i.deadline.ToString("yyyy-MM-dd HH:mm:ss");
                        }
                        else
                        {
                            deadline = "1900-01-01 00:00:00";
                        }

                        ExecuteQuery("INSERT INTO PrintingSalesDetail(printingSalesID, printingType, printingTitle, jobType, previewFile, quantity, " +
                            "quantityType, inschiet, inschietType, material, paperSize, imageSize, sidePrint, totalPlat, description, note, " +
                            "hargaAsli, hargaMaterial, hargaOngkosCetak, deadline, printApproval, printApprovalImage, " +
                            "printApprovalSigner, status, digitalCounter, offsetCounter) " +
                            "VALUES " +
                            "('" + tbNoJob.Text + "', '" + i.printingType + "', '" + i.printingTitle + "', '" + i.jobType + "', '" + i.previewFile +
                            "', '" + i.quantity + "', '" + i.quantityType + "', '" + i.inschiet + "', '" + i.inschietType +
                            "', '" + i.material + "', '" + i.paperSize + "', '" + i.imageSize + "', '" + i.sidePrint +
                            "', '" + i.totalPlat + "', '" + i.description + "', '" + i.note + "', '" + i.hargaAsli +
                            "', '" + i.hargaMaterial + "', '" + i.hargaOngkosCetak + "', '" + deadline +
                            "', '" + printApproval + "', '" + printApprovalImage + "', '" + printApprovalSigner + 
                            "', 'none', '" + i.digitalCounter + "', '" + i.offsetCounter + "')");

                        foreach (string[] j in i.finishing)
                        {
                            ExecuteQuery("INSERT INTO PrintingSalesDetailFinishing(printingSalesID, printingType, printingTitle, finishingType, detail, note, process) " +
                                "VALUES " +
                                "('" + tbNoJob.Text + "', '" + i.printingType + "', '" + i.printingTitle + "', '" + j[0] + "', '" + j[1] + "', '" + j[2] + "', '0')");
                        }
                    }
                    closeWindow();
                }
            }
        }

        private void closeWindow()
        {
            this.Hide();
            if (tbNoJob.Text != "")
                main.setSelectedPrintingSalesID(Int32.Parse(tbNoJob.Text)); //--> ERROR
        }

        string companyAddress, customerAddress;

        private void btnSearchCustomer_Click(object sender, EventArgs e)
        {
            Master.Customer.SearchCustomerPVC searchCustomer = new Master.Customer.SearchCustomerPVC(main);

            DialogResult result = searchCustomer.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                parentCompanyID = main.globalParentCompanyID;
                companyID = main.globalCompanyID;
                customerID = main.globalCustomerID;

                DataTable dt = ExecuteQuery("SELECT companyName, phone, address FROM MsCompany WHERE companyID = " + companyID + "");
                companyAddress = dt.Rows[0]["address"].ToString();
                tbCustomerCompany.Text = dt.Rows[0]["companyName"].ToString();
                dt = ExecuteQuery("SELECT customerName, phone, address FROM MsCustomer WHERE customerID = " + customerID + "");
                customerAddress = dt.Rows[0]["address"].ToString();
                tbCustomerName.Text = dt.Rows[0]["customerName"].ToString();
                tbCustomerPhone.Text = dt.Rows[0]["phone"].ToString();

            }
        }

        private void ckbTempo_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbTempo.Checked)
            {
                dtpTempo.Visible = true;
                ckbTempo.Text = "Tempo: " + dtpTempo.Value.ToString("dd/MM/yy");
                btn1B.Visible = true;
                btn2B.Visible = true;
                btn1M.Visible = true;
                btn2M.Visible = true;
                btn6M.Visible = true;
            }
            else
            {
                dtpTempo.Visible = false;
                ckbTempo.Text = "Tempo";
                btn1B.Visible = false;
                btn2B.Visible = false;
                btn1M.Visible = false;
                btn2M.Visible = false;
                btn6M.Visible = false;
            }
        }

        private void dtpTempo_ValueChanged(object sender, EventArgs e)
        {
            ckbTempo.Text = "Tempo: " + dtpTempo.Value.ToString("dd/MM/yy");
        }

        private void btn1M_Click(object sender, EventArgs e)
        {
            dtpTempo.Value = DateTime.Now.AddDays(7);
        }

        private void btn2M_Click(object sender, EventArgs e)
        {
            dtpTempo.Value = DateTime.Now.AddDays(14);
        }

        private void btn1B_Click(object sender, EventArgs e)
        {
            dtpTempo.Value = DateTime.Now.AddMonths(1);
        }

        private void btn6M_Click(object sender, EventArgs e)
        {
            dtpTempo.Value = DateTime.Now.AddDays(42);
        }

        private void btn2B_Click(object sender, EventArgs e)
        {
            dtpTempo.Value = DateTime.Now.AddMonths(2);
        }

        internal void deleteList(PrintingCreateSalesList selected)
        {
            cart.Remove(selected);
            refreshCartList();
        }

        internal void updateList(PrintingCreateSalesList selected)
        {
            if (selected.jobType == "OF" || selected.jobType == "DG" || selected.jobType == "PL" || selected.jobType == "LL")
            {
                SubSalesOffset offset = new SubSalesOffset(main, this, "update");
                offset.Show();
                offset.setData(selected);
                offset.BringToFront();
            }
            else if (selected.jobType == "ST")
            {
                SubSalesSetting setting = new SubSalesSetting(main, this, "update");
                setting.Show();
                setting.setData(selected);
                setting.BringToFront();
            }
        }

        private void btnViewAllSales_Click(object sender, EventArgs e)
        {
            closeWindow();
        }

        private void btnViewCustomer_Click(object sender, EventArgs e)
        {
            //lihat customer
        }

        private void btnViewPO_Click(object sender, EventArgs e)
        {
            //main.ShowOpenPDF(filePO);
        }

        private void btnUploadPO_Click(object sender, EventArgs e)
        {
            btnUploadPO_Click();
        }

        private void btnUploadPO_Click()
        {
            UploadPO upload = new UploadPO(main);
            DialogResult result = upload.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                setNoPO(main.globalNoPO);
            }
        }

        public void setNoPO(string noPO)
        {
            tbNoPO.Text = noPO;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            customerID = main.globalCustomerID = 38;
            companyID = main.globalCompanyID = 1;
            parentCompanyID = main.globalParentCompanyID = 1;

            DataTable dt = ExecuteQuery("SELECT companyName, phone, address FROM MsCompany WHERE companyID = " + companyID + "");
            companyAddress = dt.Rows[0]["address"].ToString();
            tbCustomerCompany.Text = dt.Rows[0]["companyName"].ToString();
            dt = ExecuteQuery("SELECT customerName, phone, address FROM MsCustomer WHERE customerID = " + customerID + "");
            customerAddress = dt.Rows[0]["address"].ToString();
            tbCustomerName.Text = dt.Rows[0]["customerName"].ToString();
            tbCustomerPhone.Text = dt.Rows[0]["phone"].ToString();
        }

        private void tbShcF1_Enter(object sender, EventArgs e)
        {
            btnAddOffset.Focus();
        }

        private void tbShcF7_Enter(object sender, EventArgs e)
        {
            btnSave.Focus();
        }

        private void offsetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnAddOffset_Click(sender, e);
        }

    }
}
