using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Rahayu_Program.Stationery.MsBarang
{
    public partial class PrintStockHabis : Form
    {
        private MainForm main;
        private DataTable dt;

        public PrintStockHabis(MainForm main)
        {
            this.main = main;

            this.MdiParent = main;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Rahayu_Program.Report.ReportForm reportForm = new Rahayu_Program.Report.ReportForm(main);
            reportForm.MdiParent = main;
            reportForm.WindowState = FormWindowState.Maximized;


            dt = main.ExecuteQuery("SELECT barangID, namaBarang, stock, batasStock, b.supplierName, b.contactPerson, b.address, b.phone1, b.phone2, b.phone3 FROM MsBarang a, MsSupplier b WHERE stock < batasStock");

            if (dt == null)
            {
                MessageBox.Show("OPEN REPORT ERROR (PRINT STOCK HABIS STATIONERY)");
                this.Dispose();
            }
            else
            {
                if (dt.Rows.Count > 0)
                {
                    Rahayu_Program.Report.Stationery.LaporanHabisStock laporan = new Rahayu_Program.Report.Stationery.LaporanHabisStock();
                    laporan.SetDataSource(dt);

                    reportForm.GetCrystalReportViewer().ReportSource = laporan;
                    reportForm.GetCrystalReportViewer().Refresh();

                    reportForm.Show();
                }
                else
                {
                    MessageBox.Show("DATA TIDAK ADA");
                }
            }

        }

        private void PrintStockHabis_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("", "Kd Brg");
            dataGridView1.Columns.Add("", "Nama Barang");
            dataGridView1.Columns.Add("", "Stock");
            dataGridView1.Columns.Add("", "Minimal Stock");
            dataGridView1.Columns[0].Width = 80;
            dataGridView1.Columns[1].Width = 260;
            dataGridView1.Columns[2].Width = 120;
            dataGridView1.Columns[3].Width = 115;

            dt = main.ExecuteQuery("SELECT barangID, namaBarang, stock, batasStock, (SELECT supplierName FROM MsSupplier b WHERE b.supplierID = a.supplierID) FROM MsBarang a WHERE stock < batasStock");

            if (dt == null)
            {
                MessageBox.Show("OPEN REPORT ERROR (PRINT STOCK HABIS STATIONERY)");
                this.Dispose();
            }
            else
            {
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        dataGridView1.Rows.Add(dt.Rows[i]["barangID"].ToString(), dt.Rows[i]["namaBarang"].ToString(), Int32.Parse(dt.Rows[i]["stock"].ToString()).ToString("#,##0"), Int32.Parse(dt.Rows[i]["batasStock"].ToString()).ToString("#,##0"));
                    }
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
