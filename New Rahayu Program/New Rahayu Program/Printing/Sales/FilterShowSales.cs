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
        string show;
        string interval;
        string sortDesc;
        string sortAsc;
        string sebelomTempo;
        string sesudahTempo;
        string sudahLunas;
        string belumLunas;

        public FilterShowSales(MainForm main, string show, string interval, string sortDesc, string sortAsc, string sebelomTempo, string sesudahTempo, string sudahLunas, string belumLunas)
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
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            main.globalQuery = show + interval + (ckbJatuhTempo.Checked ? tempoY : tempoX) + (ckbLunas.Checked ? lunasY : lunasX) + " ORDER BY psh.printingSalesID DESC ";
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
    }
}
