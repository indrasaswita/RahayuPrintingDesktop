using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Rahayu_Program.Printing.Sales.SubSuratJalan
{
    public partial class CreateSuratJalanList : UserControl
    {
        MainForm main;
        CreateSuratJalanManual parent;
        public string printingTitle;
        public string description;

        public CreateSuratJalanList(MainForm main, CreateSuratJalanManual parent, string printingTitle, string description)
        {
            this.main = main;
            this.parent = parent;
            this.printingTitle = printingTitle;
            this.description = description;

            InitializeComponent();
        }

        private void CreateSuratJalanList_Load(object sender, EventArgs e)
        {
            tbPrintingTitle.Text = printingTitle;
            tbDescription.Text = description;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            parent.deleteList(this);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            EditSuratJalanList edit = new EditSuratJalanList(main, this, printingTitle, description);
            DialogResult result = edit.ShowDialog();
            if (result == DialogResult.OK)
            {
                tbPrintingTitle.Text = printingTitle;
                tbDescription.Text = description;
            }
        }

        private void tbDescription_Enter(object sender, EventArgs e)
        {
            btnUpdate.Focus();
        }

        private void tbDescription_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
