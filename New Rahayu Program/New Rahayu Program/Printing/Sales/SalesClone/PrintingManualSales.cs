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
    public partial class PrintingManualSales : Form
    {
        private MainForm main;

        public PrintingManualSales(MainForm main)
        {
            this.main = main;
            this.MdiParent = main;
            InitializeComponent();
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
            DataTable dt = main.ExecuteQuery("SELECT psch.printingSalesCloneID, purchaseNo, salesTime as printTime, customerCompany, customerUp, printingTitle as printTitle, printingType as printType, terbilang, description, material, ongkosCetak FROM PrintingSalesCloneHeader psch, PrintingSalesCloneDetail pscd WHERE psch.printingSalesCloneID = pscd.printingSalesCloneID AND psch.printingSalesCloneID = '" + tbNoNota.Text + "'");

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

        private void PrintingManualSales_Load(object sender, EventArgs e)
        {
            clearField();
        }

        public void clearField()
        {
            gridDetail.Rows.Clear();
            gridDetail.Columns.Clear();
            gridDetail.Columns.Add("", "Judul Barang");
            gridDetail.Columns[0].Width = 200;
            gridDetail.Columns.Add("", "Tipe Kerjaan");
            gridDetail.Columns[1].Width = 160;
            gridDetail.Columns.Add("", "Deskripsi");
            gridDetail.Columns[2].Width = 450;
            gridDetail.Columns.Add("", "Harga Material");
            gridDetail.Columns[3].Width = 150;
            gridDetail.Columns.Add("", "Ongkos Cetak");
            gridDetail.Columns[4].Width = 150;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            gridDetail.Rows.Add(tbPrintTitle.Text, tbPrintType.Text, tbDesc.Text, nudMaterial.Value, nudOngkosCetak.Value);
        }

        public DataTable ExecuteQuery(string query)
        {
            return main.ExecuteQuery(query);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DataTable dt = ExecuteQuery("SELECT * FROM PrintingSalesCloneHeader WHERE printingSalesCloneID = '" + tbNoNota.Text + "'");
            if (dt != null)
            {
                if (dt.Rows.Count == 0)
                {
                    ExecuteQuery("INSERT INTO PrintingSalesCloneHeader VALUES ('" + tbNoNota.Text + "', '" + dtpWaktu.Value.ToString("yyyy-MM-dd") + "', now(), '" + tbNoPO.Text + "', '" + tbNamaPT.Text + "', '" + tbNamaUP.Text + "', '" + tbTerbilang.Text + "')");
                    for (int i = 0; i < gridDetail.Rows.Count; i++)
                    {
                        ExecuteQuery("INSERT INTO PrintingSalesCloneDetail VALUES ('" + tbNoNota.Text + "', '" + gridDetail.Rows[i].Cells[0].Value + "', '" + gridDetail.Rows[i].Cells[1].Value + "', '" + gridDetail.Rows[i].Cells[2].Value + "', '" + gridDetail.Rows[i].Cells[3].Value + "', '" + gridDetail.Rows[i].Cells[4].Value + "')");
                    }

                    main.SetMessage("SAVED!");
                }
                else
                {
                    main.SetMessage("DATA SUDAH PERNAH MASUK DENGAN NOMOR ITU, coba cek lagi.");
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            gridDetail.Rows.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbNamaPT.Text = "PT. LINK NET, Tbk.";
            tbNoPO.Focus();
            tbNoPO.SelectAll();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tbNamaPT.Text = "CITIBANK";
            tbNoPO.Focus();
            tbNoPO.SelectAll();
        }

        private void btnFlyer_Click(object sender, EventArgs e)
        {
            tbPrintType.Text = "Flyer";
            tbDesc.Focus();
            tbDesc.SelectAll();
        }

        private void btnSpanduk_Click(object sender, EventArgs e)
        {
            tbPrintType.Text = "Spanduk";
            tbDesc.Focus();
            tbDesc.SelectAll();
        }

        private void btnDigital_Click(object sender, EventArgs e)
        {
            tbPrintType.Text = "Digital";
            tbDesc.Focus();
            tbDesc.SelectAll();
        }

        private void btnOngkir_Click(object sender, EventArgs e)
        {
            tbPrintType.Text = "Voucher";
            tbDesc.Focus();
            tbDesc.SelectAll();
        }

        private void nudTotal_ValueChanged(object sender, EventArgs e)
        {
            tbTerbilang.Text = Rahayu_Program.Util.Converter.GetTerbilang(nudTotal.Value);
        }

        private void gridDetail_SelectionChanged(object sender, EventArgs e)
        {
            int material = 0;
            int ongkosCetak = 0;
            for (int i = 0; i < gridDetail.Rows.Count; i++)
            {
                material += Int32.Parse(gridDetail.Rows[i].Cells[3].Value.ToString());
                ongkosCetak += Int32.Parse(gridDetail.Rows[i].Cells[4].Value.ToString());
            }
            nudTotal.Value = material + ongkosCetak;
        }

        private void btnEditNota_Click(object sender, EventArgs e)
        {
            main.editAllNotaToolStripMenuItem_Click(sender, e);
            this.Hide();
        }
    }
}
