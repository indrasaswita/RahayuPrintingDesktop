using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Rahayu_Program.Other;

namespace Rahayu_Program.Printing.Sales.SalesClone
{
    public partial class PrintingSalesCloneEditHeader : Form
    {
        MainForm main;
        string noNota;

        public PrintingSalesCloneEditHeader(MainForm main, string noNota)
        {
            this.main = main;
            this.noNota = noNota;

            InitializeComponent();
        }

        private void PrintingSalesCloneEditHeader_Load(object sender, EventArgs e)
        {
            tbNoNota.Text = noNota;
            RefreshHeader();
        }

        private DataTable ExecuteQuery(string query)
        {
            return main.ExecuteQuery(query);
        }

        private void tbGantiNo_Click(object sender, EventArgs e)
        {
            DataTable dt = ExecuteQuery("SELECT * FROM PrintingSalesCloneHeader WHERE printingSalesCloneID = '" + tbNewNomor.Text + "'");
            if (dt != null)
            {
                if (dt.Rows.Count == 0)
                {
                    //KALO GA KETEMU BARU BISA DI GANTI
                    ExecuteQuery("UPDATE PrintingSalesCloneHeader SET printingSalesCloneID = '" + tbNewNomor.Text + "' WHERE printingSalesCloneID = '" + tbNoNota.Text + "'");
                    ExecuteQuery("UPDATE PrintingSalesCloneDetail SET printingSalesCloneID = '" + tbNewNomor.Text + "' WHERE printingSalesCloneID = '" + tbNoNota.Text + "'");
                    noNota = tbNewNomor.Text;
                    tbNewNomor.Text = "";
                    tbNoNota.Text = noNota;
                    main.SetMessage("Berhasil di ubah IDnya");
                }
                else
                {
                    //KALO ADA YANG UDA DI MASUKIN, NANTI JADI DUPLIKAT
                    main.SetMessage("ID ini sudah dimasukin sebelomnya, tidak bisa diganti");
                }
            }
        }

        private void btnTarikUlang_Click(object sender, EventArgs e)
        {
            RefreshHeader();
            main.SetMessage("Telah di Refresh..");
        }

        private void RefreshHeader()
        {
            DataTable dt = ExecuteQuery("SELECT purchaseNo, customerCompany, customerUp, terbilang, DATE_FORMAT(salesTime, '%d/%m/%Y %H:%i:%s') AS salesTime FROM PrintingSalesCloneHeader WHERE printingSalesCloneID = '" + noNota + "'");
            if (dt != null)
            {
                if (dt.Rows.Count == 1)
                {
                    tbPO.Text = dt.Rows[0]["purchaseNo"].ToString();
                    tbPT.Text = dt.Rows[0]["customerCompany"].ToString();
                    tbUp.Text = dt.Rows[0]["customerUp"].ToString();
                    tbTerbilang.Text = dt.Rows[0]["terbilang"].ToString();
                    dtpTanggalNota.Value = Parser.TimeFromString(dt.Rows[0]["salesTime"].ToString());
                }
                else
                {
                    main.SetMessage("DATA TIDAK VALID");
                    this.Dispose();
                }
            }
        }

        private void tbEdit_Click(object sender, EventArgs e)
        {
            ExecuteQuery("UPDATE PrintingSalesCloneHeader SET salesTime = '" + dtpTanggalNota.Value.ToString("yyyy-MM-dd") +"', customerCompany = '" + tbPT.Text +"', customerUp = '" + tbUp.Text +"', terbilang = '" + tbTerbilang.Text +"', purchaseNo = '" + tbPO.Text +"' WHERE printingSalesCloneID = '" + tbNoNota.Text + "'");
            main.SetMessage("Isi Header berhasil di ubah");
            RefreshHeader();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
