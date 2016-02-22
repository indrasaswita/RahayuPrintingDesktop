using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Rahayu_Program.Report;

namespace Rahayu_Program.Printing.Sales.SalesClone
{
    public partial class PrintingManualEditSales : Form
    {
        private MainForm main;
        private string noNota;
        private string printTitle, printType;

        public PrintingManualEditSales(MainForm main)
        {
            this.main = main;
            this.MdiParent = main;
            InitializeComponent();
        }

        private void PrintingManualEditSales_Load(object sender, EventArgs e)
        {
        }

        public void clearField()
        {
            clearHeader();
            clearDetail();
            refreshHeader();
        }

        private void clearDetail()
        {
            gridDetail.Rows.Clear();
            gridDetail.Columns.Clear();
            gridDetail.Columns.Add("Judul", "Judul");
            gridDetail.Columns[0].Width = 170;
            gridDetail.Columns.Add("Tipe", "Tipe");
            gridDetail.Columns[1].Width = 110;
            gridDetail.Columns.Add("Deskripsi", "Deskripsi");
            gridDetail.Columns[2].Width = 200;
            gridDetail.Columns.Add("Material", "Material");
            gridDetail.Columns[3].Width = 100;
            gridDetail.Columns.Add("OngkosCetak", "O. Cetak");
            gridDetail.Columns[4].Width = 100;
        }

        private void clearHeader()
        {
            gridHeader.Rows.Clear();
            gridHeader.Columns.Clear();
            gridHeader.Columns.Add("NoNota", "No. NOTA");
            gridHeader.Columns[0].Width = 145;
            gridHeader.Columns.Add("JamNota", "Tanggal Nota");
            gridHeader.Columns[1].Width = 145;
            gridHeader.Columns.Add("Customer", "Customer");
            gridHeader.Columns[2].Width = 170;
            gridHeader.Columns.Add("PO", "PO");
            gridHeader.Columns[3].Visible = false;
            gridHeader.Columns.Add("Up", "Up");
            gridHeader.Columns[4].Visible = false;
            gridHeader.Columns.Add("Up", "Terbilang");
            gridHeader.Columns[5].Visible = false;
        }

        private DataTable ExecuteQuery(string query)
        {
            return main.ExecuteQuery(query);
        }

        private void refreshHeader()
        {
            DataTable dt = ExecuteQuery("SELECT printingSalesCloneID, DATE_FORMAT(salesTime, '%d/%m/%Y %H:%i:%s') AS printTime, purchaseNo, customerCompany, customerUp, terbilang FROM PrintingSalesCloneHeader");
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    gridHeader.Rows.Clear();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        string notaNo = dt.Rows[i]["printingSalesCloneID"].ToString();
                        DateTime printTime = Other.Parser.TimeFromString(dt.Rows[i]["printTime"].ToString());
                        string purchaseNo = dt.Rows[i]["purchaseNo"].ToString();
                        string customerCompany = dt.Rows[i]["customerCompany"].ToString();
                        string customerUp = dt.Rows[i]["customerUp"].ToString();
                        string terbilang = dt.Rows[i]["terbilang"].ToString();

                        gridHeader.Rows.Add(notaNo, printTime.ToString("ddd, dd/MM/yyyy"), customerCompany, purchaseNo, customerUp, terbilang);
                    }
                }
                else
                    gridHeader.Rows.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            refreshHeader();
        }

        private void gridHeader_SelectionChanged(object sender, EventArgs e)
        {
            noNota = ""; //bydefault
            if (gridHeader.Rows.Count > 0)
            {
                RefreshDetail();
            }
        }

        private void RefreshDetail()
        {
            int index = gridHeader.CurrentRow.Index;
            if (index >= 0 && index <= gridHeader.Rows.Count - 1)
            {
                noNota = gridHeader.Rows[index].Cells[0].Value.ToString();
                tbPurchaseNo.Text = gridHeader.Rows[index].Cells[3].Value.ToString();
                tbCustomerUp.Text = gridHeader.Rows[index].Cells[4].Value.ToString();
                tbTerbilang.Text = gridHeader.Rows[index].Cells[5].Value.ToString();
                DataTable dt = ExecuteQuery("SELECT * FROM PrintingSalesCloneDetail WHERE printingSalesCloneID = '" + noNota + "'");
                gridDetail.Rows.Clear();
                if (dt != null)
                {
                    if (dt.Rows.Count > 0)
                    {
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            gridDetail.Rows.Add(dt.Rows[i]["printingTitle"].ToString(), dt.Rows[i]["printingType"].ToString(), dt.Rows[i]["description"].ToString(), dt.Rows[i]["material"].ToString(), dt.Rows[i]["ongkosCetak"].ToString());
                        }
                    }
                }
            }
            
        }

        private void gridDetail_SelectionChanged(object sender, EventArgs e)
        {
            printTitle = "";
            printType = "";

            tbJudul.Text = "";
            tbTipe.Text = "";
            tbDeskripsi.Text = "";
            nudMaterial.Value = 0;
            nudOngkosCetak.Value = 0;
            nudTotalHarga.Value = 0;

            if (gridDetail.Rows.Count > 0)
            {
                int index = gridDetail.CurrentRow.Index;
                if (index >= 0 && index <= gridDetail.Rows.Count - 1)
                {
                    printTitle = gridDetail.Rows[index].Cells[0].Value.ToString();
                    printType = gridDetail.Rows[index].Cells[1].Value.ToString();
                    tbJudul.Text = printTitle;
                    tbTipe.Text = printType;
                    tbDeskripsi.Text = gridDetail.Rows[index].Cells[2].Value.ToString();
                    nudMaterial.Value = Int32.Parse(gridDetail.Rows[index].Cells[3].Value.ToString());
                    nudOngkosCetak.Value = Int32.Parse(gridDetail.Rows[index].Cells[4].Value.ToString());
                    nudTotalHarga.Value = nudMaterial.Value + nudOngkosCetak.Value;
                }
            }
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

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (noNota != "")
            {
                DataTable dt = main.ExecuteQuery("SELECT psch.printingSalesCloneID, purchaseNo, salesTime as printTime, customerCompany, customerUp, printingTitle as printTitle, printingType as printType, terbilang, description, material, ongkosCetak FROM PrintingSalesCloneHeader psch, PrintingSalesCloneDetail pscd WHERE psch.printingSalesCloneID = pscd.printingSalesCloneID AND psch.printingSalesCloneID = '" + noNota + "'");

                if (dt == null)
                {
                    MessageBox.Show("ERROR PRINT REPORT (LAPORAN GROUP DI CLOSING FORM STATIONERY)");
                    this.Dispose();
                }
                else
                {
                    if (dt.Rows.Count > 0)
                    {
                        Rahayu_Program.Report.PrintingSales.NotaManualSales laporan = new Rahayu_Program.Report.PrintingSales.NotaManualSales();
                        laporan.SetDataSource(dt);

                        buatLaporanByQuery(laporan);
                    }
                    else
                    {
                        MessageBox.Show("DATA TIDAK ADA (LAPORAN MsBARANG DI CLOSING FORM STATIONERY)");
                    }
                }
            }
        }

        PrintingSalesCloneEditHeader editHeader;

        private void btnEditHeader_Click(object sender, EventArgs e)
        {
            editHeader = new PrintingSalesCloneEditHeader(main, noNota);
            editHeader.ShowDialog();
            refreshHeader();
        }

        private void btnAddNota_Click(object sender, EventArgs e)
        {
            main.createNotaCloneToolStripMenuItem_Click(sender, e);
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        PrintingSalesCloneEditDetail editDetail;

        private void btnEditDetail_Click(object sender, EventArgs e)
        {
            editDetail = new PrintingSalesCloneEditDetail(main, noNota, printTitle, printType);
            editDetail.ShowDialog();
            RefreshDetail();
        }

        private void gridDetail_DoubleClick(object sender, EventArgs e)
        {
            btnEditDetail_Click(sender, e);
        }

        private void btnDeleteDetail_Click(object sender, EventArgs e)
        {
            if (gridDetail.Rows.Count > 0)
            {
                int index = gridDetail.CurrentRow.Index;
                if (index > -1 && index < gridDetail.Rows.Count)
                {
                    ExecuteQuery("DELETE FROM PrintingSalesCloneDetail WHERE printingSalesCloneID = '" + gridHeader.Rows[gridHeader.CurrentRow.Index].Cells[0].Value + "' AND printingTitle = '" + gridDetail.Rows[index].Cells[0].Value + "' AND printingType = '" + gridDetail.Rows[index].Cells[1].Value  + "'");
                    RefreshDetail();
                }
            }
        }

    }
}
