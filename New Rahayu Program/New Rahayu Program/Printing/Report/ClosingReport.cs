using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Rahayu_Program.Report;
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;

namespace Rahayu_Program.Printing.Report
{
    public partial class ClosingReport : Form
    {
        private DateTime awal, akhir;
        private int idAwal, idAkhir;
        MainForm main;

        public ClosingReport(MainForm main)
        {
            this.main = main;
            this.MdiParent = main;
            InitializeComponent();
        }

        private void RefreshClosingStamp()
        {
            DataTable dt = ExecuteQuery("SELECT stampID, DATE_FORMAT(stampTime, '%d/%m/%Y %H:%i:%s') AS stampTime, employeeName, description FROM PrintingTimeStamp pts JOIN MsEmployee me ON pts.employeeID = me.employeeID ORDER BY StampID ASC");
            if (dt == null)
            {
                MessageBox.Show("ERROR SHOWING DATA STAMP IN CLOSING FORM PRINTING");
                this.Dispose();
            }
            else
            {
                if (dt.Rows.Count > 0)
                {
                    dataGridView1.Rows.Clear();
                    for (int i = 0; i < dt.Rows.Count; i++)
                        dataGridView1.Rows.Add(dt.Rows[i]["stampID"].ToString(), dt.Rows[i]["stampTime"].ToString(), dt.Rows[i]["employeeName"].ToString(), dt.Rows[i]["description"].ToString());
                }
                else
                {
                    MessageBox.Show("DATA TIDAK ADA (PRINTING TIME STAMP - SHOWING DATA STAMP IN CLOSING FORM PRINTING)");
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (main.GetLevel() < 4 || main.globalEmployeeRole == 3)
            {
                //CUMA BOLEH ADMIN + ADANG
                setStamp();
                RefreshClosingStamp();
            }
            else
            {
                DialogBox.SupervisorForm superLogin = new DialogBox.SupervisorForm(main);
                superLogin.ShowDialog();
                if (superLogin.DialogResult == System.Windows.Forms.DialogResult.OK)
                {
                    setStamp();
                    RefreshClosingStamp();
                }
            }
        }

        public DataTable ExecuteQuery(string query)
        {
            return main.ExecuteQuery(query);
        }

        private void setStamp()
        {
            ExecuteQuery("INSERT INTO PrintingTimeStamp (stampTime, employeeID, description) VALUES (now(), " + main.globalEmployeeID + ", 'CLOSING HARIAN')");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            RefreshClosingStamp();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //AWAL
            int indexSelected = dataGridView1.CurrentRow.Index;
            if (indexSelected >= 0 && indexSelected < dataGridView1.Rows.Count)
            {
                tbAwal.Text = dataGridView1.Rows[indexSelected].Cells[1].Value.ToString();
                awal = Other.Parser.TimeFromString(tbAwal.Text);
                idAwal = Int32.Parse(dataGridView1.Rows[indexSelected].Cells[0].Value.ToString());
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //AKHIR
            int indexSelected = dataGridView1.CurrentRow.Index;
            if (indexSelected >= 0 && indexSelected < dataGridView1.Rows.Count)
            {
                tbAkhir.Text = dataGridView1.Rows[indexSelected].Cells[1].Value.ToString();
                akhir = Other.Parser.TimeFromString(tbAkhir.Text);
                idAkhir = Int32.Parse(dataGridView1.Rows[indexSelected].Cells[0].Value.ToString());
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

        private void buatLaporanByQuery(object laporan, DateTime startTime, DateTime endTime)
        {
            ReportForm reportForm = new ReportForm(main);
            reportForm.MdiParent = main;
            reportForm.WindowState = FormWindowState.Maximized;

            reportForm.GetCrystalReportViewer().ReportSource = laporan;

            ParameterField field1 = new ParameterField();
            ParameterDiscreteValue value1 = new ParameterDiscreteValue();
            field1.Name = "startTime";
            value1.Value = startTime;
            field1.CurrentValues.Add(value1);

            ParameterField field2 = new ParameterField();
            ParameterDiscreteValue value2 = new ParameterDiscreteValue();
            field2.Name = "endTime";
            value2.Value = endTime;
            field2.CurrentValues.Add(value2);

            ParameterFields fields = new ParameterFields();
            fields.Add(field1);
            fields.Add(field2);

            reportForm.GetCrystalReportViewer().ParameterFieldInfo = fields;
            reportForm.GetCrystalReportViewer().Refresh();
            reportForm.Show();
        }

        private void btnPembayaranHarian_Click(object sender, EventArgs e)
        {
            DataTable dt = main.ExecuteQuery("SELECT psh.printingSalesID, salesTime, "
                    + "CONCAT(parentCompanyName, '; ', "
                    + "companyName, '; ',  customerName, ' (',  cu.phone, ')') AS customerName, "
                    + "tempo, printingType, printingTitle, jobType, "
                    + "CONCAT(material, '; ', quantity, '; ', quantityType, '; ', sidePrint, ')') AS detail"
                    + ", hargaMaterial, hargaOngkosCetak, hargaAsli, "
                    + "IFNULL((SELECT SUM(ammount) FROM PrintingSalesPayment "
                    + "WHERE printingSalesID = psh.printingSalesID), 0) AS paymentTotal "
                + "FROM PrintingSalesHeader psh "
                    + "JOIN PrintingSalesDetail psd ON psh.printingSalesID = psd.printingSalesID "
	                + "JOIN MsCustomer cu ON cu.customerID = psh.customerID "
	                + "JOIN MsCompany co ON co.companyID = cu.companyID "
	                + "JOIN MsParentCompany pc ON co.parentCompanyID = pc.parentCompanyID "
                + "WHERE psh.salesTime > '" + awal.ToString("yyyy-MM-dd HH:mm:ss") 
                    + "' AND psh.salesTime < '" + akhir.ToString("yyyy-MM-dd HH:mm:ss") + "'"
                    + " AND psh.status = 'SALE'");

            if (dt == null)
            {
                MessageBox.Show("ERROR PRINT REPORT (LAPORAN HARIAN DI CLOSING FORM STATIONERY)");
                this.Dispose();
            }
            else
            {
                if (dt.Rows.Count > 0)
                {
                    Rahayu_Program.Report.PrintingSales.PrintingSalesDetailPayment laporan = new Rahayu_Program.Report.PrintingSales.PrintingSalesDetailPayment();

                    laporan.SetDataSource(dt);

                    buatLaporanByQuery(laporan, awal, akhir);
                }
                else
                {
                    MessageBox.Show("DATA TIDAK ADA (LAPORAN HARIAN DI CLOSING FORM STATIONERY)");
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ClosingReport_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
        }

        private void ClosingReport_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("", "ID");
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns.Add("", "Time");
            dataGridView1.Columns[1].Width = 200;
            dataGridView1.Columns.Add("", "Emp");
            dataGridView1.Columns[2].Width = 150;
            dataGridView1.Columns.Add("", "Desc");
            dataGridView1.Columns[3].Width = 150;

            tbAkhir.Text = tbAwal.Text = "";
            idAkhir = idAwal = 0;

            RefreshClosingStamp();
        }

        private void btnPembayaranDoang_Click(object sender, EventArgs e)
        {
            DataTable dt = main.ExecuteQuery("SELECT psh.printingSalesID, salesTime, customerName, tempo, SUM(hargaAsli) as detailHargaTotal, SUM(digitalCounter) as digitalCounter, paymentID, paymentTime, ammount, method, psp.description, checked as checker FROM PrintingSalesHeader psh JOIN PrintingSalesPayment psp ON psh.printingSalesID = psp.printingSalesID JOIN MsCustomer cu ON cu.customerID = psh.customerID JOIN PrintingSalesDetail psd ON psd.printingSalesID = psh.printingSalesID "
                                    + "WHERE psh.status = 'SALE' "
                                    + " AND psp.paymentTime > '" + awal.ToString("yyyy-MM-dd HH:mm:ss")
                                    + "' AND psp.paymentTime < '" + akhir.ToString("yyyy-MM-dd HH:mm:ss") + "' "
                                    + "GROUP BY psh.printingSalesID, salesTime, customerName, tempo, paymentID, paymentTime, ammount, method, psp.description, checked ");

            if (dt == null)
            {
                MessageBox.Show("ERROR PRINT REPORT (LAPORAN HARIAN DI CLOSING FORM STATIONERY)");
                this.Dispose();
            }
            else
            {
                if (dt.Rows.Count > 0)
                {
                    Rahayu_Program.Report.PrintingSales.PrintingSalesPayment laporan = new Rahayu_Program.Report.PrintingSales.PrintingSalesPayment();

                    laporan.SetDataSource(dt);

                    buatLaporanByQuery(laporan, awal, akhir);
                }
                else
                {
                    MessageBox.Show("DATA TIDAK ADA (LAPORAN HARIAN DI CLOSING FORM STATIONERY)");
                }
            }
        }

        private void btnSemuaUtang_Click(object sender, EventArgs e)
        {
            DataTable dt = main.ExecuteQuery("SELECT psh.printingSalesID, salesTime, customerName, tempo, IFNULL((SELECT SUM(hargaAsli) FROM PrintingSalesDetail psd WHERE psd.printingSalesID = psh.printingSalesID), 0) AS detailHargaTotal, IFNULL((SELECT SUM(ammount) FROM PrintingSalesPayment psp WHERE psp.printingSalesID = psh.printingSalesID), 0) AS paymentTotal FROM PrintingSalesHeader psh JOIN MsCustomer cu ON psh.customerID = cu.customerID WHERE IFNULL((SELECT SUM(hargaAsli) FROM PrintingSalesDetail psd WHERE psd.printingSalesID = psh.printingSalesID), 0) > IFNULL((SELECT SUM(ammount) FROM PrintingSalesPayment psp WHERE psp.printingSalesID = psh.printingSalesID), 0) AND psh.status = 'SALE'");

            //BUAT LAPORAN UNTUK UTANG SEMUANYA YANG MASI NGUTANG
            if (dt == null)
            {
                MessageBox.Show("ERROR PRINT REPORT (LAPORAN HARIAN DI CLOSING FORM STATIONERY)");
                this.Dispose();
            }
            else
            {
                if (dt.Rows.Count > 0)
                {
                    Rahayu_Program.Report.PrintingSales.PrintingSalesAllDebt laporan = new Rahayu_Program.Report.PrintingSales.PrintingSalesAllDebt();

                    laporan.SetDataSource(dt);
                    laporan.ExportToDisk(ExportFormatType.PortableDocFormat, "C:\\abc.pdf");

                    buatLaporanByQuery(laporan);
                }
                else
                {
                    MessageBox.Show("DATA TIDAK ADA (LAPORAN HARIAN DI CLOSING FORM STATIONERY)");
                }
            }
        }

        private void btnUtangPerCustomer_Click(object sender, EventArgs e)
        {
            HutangPerCustomer hutangCustomer = new HutangPerCustomer(main);
            hutangCustomer.Show();
            hutangCustomer.BringToFront();
            hutangCustomer.ClearAll();
        }
    }
}
