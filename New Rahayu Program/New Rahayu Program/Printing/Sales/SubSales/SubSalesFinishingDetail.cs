using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Rahayu_Program.Printing.Sales.SubSales
{
    public partial class SubSalesFinishingDetail : Form
    {
        private SubSalesFinishing subSalesFinishing;
        private string finishing;
        private string panduan;

        public SubSalesFinishingDetail(SubSalesFinishing subSalesFinishing, string finishing, string panduan)
        {
            this.subSalesFinishing = subSalesFinishing;
            this.finishing = finishing;
            this.panduan = panduan;

            InitializeComponent();
        }

        private void SubSalesFinishingDetail_Load(object sender, EventArgs e)
        {
            tbFinishing.Text = finishing;
            tbPanduan.Text = panduan;
            tbKeterangan.Focus();
            tbKeterangan.Select(0, 100);
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            subSalesFinishing.AddFinishingList(tbFinishing.Text, tbKeterangan.Text, tbNote.Text);
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}
