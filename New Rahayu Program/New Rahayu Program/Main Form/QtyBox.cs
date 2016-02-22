using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Rahayu_Program.Other
{
    public partial class QtyBox : Form
    {
        private double perPack;
        private String typeUnit;

        public QtyBox(double perPack, String typeUnit)
        {
            InitializeComponent();
            this.perPack = perPack;
            this.typeUnit = typeUnit;
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            btnOK.Focus();
        }

        private void rfTotal()
        {
            nudTotal.Value = nudQty.Value * nudPerPack.Value;
        }

        private void addQty(double pack)
        {
            double temp = Convert.ToDouble(nudQty.Value);
            nudQty.Value = Convert.ToDecimal(temp + pack);
            rfTotal();
        }

        private void resetQty()
        {
            nudQty.Value = 0;
            rfTotal();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            addQty(0.5);
        }

        private void QtyBox_Load(object sender, EventArgs e)
        {
            tbTypeUnit1.Text = typeUnit;
            tbTypeUnit2.Text = typeUnit;
            nudPerPack.Value = Convert.ToDecimal(perPack);
            resetQty();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            resetQty();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            addQty(1);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            addQty(2);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            addQty(3);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            addQty(4);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            addQty(5);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            addQty(6);
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            addQty(10);
        }

        private void btn20_Click(object sender, EventArgs e)
        {
            addQty(20);
        }

        private void btn25_Click(object sender, EventArgs e)
        {
            addQty(25);
        }

        private void btn50_Click(object sender, EventArgs e)
        {
            addQty(50);
        }

        private void btn100_Click(object sender, EventArgs e)
        {
            addQty(100);
        }

        private void btnReset_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
