using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;
using Rahayu_Program.Printing.Sales.SalesClone;
using Rahayu_Program.Master.PVC;
using Rahayu_Program.Printing.Sales;
using Rahayu_Program.Printing.Sales.TukerFaktur;
using Rahayu_Program.Printing.Sales.PurchaseOrder;
using System.IO.Ports;

namespace Rahayu_Program
{
    public partial class MainForm : Form
    {
        private Config.Conn conn;
        private DialogBox.LoginBox login;
        public int globalEmployeeID;
        public int globalEmployeeRole;
        public int globalEmployeeLevel;

        public int globalCustomerID;
        public string globalCustomerName;
        public int globalCompanyID;
        public string globalCompanyName;
        public int globalParentCompanyID;
        public string globalParentCompanyName;

        public int globalPVCID;

        public int globalPVCSalesID;

        public string globalBarangID;
        public string globalBarangName;

        public string globalNoPO;

        public string globalQuery;

        public Boolean customerAdmin;
        public Boolean customerNormal;
        public Boolean employeeAdmin;
        public Boolean employeeNormal;
        public Boolean changeRole;
        public Boolean pvcItemAdmin;
        public Boolean pvcItemNormal;
        public Boolean pvcSalesAdmin;
        public Boolean pvcSalesNormal;
        public Boolean pvcPurchaseAdmin;
        public Boolean pvcPurchaseNormal;
        public Boolean pvcTransferAdmin;
        public Boolean pvcTransferNormal;
        public Boolean pvcReportAdmin;
        public Boolean pvcReportNormal;
        public Boolean printingSalesAdmin;
        public Boolean printingSalesNormal;
        public Boolean printingPurchaseAdmin;
        public Boolean printingPurchaseNormal;
        public Boolean printingReportAdmin;
        public Boolean printingReportNormal;
        public Boolean printingFileAdmin;
        public Boolean printingFileNormal;
        public Boolean printingSalesCloneAdmin;
        public Boolean printingSalesCloneNormal;
        public Boolean kostSalesAdmin;
        public Boolean kostSalesNormal;
        public Boolean kostPurchaseAdmin;
        public Boolean kostPurchaseNormal;
        public Boolean kostReportAdmin;
        public Boolean kostReportNormal;
        public Boolean stationerySalesAdmin;
        public Boolean stationerySalesNormal;
        public Boolean stationeryPurchaseAdmin;
        public Boolean stationeryPurchaseNormal;
        public Boolean stationeryReportAdmin;
        public Boolean stationeryReportNormal;
        public Boolean stationeryItemAdmin;
        public Boolean stationeryItemNormal;


        public int GetLevel()
        {
            return globalEmployeeLevel;
        }

        internal void StationerySalesPrintReceipt(int bayar)
        {
            createSalesS.printReceipt(bayar);
        }

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            SerialPort port = new SerialPort("COM4", 2400, Parity.None, 8, StopBits.One);
            port.Open();
            port.Write(" ");
            port.Close();

            //string txt = "1234567890 12345678901234567890 12345678901234567890 12345678901234567890 12345678901234567890 12345678901234567890 12345678901234567890 12345678901234567890";
            //MessageBox.Show(txt.Length + "");
            //for (int ix = 0; ix < txt.Length; )
            //{
            //    int chars;

            //    string temp;
            //    try
            //    {
            //        temp = txt.Substring(ix, 32);

            //        int spIdx = temp.LastIndexOf(" ");
            //        if (spIdx != -1)
            //        {
            //            chars = spIdx;
            //        }
            //        else
            //        {
            //            chars = 32;
            //        }
            //        MessageBox.Show(txt.Substring(ix, chars) + ", ix: " + ix);
            //        //textBox1.Text += txt.Substring(ix, chars) + "\n";
            //        //addY();

            //        //++line;
            //        ix += chars;
            //    }
            //    catch (Exception)
            //    {
            //        temp = txt.Substring(ix);
            //        MessageBox.Show(txt.Substring(ix) + ", ix: " + ix);
            //        //textBox1.Text += txt.Substring(ix) + "\n";
            //        break;
            //    }
            //}

            DisableRole();
            globalEmployeeID = -1;
            conn = new Config.Conn();
            conn.Connect();

            //MessageBox.Show(Util.Barcode.Barcode.buatHargaDariKode("P", 4000) + "");

            if (conn.isOpen() == true)
            {
                //SET TIME ZONE TO INDONESIA
                conn.ExecuteQuery("SET GLOBAL time_zone = '+07:00'");

                login = new DialogBox.LoginBox(this);
                login.ShowDialog();
                if (login.DialogResult != DialogResult.OK)
                {
                    Application.Exit();
                }
                else
                {
                    globalEmployeeID = login.Value;

                    DataTable getPositionID = conn.ExecuteQuery("SELECT role FROM MsEmployee WHERE employeeID = " + globalEmployeeID + "");
                    if (getPositionID.Rows.Count == 1)
                    {
                        globalEmployeeRole = Int32.Parse(getPositionID.Rows[0]["role"].ToString());
                        EnableRole(globalEmployeeRole);
                    }
                    else
                    {
                        MessageBox.Show("Login: Ambil Role - Tapi ga dapet, bisa dapet 0 atau >2");
                    }
                }
            }
            else
            {
                MessageBox.Show("Koneksi ke DB GAGAL, Jadi ga bisa munculin Login Box");
                Application.Exit();
            }
        }

        public DataTable ExecuteQuery(string query)
        {
            return conn.ExecuteQuery(query);
        }

        public DataSet ExecuteQueryDS(string query)
        {
            return conn.ExecuteQueryDS(query);
        }

        private void CloseAll()
        {
            //CLOSE ALL FORM HERE!

        }

        private void DisableRole()
        {
            menuStrip1.Enabled = false;
            //admin panel
            customerToolStripMenuItem.Enabled = false;
            employeeToolStripMenuItem.Enabled = false;
            pVCToolStripMenuItem1.Enabled = false;
            changeRoleToolStripMenuItem.Enabled = false;
            //admin > customer
            addNewCustomerToolStripMenuItem.Enabled = false;
            updateCustomerToolStripMenuItem.Enabled = false;
            viewAllCustomerToolStripMenuItem.Enabled = false;
            //admin > employee
            addNewEmployeeToolStripMenuItem.Enabled = false;
            updateEmployeeToolStripMenuItem.Enabled = false;
            viewAllEmployeeToolStripMenuItem.Enabled = false;
            //admin > pvc
            addPVCToolStripMenuItem.Enabled = false;
            updateHargaPVCRahayuToolStripMenuItem.Enabled = false;
            updateStockPVCRahayuToolStripMenuItem.Enabled = false;
            //
            salesToolStripMenuItem.Enabled = false;
            salesToolStripMenuItem1.Enabled = false;
            salesToolStripMenuItem2.Enabled = false;
            salesToolStripMenuItem3.Enabled = false;
            transferToolStripMenuItem.Enabled = false;
            purchaseToolStripMenuItem.Enabled = false;
            purchaseToolStripMenuItem1.Enabled = false;
            purchaseToolStripMenuItem2.Enabled = false;
            purchaseToolStripMenuItem3.Enabled = false;
            reportToolStripMenuItem.Enabled = false;
            reportToolStripMenuItem1.Enabled = false;
            reportToolStripMenuItem2.Enabled = false;
            reportToolStripMenuItem3.Enabled = false;
            printingFileToolStripMenuItem.Enabled = false;
            salesCloningToolStripMenuItem.Enabled = false;
            itemMasterToolStripMenuItem.Enabled = false;
            penjualanHarianToolStripMenuItem.Enabled = false;
            penjualanHarianToolStripMenuItem1.Enabled = false;
            penjualanHarianToolStripMenuItem2.Enabled = false;
            pelunasanBerdasarkanCustomerToolStripMenuItem.Enabled = false;
            pelunasanBerdasarkanCustomerToolStripMenuItem1.Enabled = false;
            pelunasanBerdasarkanJOBToolStripMenuItem.Enabled = false;
            pelunasanBerdasarkanJOBToolStripMenuItem1.Enabled = false;
            lihatPenjualanToolStripMenuItem.Enabled = false;
            rumahKeGrahaToolStripMenuItem.Enabled = false;
            rumahKeRahayuToolStripMenuItem.Enabled = false;
            lihatDataPembelianToolStripMenuItem.Enabled = false;
            hutangPerCustomerToolStripMenuItem.Enabled = false;
            penjualanBulananToolStripMenuItem.Enabled = false;
            penjualanBulananToolStripMenuItem1.Enabled = false;
            penjualanBulananToolStripMenuItem2.Enabled = false;
            penjualanTahunanToolStripMenuItem.Enabled = false;
            penjualanTahunanToolStripMenuItem1.Enabled = false;
            penjualanTahunanToolStripMenuItem2.Enabled = false;
            penjualanDiCabangToolStripMenuItem.Enabled = false;
            penjualanDiCabangToolStripMenuItem1.Enabled = false;
            penjualanDiRahayuToolStripMenuItem.Enabled = false;
            penjualanDiRahayuToolStripMenuItem1.Enabled = false;
            lihatSemuaPenjualanToolStripMenuItem.Enabled = false;
            //PRINTING > PRINTING FILES
            dataBuatPlatToolStripMenuItem.Enabled = false;
            dataPOToolStripMenuItem.Enabled = false;
            suratPenawaranToolStripMenuItem.Enabled = false;
            dataSettingToolStripMenuItem.Enabled = false;
            //PRINTING > SALES CLONING (MOCIL ROLES)
            createNotaCloneToolStripMenuItem.Enabled = false;
            editAllNotaToolStripMenuItem.Enabled = false;
            //KOST > SALES
            pembayaranPerbulanToolStripMenuItem.Enabled = false;
            lihatSeluruhPembayaranToolStripMenuItem.Enabled = false;
            pemindahanKamarToolStripMenuItem.Enabled = false;
            pembelianBarangToolStripMenuItem.Enabled = false;
            lihatSemuaPembelianBarangToolStripMenuItem.Enabled = false;
            hutangPerBulanToolStripMenuItem.Enabled = false;
            penjualanKeDIGITALToolStripMenuItem.Enabled = false;
            inputHargaModalToolStripMenuItem.Enabled = false;
            buatDaftarPembelianSementaraToolStripMenuItem.Enabled = false;
            masukkanDaftarPembelianToolStripMenuItem.Enabled = false;
            lihatDataPembelianTerakhirToolStripMenuItem.Enabled = false;
            labaRugiToolStripMenuItem.Enabled = false;
            stockAkhirDanSelisihToolStripMenuItem.Enabled = false;
            stockHabisToolStripMenuItem.Enabled = false;
            closingReportToolStripMenuItem.Enabled = false;
            lihatSemuaDaftarBarangToolStripMenuItem.Enabled = false;
            lihatBarangHakAdminToolStripMenuItem.Enabled = false;
            cetakBarcodeManualPerBarangToolStripMenuItem.Enabled = false;
            updateDataBarangToolStripMenuItem.Enabled = false;
            updateBarangHakAdminToolStripMenuItem.Enabled = false;
            inputBarangByBarcodeToolStripMenuItem.Enabled = false;
            inputStockByBarangToolStripMenuItem.Enabled = false;
            toolStripSeparator2.Enabled = false;
        }

        private void EnableRole(int positionID)
        {
            menuStrip1.Enabled = true;

            DataTable getRole = conn.ExecuteQuery("SELECT * FROM MsPosition WHERE positionID = " + positionID + "");
            if (getRole.Rows.Count == 1)
            {
                globalEmployeeLevel = Int32.Parse(getRole.Rows[0]["level"].ToString());

                customerAdmin = (getRole.Rows[0]["customerAdmin"].ToString() == "1") ? true : false;
                customerNormal = (getRole.Rows[0]["customerNormal"].ToString() == "1") ? true : false;
                employeeAdmin = (getRole.Rows[0]["employeeAdmin"].ToString() == "1") ? true : false;
                employeeNormal = (getRole.Rows[0]["employeeNormal"].ToString() == "1") ? true : false;
                changeRole = (getRole.Rows[0]["changeRole"].ToString() == "1") ? true : false;
                pvcItemAdmin = (getRole.Rows[0]["pvcItemAdmin"].ToString() == "1") ? true : false;
                pvcItemNormal = (getRole.Rows[0]["pvcItemNormal"].ToString() == "1") ? true : false;
                pvcSalesAdmin = (getRole.Rows[0]["pvcSalesAdmin"].ToString() == "1") ? true : false;
                pvcSalesNormal = (getRole.Rows[0]["pvcSalesNormal"].ToString() == "1") ? true : false;
                pvcPurchaseAdmin = (getRole.Rows[0]["pvcPurchaseAdmin"].ToString() == "1") ? true : false;
                pvcPurchaseNormal = (getRole.Rows[0]["pvcPurchaseNormal"].ToString() == "1") ? true : false;
                pvcTransferAdmin = (getRole.Rows[0]["pvcTransferAdmin"].ToString() == "1") ? true : false;
                pvcTransferNormal = (getRole.Rows[0]["pvcTransferNormal"].ToString() == "1") ? true : false;
                pvcReportAdmin = (getRole.Rows[0]["pvcReportAdmin"].ToString() == "1") ? true : false;
                pvcReportNormal = (getRole.Rows[0]["pvcReportNormal"].ToString() == "1") ? true : false;
                printingSalesAdmin = (getRole.Rows[0]["printingSalesAdmin"].ToString() == "1") ? true : false;
                printingSalesNormal = (getRole.Rows[0]["printingSalesNormal"].ToString() == "1") ? true : false;
                printingPurchaseAdmin = (getRole.Rows[0]["printingPurchaseAdmin"].ToString() == "1") ? true : false;
                printingPurchaseNormal = (getRole.Rows[0]["printingPurchaseNormal"].ToString() == "1") ? true : false;
                printingReportAdmin = (getRole.Rows[0]["printingReportAdmin"].ToString() == "1") ? true : false;
                printingReportNormal = (getRole.Rows[0]["printingReportNormal"].ToString() == "1") ? true : false;
                printingFileAdmin = (getRole.Rows[0]["printingFileAdmin"].ToString() == "1") ? true : false;
                printingFileNormal = (getRole.Rows[0]["printingFileNormal"].ToString() == "1") ? true : false;
                printingSalesCloneAdmin = (getRole.Rows[0]["printingSalesCloneAdmin"].ToString() == "1") ? true : false;
                printingSalesCloneNormal = (getRole.Rows[0]["printingSalesCloneNormal"].ToString() == "1") ? true : false;
                kostSalesAdmin = (getRole.Rows[0]["kostSalesAdmin"].ToString() == "1") ? true : false;
                kostSalesNormal = (getRole.Rows[0]["kostSalesNormal"].ToString() == "1") ? true : false;
                kostPurchaseAdmin = (getRole.Rows[0]["kostPurchaseAdmin"].ToString() == "1") ? true : false;
                kostPurchaseNormal = (getRole.Rows[0]["kostPurchaseNormal"].ToString() == "1") ? true : false;
                kostReportAdmin = (getRole.Rows[0]["kostReportAdmin"].ToString() == "1") ? true : false;
                kostReportNormal = (getRole.Rows[0]["kostReportNormal"].ToString() == "1") ? true : false;
                stationerySalesAdmin = (getRole.Rows[0]["stationerySalesAdmin"].ToString() == "1") ? true : false;
                stationerySalesNormal = (getRole.Rows[0]["stationerySalesNormal"].ToString() == "1") ? true : false;
                stationeryPurchaseAdmin = (getRole.Rows[0]["stationeryPurchaseAdmin"].ToString() == "1") ? true : false;
                stationeryPurchaseNormal = (getRole.Rows[0]["stationeryPurchaseNormal"].ToString() == "1") ? true : false;
                stationeryReportAdmin = (getRole.Rows[0]["stationeryReportAdmin"].ToString() == "1") ? true : false;
                stationeryReportNormal = (getRole.Rows[0]["stationeryReportNormal"].ToString() == "1") ? true : false;
                stationeryItemAdmin = (getRole.Rows[0]["stationeryItemAdmin"].ToString() == "1") ? true : false;
                stationeryItemNormal = (getRole.Rows[0]["stationeryItemNormal"].ToString() == "1") ? true : false;

                if (customerAdmin)
                {
                    addNewCustomerToolStripMenuItem.Enabled = true;
                    updateCustomerToolStripMenuItem.Enabled = true;
                    viewAllCustomerToolStripMenuItem.Enabled = true;
                }
                if (customerNormal)
                {
                    addNewCustomerToolStripMenuItem.Enabled = true;
                    viewAllCustomerToolStripMenuItem.Enabled = true;
                }
                if (customerNormal || customerAdmin)
                {
                    customerToolStripMenuItem.Enabled = true;
                }
                if (employeeAdmin)
                {
                    addNewEmployeeToolStripMenuItem.Enabled = true;
                    updateEmployeeToolStripMenuItem.Enabled = true;
                    viewAllEmployeeToolStripMenuItem.Enabled = true;
                }
                if (employeeNormal)
                {
                    addNewEmployeeToolStripMenuItem.Enabled = true;
                    viewAllEmployeeToolStripMenuItem.Enabled = true;
                }
                if (employeeNormal || employeeAdmin)
                {
                    customerToolStripMenuItem.Enabled = true;
                }
                if (changeRole)
                {
                    toolStripSeparator2.Enabled = true;
                    changeRoleToolStripMenuItem.Enabled = true;
                }
                if (pvcItemAdmin)
                {
                    addPVCToolStripMenuItem.Enabled = true;
                    updateHargaPVCRahayuToolStripMenuItem.Enabled = true;
                    updateStockPVCRahayuToolStripMenuItem.Enabled = true;
                }
                if (pvcItemNormal)
                {
                    addPVCToolStripMenuItem.Enabled = true;
                    updateHargaPVCRahayuToolStripMenuItem.Enabled = true;
                }
                if (pvcItemAdmin || pvcItemNormal)
                {
                    pVCToolStripMenuItem1.Enabled = true;
                }
                if (pvcSalesAdmin)
                {
                    penjualanHarianToolStripMenuItem1.Enabled = true;
                    pelunasanBerdasarkanJOBToolStripMenuItem.Enabled = true;
                    pelunasanBerdasarkanCustomerToolStripMenuItem1.Enabled = true;
                    lihatPenjualanToolStripMenuItem.Enabled = true;
                }
                if (pvcSalesNormal)
                {
                    penjualanHarianToolStripMenuItem1.Enabled = true;
                    pelunasanBerdasarkanCustomerToolStripMenuItem1.Enabled = true;
                    pelunasanBerdasarkanJOBToolStripMenuItem.Enabled = true;
                    lihatPenjualanToolStripMenuItem.Enabled = true;
                }
                if (pvcSalesAdmin || pvcSalesNormal)
                {
                    salesToolStripMenuItem.Enabled = true;
                }
                if (pvcPurchaseAdmin)
                {
                    pesananKeChinaToolStripMenuItem.Enabled = true;
                    lihatPesananYgDatangToolStripMenuItem.Enabled = true;
                    lihatPesananYgPendingToolStripMenuItem.Enabled = true;
                    lihatDataPembelianToolStripMenuItem.Enabled = true;
                }
                if (pvcPurchaseNormal)
                {
                    lihatDataPembelianToolStripMenuItem.Enabled = true;
                }
                if (pvcPurchaseAdmin || pvcPurchaseNormal)
                {
                    purchaseToolStripMenuItem.Enabled = true;
                }
                if (pvcTransferAdmin)
                {
                    rumahKeGrahaToolStripMenuItem.Enabled = true;
                    rumahKeRahayuToolStripMenuItem.Enabled = true;
                    lihatDataTransferToolStripMenuItem.Enabled = true;
                }
                if (pvcTransferNormal)
                {
                    lihatDataTransferToolStripMenuItem.Enabled = true;
                }
                if (pvcTransferAdmin || pvcTransferNormal)
                {
                    transferToolStripMenuItem.Enabled = true;
                }
                if (pvcReportAdmin)
                {
                    penjualanBulananToolStripMenuItem.Enabled = true;
                    hutangPerCustomerToolStripMenuItem.Enabled = true;
                    penjualanTahunanToolStripMenuItem.Enabled = true;
                    penjualanBulananToolStripMenuItem.Enabled = true;
                }
                if (pvcReportNormal)
                {
                    penjualanBulananToolStripMenuItem.Enabled = true;
                    hutangPerCustomerToolStripMenuItem.Enabled = true;
                }
                if (pvcReportAdmin || pvcReportNormal)
                {
                    reportToolStripMenuItem.Enabled = true;
                }
                if (printingSalesAdmin)
                {
                    //penjualanDiRahayuToolStripMenuItem.Enabled = true;
                    penjualanDiCabangToolStripMenuItem.Enabled = true;
                    pelunasanBerdasarkanJOBToolStripMenuItem1.Enabled = true;
                    pelunasanBerdasarkanCustomerToolStripMenuItem.Enabled = true;
                    lihatSemuaPenjualanToolStripMenuItem.Enabled = true;
                }
                if (printingSalesNormal)
                {
                    //penjualanDiRahayuToolStripMenuItem.Enabled = true;
                    lihatSemuaPenjualanToolStripMenuItem.Enabled = true;
                }
                if (printingSalesAdmin || printingSalesNormal)
                {
                    salesToolStripMenuItem1.Enabled = true;
                }
                if (printingPurchaseAdmin)
                {
                    pembayaranBahanToolStripMenuItem.Enabled = true;
                }
                if (printingPurchaseNormal)
                {
                    pembayaranBahanToolStripMenuItem.Enabled = true;
                }
                if (printingPurchaseAdmin || printingPurchaseNormal)
                {
                    purchaseToolStripMenuItem1.Enabled = true;
                }
                if (printingReportAdmin)
                {
                    penjualanHarianToolStripMenuItem2.Enabled = true;
                    hutangPerCustomerToolStripMenuItem1.Enabled = true;
                    penjualanBulananToolStripMenuItem1.Enabled = true;
                    penjualanTahunanToolStripMenuItem1.Enabled = true;
                }
                if (printingReportNormal)
                {
                    penjualanHarianToolStripMenuItem2.Enabled = true;
                    hutangPerCustomerToolStripMenuItem1.Enabled = true;
                }
                if (printingReportAdmin || printingReportNormal)
                {
                    reportToolStripMenuItem1.Enabled = true;
                }
                if (printingFileAdmin)
                {
                    dataBuatPlatToolStripMenuItem.Enabled = true;
                    dataPOToolStripMenuItem.Enabled = true;
                    suratPenawaranToolStripMenuItem.Enabled = true;
                    dataSettingToolStripMenuItem.Enabled = true;
                }
                if (printingFileNormal)
                {
                    dataBuatPlatToolStripMenuItem.Enabled = true;
                    dataSettingToolStripMenuItem.Enabled = true;
                }
                if (printingFileAdmin || printingFileNormal)
                {
                    printingFileToolStripMenuItem.Enabled = true;
                }
                if (printingSalesCloneAdmin)
                {
                    createNotaCloneToolStripMenuItem.Enabled = true;
                    editAllNotaToolStripMenuItem.Enabled = true;
                }
                if (printingSalesCloneNormal)
                {
                    createNotaCloneToolStripMenuItem.Enabled = true;
                }
                if (printingSalesCloneAdmin || printingSalesCloneNormal)
                {
                    salesCloningToolStripMenuItem.Enabled = true;
                }
                if (kostSalesAdmin)
                {
                    pembayaranPerbulanToolStripMenuItem.Enabled = true;
                    lihatSeluruhPembayaranToolStripMenuItem.Enabled = true;
                    pemindahanKamarToolStripMenuItem.Enabled = true;
                }
                if (kostSalesNormal)
                {
                    pembayaranPerbulanToolStripMenuItem.Enabled = true;
                    lihatSeluruhPembayaranToolStripMenuItem.Enabled = true;
                }
                if (kostSalesAdmin || kostSalesNormal)
                {
                    salesToolStripMenuItem2.Enabled = true;
                }
                if (kostPurchaseAdmin)
                {
                    pembelianBarangToolStripMenuItem.Enabled = true;
                    lihatSemuaPembelianBarangToolStripMenuItem.Enabled = true;
                }
                if (kostPurchaseNormal)
                {
                    lihatSemuaPembelianBarangToolStripMenuItem.Enabled = true;
                }
                if (kostPurchaseAdmin || kostPurchaseNormal)
                {
                    purchaseToolStripMenuItem2.Enabled = true;
                }
                if (kostReportAdmin)
                {
                    laporanBulananToolStripMenuItem.Enabled = true;
                    laporanTahunanToolStripMenuItem.Enabled = true;
                    hutangPerBulanToolStripMenuItem.Enabled = true;
                }
                if (kostReportNormal)
                {
                    laporanBulananToolStripMenuItem.Enabled = true;
                }
                if (kostReportAdmin || kostReportNormal)
                {
                    reportToolStripMenuItem2.Enabled = true;
                }
                if (stationerySalesAdmin)
                {
                    penjualanDiRahayuToolStripMenuItem1.Enabled = true;
                    penjualanDiCabangToolStripMenuItem1.Enabled = true;
                    penjualanKeDIGITALToolStripMenuItem.Enabled = true;
                }
                if (stationerySalesNormal)
                {
                    penjualanDiRahayuToolStripMenuItem1.Enabled = true;
                }
                if (stationerySalesNormal || stationerySalesAdmin)
                {
                    salesToolStripMenuItem3.Enabled = true;
                }
                if (stationeryPurchaseAdmin)
                {
                    inputHargaModalToolStripMenuItem.Enabled = true;
                    buatDaftarPembelianSementaraToolStripMenuItem.Enabled = true;
                    masukkanDaftarPembelianToolStripMenuItem.Enabled = true;
                    lihatDataPembelianTerakhirToolStripMenuItem.Enabled = true;
                }
                if (stationeryPurchaseNormal)
                {
                    buatDaftarPembelianSementaraToolStripMenuItem.Enabled = true;
                    masukkanDaftarPembelianToolStripMenuItem.Enabled = true;
                }
                if (stationeryPurchaseAdmin || stationeryPurchaseNormal)
                {
                    purchaseToolStripMenuItem3.Enabled = true;
                }
                if (stationeryReportAdmin)
                {
                    penjualanBulananToolStripMenuItem2.Enabled = true;
                    penjualanTahunanToolStripMenuItem2.Enabled = true;
                    labaRugiToolStripMenuItem.Enabled = true;
                    stockAkhirDanSelisihToolStripMenuItem.Enabled = true;
                    stockHabisToolStripMenuItem.Enabled = true;
                    closingReportToolStripMenuItem.Enabled = true;
                }
                if (stationeryReportNormal)
                {
                    stockHabisToolStripMenuItem.Enabled = true;
                }
                if (stationeryReportNormal || stationeryReportAdmin)
                {
                    reportToolStripMenuItem3.Enabled = true;
                }
                if (stationeryItemAdmin)
                {
                    //lihatSemuaDaftarBarangToolStripMenuItem.Enabled = true;
                    lihatBarangHakAdminToolStripMenuItem.Enabled = true;
                    cetakBarcodeManualPerBarangToolStripMenuItem.Enabled = true;
                    inputBarangByBarcodeToolStripMenuItem.Enabled = true;
                    //updateDataBarangToolStripMenuItem.Enabled = true;
                    //updateBarangHakAdminToolStripMenuItem.Enabled = true;
                    //inputStockByBarangToolStripMenuItem.Enabled = true;
                }
                if (stationeryItemNormal)
                {
                    cetakBarcodeManualPerBarangToolStripMenuItem.Enabled = true;
                    inputBarangByBarcodeToolStripMenuItem.Enabled = true;
                }
                if (stationeryItemAdmin || stationeryItemNormal)
                {
                    itemMasterToolStripMenuItem.Enabled = true;
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try { Application.Exit(); }
            catch (Exception) { Application.Exit(); }
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisableRole();
            MainForm_Load(sender, e);
        }

        Stationery.Sales.CreateSalesStationery createSalesS;

        private void penjualanDiRahayuToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (createSalesS == null)
                createSalesS = new Stationery.Sales.CreateSalesStationery(this);

            createSalesS.Show();
            createSalesS.BringToFront();
        }

        Stationery.Sales.InputBarangByBarcode inputBarang;

        public void inputBarangByBarcodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (inputBarang == null)
                inputBarang = new Stationery.Sales.InputBarangByBarcode(this);

            inputBarang.Show();
            inputBarang.BringToFront();

        }

        Stationery.MsBarang.PrintBarcode printBarcode;

        private void cetakBarcodeManualPerBarangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (printBarcode == null)
                printBarcode = new Stationery.MsBarang.PrintBarcode(this);

            printBarcode.Show();
            printBarcode.BringToFront();
        }

        Stationery.MsBarang.LihatSemuaDaftarBarang lihatBarang;

        private void lihatSemuaDaftarBarangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lihatBarang == null)
                lihatBarang = new Stationery.MsBarang.LihatSemuaDaftarBarang(this);
            
            lihatBarang.Show();
            lihatBarang.BringToFront();
        }

        Stationery.MsBarang.InputStockByBarang inputStock;

        private void inputStockByBarangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (inputStock == null)
                inputStock = new Stationery.MsBarang.InputStockByBarang(this);

            inputStock.Show();
            inputStock.BringToFront();
        }

        Stationery.MsBarang.PrintStockHabis laporanStockHabis;

        private void stockHabisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (laporanStockHabis == null)
                laporanStockHabis = new Stationery.MsBarang.PrintStockHabis(this);

            laporanStockHabis.Show();
            laporanStockHabis.BringToFront();
        }

        Stationery.Purchase.InputPembelian inputPembelian;

        private void inputHargaModalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (inputPembelian == null)
                inputPembelian = new Stationery.Purchase.InputPembelian(this);

            inputPembelian.Show();
            inputPembelian.BringToFront();
        }

        Stationery.Report.ClosingReport report;

        private void closingReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (report == null)
                report = new Stationery.Report.ClosingReport(this);

            report.Show();
            report.BringToFront();
        }

        Rahayu_Program.PVC.Report.ClosingReport closing;

        private void closingFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closing = new PVC.Report.ClosingReport(this);
            closing.Show();
        }

        int count = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (count < 5)
            {
                count++;
            }
            else if (count == 5)
            {
                count = 0;
                toolStripStatusLabel1.Text = "";
                timer1.Enabled = false;
            }
        }

        public void SetMessage(string message)
        {
            toolStripStatusLabel1.Text = message;
            timer1.Enabled = true;
        }

        public Rahayu_Program.PVC.Sales.CreateSalesPVC createSalesPVC;

        private void penjualanHarianToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if(createSalesPVC == null) createSalesPVC = new PVC.Sales.CreateSalesPVC(this);
            createSalesPVC.Show();
        }

        public Rahayu_Program.PVC.Sales.ViewAllSales viewSalesPVC;

        private void lihatPenjualanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (viewSalesPVC == null) viewSalesPVC = new PVC.Sales.ViewAllSales(this);
            viewSalesPVC.Show();
        }

        public void PVCSalesPrintReceipt(int pvcSalesID)
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(printSalesReceipt);
            pd.PrinterSettings.PrinterName = System.IO.File.ReadAllText(Application.StartupPath + @"\config\printer\pvc-sales-nota.is");
            pd.PrintController = new StandardPrintController();

            //PrintDialog printDialog1 = new PrintDialog();
            //printDialog1.Document = pd;
            //DialogResult result = printDialog1.ShowDialog();
            //MessageBox.Show(printDialog1.PrinterSettings.PrinterName);

            this.pvcSalesID = pvcSalesID;

            try
            {
                pd.Print();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public int pvcSalesID;

        private void printSalesReceipt(object o, PrintPageEventArgs e)
        {
            DataTable header = ExecuteQuery("SELECT DATE_FORMAT(salesTime, '%d/%m/%Y %H:%i:%s') AS salesTime, customerName, phone FROM PVCSalesHeader psh, MSCustomer mc WHERE mc.customerID = psh.customerID AND pvcSalesID = " + pvcSalesID + "");
            DataTable detail = ExecuteQuery("SELECT mp.pvcName, psd.quantity, psd.sellPrice, mp.pvcPerPack, mp.pvcTypeUnit FROM PVCSalesDetail psd, MsPVC mp WHERE mp.pvcID = psd.pvcID AND pvcSalesID = " + pvcSalesID + "");
            DataTable payment = ExecuteQuery("SELECT ammount, paymentMethod, DATE_FORMAT(paymentTime, '%d/%m/%Y %H:%i:%s') AS paymentTime FROM PVCSalesPayment WHERE pvcSalesID = " + pvcSalesID + "");

            Font f = new Font("Courier New", 12, FontStyle.Regular);
            Rahayu_Program.Util.PVCSalesNota.printSalesReceipt(e.Graphics, f, pvcSalesID, header, detail, payment);
        }

        PVC.Transfer.PVCNewTransfer pvcNewTransfer;

        private void rumahKeRahayuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(pvcNewTransfer == null) pvcNewTransfer = new PVC.Transfer.PVCNewTransfer(this);
            pvcNewTransfer.Show();
        }

        public void PVCTransferPrintReceipt(int pvcTransferID)
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(printTransferReceipt);
            pd.PrinterSettings.PrinterName = System.IO.File.ReadAllText(Application.StartupPath + @"\config\printer\pvc-transfer-nota.is");
            pd.PrintController = new StandardPrintController();

            //PrintDialog printDialog1 = new PrintDialog();
            //printDialog1.Document = pd;
            //DialogResult result = printDialog1.ShowDialog();
            //MessageBox.Show(printDialog1.PrinterSettings.PrinterName);

            this.pvcTransferID = pvcTransferID;

            try
            {
                pd.Print();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public int pvcTransferID;

        private void printTransferReceipt(object o, PrintPageEventArgs e)
        {
            DataTable header = ExecuteQuery("SELECT DATE_FORMAT(transferTime, '%d/%m/%Y %H:%i:%s') AS transferTime, deliveryOfficer FROM PVCTransferHeader WHERE pvcTransferID = " + pvcTransferID + "");
            DataTable detail = ExecuteQuery("SELECT mp.pvcName, ptd.quantity, mp.pvcPerPack, mp.pvcTypeUnit FROM PVCTransferDetail ptd, MsPVC mp WHERE mp.pvcID = ptd.pvcID AND ptd.pvcTransferID = " + pvcTransferID + "");

            Font f = new Font("Courier New", 12, FontStyle.Regular);
            Rahayu_Program.Util.PVCTransferNota.printTransferReceipt(e.Graphics, f, pvcSalesID, header, detail);
        }

        public void PVCCreateSalesAddDetail()
        {
            //CUMA TRANSFER DARI PAYMENT KE CREATE SALES PVC
            createSalesPVC.AddDetail();
        }

        private Rahayu_Program.Timer.SettingTimer timer;

        private void hitungJamSettingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataSettingToolStripMenuItem.Enabled == true)
            {
                timer = new Timer.SettingTimer(this);
                timer.Show();
                timer.BringToFront();
            }
            else
            {
                SetMessage("Tidak punya hak untuk masuk ke hitung Jam setting");
            }
        }
        
        Printing.Sales.CreateSalesPrinting createSalesPrinting;

        private void penjualanDiRahayuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        public void openCreateSalesPrinting()
        {
            if (createSalesPrinting == null) createSalesPrinting = new Printing.Sales.CreateSalesPrinting(this);
            createSalesPrinting.Show();
            createSalesPrinting.RefreshWindow();
            createSalesPrinting.BringToFront();
        }

        public void openCreateSalesPrinting(int printingSalesID)
        {
            if (createSalesPrinting == null) createSalesPrinting = new Printing.Sales.CreateSalesPrinting(this);
            createSalesPrinting.Show();
            createSalesPrinting.RefreshWindow(printingSalesID);
            createSalesPrinting.BringToFront();
        }

        Master.PVC.UpdateStockPVC updateStockPVC;

        private void updateStockPVCRahayuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            updateStockPVC = new Master.PVC.UpdateStockPVC(this);
            updateStockPVC.Show();
            updateStockPVC.BringToFront();
        }

        Stationery.GodHands.StationeryGodHands godHands;

        private void lihatBarangHakAdminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (godHands == null) godHands = new Stationery.GodHands.StationeryGodHands(this);
            godHands.Show();
            godHands.BringToFront();
        }

        PrintingManualSales createNotaClone;

        public void createNotaCloneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (createNotaClone == null) createNotaClone = new PrintingManualSales(this);
            createNotaClone.Show();
            createNotaClone.BringToFront();
            createNotaClone.clearField();
        }

        PrintingManualEditSales editNotaClone;

        public void editAllNotaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (editNotaClone == null) editNotaClone = new PrintingManualEditSales(this);
            editNotaClone.Show();
            editNotaClone.BringToFront();
            editNotaClone.clearField();
        }

        private void updateHargaPVCRahayuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdatePricePVC updatePricePVC = new UpdatePricePVC(this);
            updatePricePVC.ShowDialog();
            updatePricePVC.BringToFront();
        }

        public ShowSalesPrinting showSalesPrinting;

        public void setSelectedPrintingSalesID(int salesID)
        {
            showSalesPrinting.setSelectedPrintingSalesID(salesID);
            showSalesPrinting.BringToFront();
        }
        
        private void lihatSemuaPenjualanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (showSalesPrinting == null) showSalesPrinting = new ShowSalesPrinting(this);
            showSalesPrinting.Show();
            showSalesPrinting.BringToFront();
        }

        private void lihatSemuaPenjualanToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        Printing.Report.ClosingReport printingClosingReport;

        private void penjualanHarianToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            printingClosingReport = new Printing.Report.ClosingReport(this);
            printingClosingReport.Show();
            printingClosingReport.BringToFront();
        }

        CreateTandaTerima tukarFaktur;

        internal void ShowCreateTandaTerima()
        {
            if (tukarFaktur == null) tukarFaktur = new CreateTandaTerima(this);
            tukarFaktur.Show();
            tukarFaktur.ClearData();
            tukarFaktur.BringToFront();
        }

        public OpenPDF openPDF;

        internal void ShowOpenPDF(string filename)
        {
            if (openPDF == null) openPDF = new OpenPDF(this, filename);
            openPDF.Show();
            openPDF.BringToFront();
        }

        internal void ShowSalesPrintingRefresh()
        {
            showSalesPrinting.RefreshHeader();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Master.Employee.ChangePassword chpass = new Master.Employee.ChangePassword(this);
            chpass.ShowDialog();
        }
    }
}
