using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Rahayu_Program.Printing.Sales.SalesClone
{
    public partial class PrintingSalesCloneEditDetail : Form
    {
        MainForm main;
        string noNota;
        string printTitle;
        string printType;

        public PrintingSalesCloneEditDetail(MainForm main, string noNota, string printTitle, string printType)
        {
            this.main = main;
            this.noNota = noNota;
            this.printTitle = printTitle;
            this.printType = printType;

            InitializeComponent();
        }

        private DataTable ExecuteQuery(string query)
        {
            return main.ExecuteQuery(query);
        }

        private void btnTarikUlang_Click(object sender, EventArgs e)
        {
            RefreshDetail();
            main.SetMessage("Telah di Refresh..");
        }

        private void RefreshDetail()
        {
            DataTable dt = ExecuteQuery("SELECT * FROM PrintingSalesCloneDetail WHERE printingSalesCloneID = '" + tbNoNota.Text + "' AND printingTitle = '" + tbJudul.Text + "' AND printingType = '" + tbTipe.Text + "'");
            if (dt != null)
            {
                if (dt.Rows.Count == 1)
                {
                    tbDeskripsi.Text = dt.Rows[0]["description"].ToString();
                    nudMaterial.Value = Decimal.Parse(dt.Rows[0]["material"].ToString());
                    nudOngkosCetak.Value = Decimal.Parse(dt.Rows[0]["ongkosCetak"].ToString());
                }
            }
        }

        private void nudOngkosCetak_ValueChanged(object sender, EventArgs e)
        {
            GetTotal();
        }

        private void nudMaterial_ValueChanged(object sender, EventArgs e)
        {
            GetTotal();
        }

        private void GetTotal()
        {
            nudTotal.Value = nudMaterial.Value + nudOngkosCetak.Value;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbNewTipe_Load(object sender, EventArgs e)
        {
            tbNoNota.Text = noNota;
            tbJudul.Text = printTitle;
            tbTipe.Text = printType;

            RefreshDetail();
        }

        private void tbEdit_Click(object sender, EventArgs e)
        {
            ExecuteQuery("UPDATE PrintingSalesCloneDetail SET description = '" + tbDeskripsi.Text + "', material = '" + nudMaterial.Value + "', ongkosCetak = '" + nudOngkosCetak.Value + "' WHERE printingSalesCloneID = '" + tbNoNota.Text + "' AND printingTitle = '" + tbJudul.Text + "' AND printingType = '" + tbTipe.Text + "'");
            main.SetMessage("Isi Detail telah diubah..");
            RefreshDetail();
        }

        private void tbGantiJob_Click(object sender, EventArgs e)
        {
            tbNewJudul.Text = tbNewJudul.Text == "" ? tbJudul.Text : tbNewJudul.Text;
            tbNewTipe.Text = tbNewTipe.Text == "" ? tbTipe.Text : tbNewTipe.Text;
            DataTable dt = ExecuteQuery("SELECT * FROM PrintingSalesCloneDetail WHERE printingSalesCloneID = '" + tbNoNota.Text +"' AND printingTitle = '" + tbNewJudul.Text +"' AND printingType = '" + tbNewTipe.Text +"'");
            if (dt != null)
            {
                if (dt.Rows.Count == 0)
                {
                    //BELOM ADA DUPLIKATNYA
                    ExecuteQuery("UPDATE PrintingSalesCloneDetail SET printingTitle = '" + tbNewJudul.Text + "', printingType = '" + tbNewTipe.Text + "' WHERE printingTitle = '" + tbJudul.Text + "' AND printingType = '" + tbTipe.Text + "' AND printingSalesCloneID = '" + tbNoNota.Text + "'");
                    main.SetMessage("Data judul dan tipe telah dirubah dengan baik");
                }
                else
                {
                    //DATA SUDAH DIMASUKIN, DUPLIKASI
                    main.SetMessage("Data sudah dimasukin sebelomnya, ganti Title atau Tipe");
                }
            }
        }
    }
}
