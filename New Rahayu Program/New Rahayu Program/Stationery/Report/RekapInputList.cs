using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Rahayu_Program.Stationery.Report
{
    public partial class RekapInputList : UserControl
    {
        RekapStockInput parent;
        private string barangID;
        private string namaBarang;
        private int index;
        private int input;

        public RekapInputList(RekapStockInput parent, string barangID, string namaBarang, int input)
        {
            this.barangID = barangID;
            this.parent = parent;
            this.namaBarang = namaBarang;
            this.input = input;

            InitializeComponent();
        }

        public string GetNamaBarang()
        {
            return namaBarang;
        }

        public string GetNomorBarang()
        {
            return barangID;
        }

        public int getQty()
        {
            return Convert.ToInt32(nudQty.Value);
        }

        private void nudQty_Enter(object sender, EventArgs e)
        {
            nudQty.Select(0, 9);
        }

        private void RekapInputList_Load(object sender, EventArgs e)
        {
            tbNomorBarang.Text = barangID;
            tbNamaBarang.Text = namaBarang;
            nudQty.Value = input;
        }

        public void SetIndex(int index)
        {
            this.index = index;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            parent.SetNext(index);
        }

        public void setFocus()
        {
            nudQty.Focus();
            nudQty.Select(0,9);
        }

        private void nudQty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnNext_Click(sender, e);
            }
        }
    }
}
