using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.Windows.Forms;
using System.Drawing.Printing;

namespace Rahayu_Program.Report
{
    public partial class ReportForm : Form
    {
        private MainForm main;
        private Boolean close;

        public ReportForm(MainForm main)
        {
            this.main = main;

            InitializeComponent();
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            this.MdiParent = main;
            //this.crystalReportViewer1.RefreshReport();
            this.WindowState = FormWindowState.Normal;
            this.WindowState = FormWindowState.Maximized;
        }

        private void ReportForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            close = true;
            this.WindowState = FormWindowState.Normal;
        }

        public CrystalReportViewer GetCrystalReportViewer()
        {
            return crystalReportViewer1;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            close = false;
        }

        private void ReportForm_SizeChanged(object sender, EventArgs e)
        {
            if (!close) this.WindowState = FormWindowState.Maximized;
        }


    }
}
