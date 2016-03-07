using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Rahayu_Program.Printing.Sales
{
    public partial class FilterShowSales : Form
    {
        MainForm main;
        string query;
        string show;
        string interval;
        string sortDesc;
        string sortAsc;
        string sebelomTempo;
        string sesudahTempo;
        string sudahLunas;
        string belumLunas;
        string adaTitipan;
        string belumBayarTitipan;

        public FilterShowSales(MainForm main, string show, string interval, string sortDesc, string sortAsc, string sebelomTempo, string sesudahTempo, string sudahLunas, string belumLunas, string adaTitipan, string belumBayarTitipan)
        {
            this.main = main;
            this.show = show;
            this.interval = interval;
            this.sortAsc = sortAsc;
            this.sortDesc = sortDesc;
            this.sebelomTempo = sebelomTempo;
            this.sesudahTempo = sesudahTempo;
            this.sudahLunas = sudahLunas;
            this.belumLunas = belumLunas;
            this.adaTitipan = adaTitipan;
            this.belumBayarTitipan = belumBayarTitipan;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //main.globalQuery = show + interval + (ckbJatuhTempo.Checked ? tempoY : tempoX) + (ckbLunas.Checked ? lunasY : lunasX) + " ORDER BY psh.printingSalesID DESC ";
            query += show + interval;

            if (rbCustomer.Checked)
                if (tbCustomer.Text.Trim() != "")
                    query += " AND customerName LIKE '%" + tbCustomer.Text + "%' ";
                else ;
            else if (rbCompany.Checked)
                if (tbCompany.Text.Trim() != "")
                    query += " AND companyName LIKE '%" + tbCompany.Text + "%' ";
                else ;

            if (rbLunas2.Checked)
                query += belumLunas;
            else if (rbLunas3.Checked)
                query += sudahLunas;

            if (rbTempo2.Checked)
                query += sesudahTempo;
            else if (rbTempo3.Checked)
                query += sebelomTempo;

            if (rbTitipan2.Checked)
                query += adaTitipan;
            else if (rbTitipan3.Checked)
                query += belumBayarTitipan;

            query += sortDesc; //DEFAULT -> tinggal buat radbut kalo mau asc lagi

            //MessageBox.Show(query);
            main.globalQuery = query;
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void FilterShowSales_Load(object sender, EventArgs e)
        {
            query = "";
        }

        private void rbCompany_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCompany.Checked)
            {
                tbCompany.Enabled = true;
                tbCustomer.Enabled = false;
                tbCustomer.Text = "";
                tbCompany.Focus();
            }
        }

        private void rbCustomer_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCustomer.Checked)
            {
                tbCustomer.Enabled = true;
                tbCompany.Enabled = false;
                tbCompany.Text = "";
                tbCustomer.Focus();
            }
        }
    }
}
