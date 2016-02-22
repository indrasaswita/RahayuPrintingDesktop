using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Rahayu_Program.Printing.Sales.SubSuratJalan
{
    public partial class EditSuratJalanList : Form
    {
        CreateSuratJalanList parent;
        MainForm main;
        string printingTitle;
        string description;

        public EditSuratJalanList(MainForm main, CreateSuratJalanList parent, string printingTitle, string description)
        {
            this.main = main;
            this.parent = parent;

            this.printingTitle = printingTitle;
            this.description = description;

            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            parent.printingTitle = tbPrintingTitle.Text;
            parent.description = tbDescription.Text;

            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void EditSuratJalanList_Load(object sender, EventArgs e)
        {
            tbPrintingTitle.Text = printingTitle;
            tbDescription.Text = description;
        }
    }
}
