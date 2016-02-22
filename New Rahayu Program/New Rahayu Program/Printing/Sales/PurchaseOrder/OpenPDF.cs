using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Rahayu_Program.Printing.Sales.PurchaseOrder
{
    public partial class OpenPDF : Form
    {
        MainForm main;
        string filename;

        public OpenPDF(MainForm main, string filename)
        {
            this.filename = filename;
            this.main = main;
            this.MdiParent = main;

            InitializeComponent();
        }

        private void OpenPDF_Load(object sender, EventArgs e)
        {
            if (File.Exists(filename))
            {
                //open
                axAcroPDF1.src = filename;
            }
            else
            {
                main.SetMessage("File PDFnya ga ada, error!");
                this.Close();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OpenPDF_FormClosed(object sender, FormClosedEventArgs e)
        {
            main.openPDF = null;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
        }
    }
}
