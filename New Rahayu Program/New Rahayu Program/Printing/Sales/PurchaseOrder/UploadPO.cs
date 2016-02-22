using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Rahayu_Program.Printing.Sales.PurchaseOrder
{
    public partial class UploadPO : Form
    {
        MainForm main;

        public UploadPO(MainForm main)
        {
            this.main = main;
            this.MdiParent = main;
            InitializeComponent();

            main.globalNoPO = "";
        }

        public DataTable ExecuteQuery(string query)
        {
            return main.ExecuteQuery(query);
        }

        private void UploadPO_Load(object sender, EventArgs e)
        {
            gridPO.Columns.Add("PO", "No. PO");
            gridPO.Columns["PO"].Width = 200;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Dispose();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            main.globalNoPO = tbSelected.Text.Trim();
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}
