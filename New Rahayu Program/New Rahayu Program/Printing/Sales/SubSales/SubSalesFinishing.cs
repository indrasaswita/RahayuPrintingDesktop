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
    public partial class SubSalesFinishing : Form
    {
        private SubSalesOffset subSalesOffset;
        private List<string[]> finishing = new List<string[]>();

        public SubSalesFinishing(SubSalesOffset subSalesOffset, List<string[]> finishing)
        {
            this.subSalesOffset = subSalesOffset;
            this.finishing = finishing;
            InitializeComponent();
        }

        private void SubSalesFinishing_Load(object sender, EventArgs e)
        {
            gridFinishing.Columns.Add("", "Finishing");
            gridFinishing.Columns[0].Width = 140;
            gridFinishing.Columns.Add("", "Keterangan");
            gridFinishing.Columns[1].Width = 222;
            gridFinishing.Columns.Add("", "Note");
            gridFinishing.Columns[2].Width = 100;

            gridFinishing.Rows.Clear();
            foreach (string[] i in finishing)
            {
                gridFinishing.Rows.Add(i);
            }
        }

        private void cbPotong_Click(object sender, EventArgs e)
        {
            
        }

        private void cbPotong_CheckedChanged(object sender, EventArgs e)
        {
            string judul = "Potong";
            string keterangan = "Potong belah berapa? Ukuran berapa? Kenapa di potong? Yang dipotong, sticker / laminating?";
            if (cbPotong.Checked)
            {
                SubSalesFinishingDetail input = new SubSalesFinishingDetail(this, judul, keterangan);
                DialogResult result = input.ShowDialog();
                if (result != System.Windows.Forms.DialogResult.OK)
                {
                    cbPotong.Checked = false;
                }
            }
            else
            {
                foreach (DataGridViewRow i in gridFinishing.Rows)
                {
                    if (i.Cells[0].Value.ToString() == judul)
                    {
                        gridFinishing.Rows.Remove(i);
                    }
                }
            }
        }

        internal void AddFinishingList(string finishing, string keterangan, string note)
        {
            gridFinishing.Rows.Add(finishing, keterangan, note);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void cbTempel_CheckedChanged(object sender, EventArgs e)
        {
            string judul = "Tempel";
            string keterangan = "Tempel kemana? Dasar apa? Laminating ga? Pake Lem / Double tape?";
            if (cbTempel.Checked)
            {
                SubSalesFinishingDetail input = new SubSalesFinishingDetail(this, judul, keterangan);
                DialogResult result = input.ShowDialog();
                if (result != System.Windows.Forms.DialogResult.OK)
                {
                    cbTempel.Checked = false;
                }
            }
            else
            {
                foreach (DataGridViewRow i in gridFinishing.Rows)
                {
                    if (i.Cells[0].Value.ToString() == judul)
                    {
                        gridFinishing.Rows.Remove(i);
                    }
                }
            }
        }

        private void cbSusun_CheckedChanged(object sender, EventArgs e)
        {
            string judul = "Set (Susun)";
            string keterangan = "Brapa jumlah susunan? Urutannya apa aja? Susunan ketruk mana? Jadinya kayak apa?";
            if (cbSusun.Checked)
            {
                SubSalesFinishingDetail input = new SubSalesFinishingDetail(this, judul, keterangan);
                DialogResult result = input.ShowDialog();
                if (result != System.Windows.Forms.DialogResult.OK)
                {
                    cbSusun.Checked = false;
                }
            }
            else
            {
                foreach (DataGridViewRow i in gridFinishing.Rows)
                {
                    if (i.Cells[0].Value.ToString() == judul)
                    {
                        gridFinishing.Rows.Remove(i);
                    }
                }
            }
        }

        private void cbEmboss_CheckedChanged(object sender, EventArgs e)
        {
            string judul = "Emboss";
            string keterangan = "Embos kedalam / keluar? Ukuran Embos brapa? Bahan yang diemboss laminating ga?";
            if (cbEmboss.Checked)
            {
                SubSalesFinishingDetail input = new SubSalesFinishingDetail(this, judul, keterangan);
                DialogResult result = input.ShowDialog();
                if (result != System.Windows.Forms.DialogResult.OK)
                {
                    cbEmboss.Checked = false;
                }
            }
            else
            {
                foreach (DataGridViewRow i in gridFinishing.Rows)
                {
                    if (i.Cells[0].Value.ToString() == judul)
                    {
                        gridFinishing.Rows.Remove(i);
                    }
                }
            }
        }

        private void cbVarnish_CheckedChanged(object sender, EventArgs e)
        {
            string judul = "UV Varnish";
            string keterangan = "Varnish brapa sisi? Varnish bahan apa? (NOTE: Digital TIDAK BISA di UV Varnish!!)";
            if (cbVarnish.Checked)
            {
                SubSalesFinishingDetail input = new SubSalesFinishingDetail(this, judul, keterangan);
                DialogResult result = input.ShowDialog();
                if (result != System.Windows.Forms.DialogResult.OK)
                {
                    cbVarnish.Checked = false;
                }
            }
            else
            {
                foreach (DataGridViewRow i in gridFinishing.Rows)
                {
                    if (i.Cells[0].Value.ToString() == judul)
                    {
                        gridFinishing.Rows.Remove(i);
                    }
                }
            }
        }

        private void cbPond_CheckedChanged(object sender, EventArgs e)
        {
            string judul = "Pond (Die Cut)";
            string keterangan = "Ukuran brapa? Putus / stengah putus? Jalan brapa mata? Potong bahan ukuran brapa? Bahan di laminating ga?";
            if (cbPond.Checked)
            {
                SubSalesFinishingDetail input = new SubSalesFinishingDetail(this, judul, keterangan);
                DialogResult result = input.ShowDialog();
                if (result != System.Windows.Forms.DialogResult.OK)
                {
                    cbPond.Checked = false;
                }
            }
            else
            {
                foreach (DataGridViewRow i in gridFinishing.Rows)
                {
                    if (i.Cells[0].Value.ToString() == judul)
                    {
                        gridFinishing.Rows.Remove(i);
                    }
                }
            }
        }

        private void cbNumerator_CheckedChanged(object sender, EventArgs e)
        {
            string judul = "Numerator";
            string keterangan = "Brapa digit? Prefix? Suffix? Nomor mulai? Nomor selesai? Jumlah brapa?";
            if (cbNumerator.Checked)
            {
                SubSalesFinishingDetail input = new SubSalesFinishingDetail(this, judul, keterangan);
                DialogResult result = input.ShowDialog();
                if (result != System.Windows.Forms.DialogResult.OK)
                {
                    cbNumerator.Checked = false;
                }
            }
            else
            {
                foreach (DataGridViewRow i in gridFinishing.Rows)
                {
                    if (i.Cells[0].Value.ToString() == judul)
                    {
                        gridFinishing.Rows.Remove(i);
                    }
                }
            }
        }

        private void cbLaminating_CheckedChanged(object sender, EventArgs e)
        {
            string judul = "Laminating";
            string keterangan = "Brapa sisi? Sebelom laminating ukuran kertas brapa? Laminating GLOSS / DOFF?";
            if (cbLaminating.Checked)
            {
                SubSalesFinishingDetail input = new SubSalesFinishingDetail(this, judul, keterangan);
                DialogResult result = input.ShowDialog();
                if (result != System.Windows.Forms.DialogResult.OK)
                {
                    cbLaminating.Checked = false;
                }
            }
            else
            {
                foreach (DataGridViewRow i in gridFinishing.Rows)
                {
                    if (i.Cells[0].Value.ToString() == judul)
                    {
                        gridFinishing.Rows.Remove(i);
                    }
                }
            }
        }

        private void cbSpotUV_CheckedChanged(object sender, EventArgs e)
        {
            string judul = "Spot UV";
            string keterangan = "Brapa sisi? Bahan dasar? Laminating ga? Ukuran kertas brapa? Ukuran Spot UV brapa?";
            if (cbSpotUV.Checked)
            {
                SubSalesFinishingDetail input = new SubSalesFinishingDetail(this, judul, keterangan);
                DialogResult result = input.ShowDialog();
                if (result != System.Windows.Forms.DialogResult.OK)
                {
                    cbSpotUV.Checked = false;
                }
            }
            else
            {
                foreach (DataGridViewRow i in gridFinishing.Rows)
                {
                    if (i.Cells[0].Value.ToString() == judul)
                    {
                        gridFinishing.Rows.Remove(i);
                    }
                }
            }
        }

        private void cbKuping_CheckedChanged(object sender, EventArgs e)
        {
            string judul = "Kuping";
            string keterangan = "Di Cetak ga? Brapa sisi cetak? Ada sisipan kartu nama ga? Bahan apa? Laminating ga? Tempel pake doubletape / lem?";
            if (cbKuping.Checked)
            {
                SubSalesFinishingDetail input = new SubSalesFinishingDetail(this, judul, keterangan);
                DialogResult result = input.ShowDialog();
                if (result != System.Windows.Forms.DialogResult.OK)
                {
                    cbKuping.Checked = false;
                }
            }
            else
            {
                foreach (DataGridViewRow i in gridFinishing.Rows)
                {
                    if (i.Cells[0].Value.ToString() == judul)
                    {
                        gridFinishing.Rows.Remove(i);
                    }
                }
            }
        }

        private void cbSisipan_CheckedChanged(object sender, EventArgs e)
        {
            string judul = "Sisipan";
            string keterangan = "Urutannya kayak gimana? Ukuran isi brapa?";
            if (cbSisipan.Checked)
            {
                SubSalesFinishingDetail input = new SubSalesFinishingDetail(this, judul, keterangan);
                DialogResult result = input.ShowDialog();
                if (result != System.Windows.Forms.DialogResult.OK)
                {
                    cbSisipan.Checked = false;
                }
            }
            else
            {
                foreach (DataGridViewRow i in gridFinishing.Rows)
                {
                    if (i.Cells[0].Value.ToString() == judul)
                    {
                        gridFinishing.Rows.Remove(i);
                    }
                }
            }
        }

        private void cbHook_CheckedChanged(object sender, EventArgs e)
        {
            string judul = "Hook";
            string keterangan = "Urutannya kayak gimana? Ukuran isi brapa?";
            if (cbHook.Checked)
            {
                SubSalesFinishingDetail input = new SubSalesFinishingDetail(this, judul, keterangan);
                DialogResult result = input.ShowDialog();
                if (result != System.Windows.Forms.DialogResult.OK)
                {
                    cbHook.Checked = false;
                }
            }
            else
            {
                foreach (DataGridViewRow i in gridFinishing.Rows)
                {
                    if (i.Cells[0].Value.ToString() == judul)
                    {
                        gridFinishing.Rows.Remove(i);
                    }
                }
            }
        }

        private void cbBor_CheckedChanged(object sender, EventArgs e)
        {
            string judul = "Bor";
            string keterangan = "Letaknya sebelah mana? Bor bentuk apa? Ukuran diameter brapa? Bahan apa?";
            if (cbBor.Checked)
            {
                SubSalesFinishingDetail input = new SubSalesFinishingDetail(this, judul, keterangan);
                DialogResult result = input.ShowDialog();
                if (result != System.Windows.Forms.DialogResult.OK)
                {
                    cbBor.Checked = false;
                }
            }
            else
            {
                foreach (DataGridViewRow i in gridFinishing.Rows)
                {
                    if (i.Cells[0].Value.ToString() == judul)
                    {
                        gridFinishing.Rows.Remove(i);
                    }
                }
            }
        }

        private void cbRel_CheckedChanged(object sender, EventArgs e)
        {
            string judul = "Rel";
            string keterangan = "Ukuran lebar brapa? Jalan Pond atau Rel? Bahan apa? Brapa x jalan?";
            if (cbRel.Checked)
            {
                SubSalesFinishingDetail input = new SubSalesFinishingDetail(this, judul, keterangan);
                DialogResult result = input.ShowDialog();
                if (result != System.Windows.Forms.DialogResult.OK)
                {
                    cbRel.Checked = false;
                }
            }
            else
            {
                foreach (DataGridViewRow i in gridFinishing.Rows)
                {
                    if (i.Cells[0].Value.ToString() == judul)
                    {
                        gridFinishing.Rows.Remove(i);
                    }
                }
            }
        }

        private void cbPoly_CheckedChanged(object sender, EventArgs e)
        {
            string judul = "Poly";
            string keterangan = "Poly setelah / sebelum laminating? Warna apa? Ukuran brapa? Inschiet brapa?";
            if (cbPoly.Checked)
            {
                SubSalesFinishingDetail input = new SubSalesFinishingDetail(this, judul, keterangan);
                DialogResult result = input.ShowDialog();
                if (result != System.Windows.Forms.DialogResult.OK)
                {
                    cbPoly.Checked = false;
                }
            }
            else
            {
                foreach (DataGridViewRow i in gridFinishing.Rows)
                {
                    if (i.Cells[0].Value.ToString() == judul)
                    {
                        gridFinishing.Rows.Remove(i);
                    }
                }
            }
        }

        private void cbLipat_CheckedChanged(object sender, EventArgs e)
        {
            string judul = "Lipat";
            string keterangan = "Lipat brapa x? Ukuran jadinya brapa? bahan apa? brapa sisi? Disisir lagi ga?";
            if (cbLipat.Checked)
            {
                SubSalesFinishingDetail input = new SubSalesFinishingDetail(this, judul, keterangan);
                DialogResult result = input.ShowDialog();
                if (result != System.Windows.Forms.DialogResult.OK)
                {
                    cbLipat.Checked = false;
                }
            }
            else
            {
                foreach (DataGridViewRow i in gridFinishing.Rows)
                {
                    if (i.Cells[0].Value.ToString() == judul)
                    {
                        gridFinishing.Rows.Remove(i);
                    }
                }
            }
        }

        private void cbJRing_CheckedChanged(object sender, EventArgs e)
        {
            string judul = "Jilid Ring";
            string keterangan = "Ring ukuran brapa? Warna ring apa? Cover apa?";
            if (cbJRing.Checked)
            {
                SubSalesFinishingDetail input = new SubSalesFinishingDetail(this, judul, keterangan);
                DialogResult result = input.ShowDialog();
                if (result != System.Windows.Forms.DialogResult.OK)
                {
                    cbJRing.Checked = false;
                }
            }
            else
            {
                foreach (DataGridViewRow i in gridFinishing.Rows)
                {
                    if (i.Cells[0].Value.ToString() == judul)
                    {
                        gridFinishing.Rows.Remove(i);
                    }
                }
            }
        }

        private void cbJKaleng_CheckedChanged(object sender, EventArgs e)
        {
            string judul = "Jilid Kaleng";
            string keterangan = "Brapa lembar? Panjang brapa? Warna kaleng apa? Sebelah mana?";
            if (cbJKaleng.Checked)
            {
                SubSalesFinishingDetail input = new SubSalesFinishingDetail(this, judul, keterangan);
                DialogResult result = input.ShowDialog();
                if (result != System.Windows.Forms.DialogResult.OK)
                {
                    cbJKaleng.Checked = false;
                }
            }
            else
            {
                foreach (DataGridViewRow i in gridFinishing.Rows)
                {
                    if (i.Cells[0].Value.ToString() == judul)
                    {
                        gridFinishing.Rows.Remove(i);
                    }
                }
            }
        }

        private void cbJLakban_CheckedChanged(object sender, EventArgs e)
        {
            string judul = "Jilid Lakban";
            string keterangan = "Tipis? Tebel? Sedang? Double Tebal?";
            if (cbJLakban.Checked)
            {
                SubSalesFinishingDetail input = new SubSalesFinishingDetail(this, judul, keterangan);
                DialogResult result = input.ShowDialog();
                if (result != System.Windows.Forms.DialogResult.OK)
                {
                    cbJLakban.Checked = false;
                }
            }
            else
            {
                foreach (DataGridViewRow i in gridFinishing.Rows)
                {
                    if (i.Cells[0].Value.ToString() == judul)
                    {
                        gridFinishing.Rows.Remove(i);
                    }
                }
            }
        }

        private void cbJStaples_CheckedChanged(object sender, EventArgs e)
        {
            string judul = "Jilid Staples";
            string keterangan = "Staples bagian mana? Brapa halaman? Diset ga? Brapa tebal?";
            if (cbJStaples.Checked)
            {
                SubSalesFinishingDetail input = new SubSalesFinishingDetail(this, judul, keterangan);
                DialogResult result = input.ShowDialog();
                if (result != System.Windows.Forms.DialogResult.OK)
                {
                    cbJStaples.Checked = false;
                }
            }
            else
            {
                foreach (DataGridViewRow i in gridFinishing.Rows)
                {
                    if (i.Cells[0].Value.ToString() == judul)
                    {
                        gridFinishing.Rows.Remove(i);
                    }
                }
            }
        }

        private void cbJLemPanas_CheckedChanged(object sender, EventArgs e)
        {
            string judul = "Jilid Lem Panas";
            string keterangan = "Lem panas sebelah mana? portrait / landscape? ukuran? panjang yang di lem?";
            if (cbJLemPanas.Checked)
            {
                SubSalesFinishingDetail input = new SubSalesFinishingDetail(this, judul, keterangan);
                DialogResult result = input.ShowDialog();
                if (result != System.Windows.Forms.DialogResult.OK)
                {
                    cbJLemPanas.Checked = false;
                }
            }
            else
            {
                foreach (DataGridViewRow i in gridFinishing.Rows)
                {
                    if (i.Cells[0].Value.ToString() == judul)
                    {
                        gridFinishing.Rows.Remove(i);
                    }
                }
            }
        }

        private void cbPlastikUndangan_CheckedChanged(object sender, EventArgs e)
        {
            string judul = "Platik Undangan";
            string keterangan = "Seal ga? Di tempelin ga? Di masukin ga? Ukurannya brapa? Landscape atau portrait?";
            if (cbPlastikUndangan.Checked)
            {
                SubSalesFinishingDetail input = new SubSalesFinishingDetail(this, judul, keterangan);
                DialogResult result = input.ShowDialog();
                if (result != System.Windows.Forms.DialogResult.OK)
                {
                    cbPlastikUndangan.Checked = false;
                }
            }
            else
            {
                foreach (DataGridViewRow i in gridFinishing.Rows)
                {
                    if (i.Cells[0].Value.ToString() == judul)
                    {
                        gridFinishing.Rows.Remove(i);
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            finishing.Clear();
            foreach (DataGridViewRow i in gridFinishing.Rows)
            {
                finishing.Add(new string[3] { i.Cells[0].Value.ToString(), i.Cells[1].Value.ToString(), i.Cells[2].Value.ToString() });
            }


            subSalesOffset.DrawFinishing(finishing);
            this.Dispose();
        }
    }
}
