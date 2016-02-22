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
    public partial class SubSalesOffset : Form
    {
        private MainForm main;
        private CreateSalesPrinting createSales;
        private List<string[]> finishing;
        private string status;
        private PrintingCreateSalesList selected;

        public SubSalesOffset(MainForm main, CreateSalesPrinting createSales, string status)
        {
            this.main = main;
            this.createSales = createSales;
            this.status = status;
            this.MdiParent = main;
            finishing = new List<string[]>();

            InitializeComponent();
        }

        internal void setData(PrintingCreateSalesList selected)
        {
            this.selected = selected;
            tbJenisCetakan.Text = selected.printingType;
            tbJudulCetakan.Text = selected.printingTitle;
            tbKeteranganCetak.Text = selected.description;
            tbMaterial.Text = selected.material;
            tbUkuranKertas.Text = selected.paperSize;
            tbUkuranGambar.Text = selected.imageSize;
            tbNote.Text = selected.note;
            tbJenisCetakan.Text = selected.printingType;

            string jobType = selected.jobType;
            if (jobType == "OF") OF();
            else if (jobType == "LL") LL();
            else if (jobType == "DG") DG();
            else if (jobType == "PL") PL();

            nudJumlahCetak.Value = selected.quantity;
            cbJumlahCetak.SelectedItem = selected.quantityType;
            nudInschiet.Value = selected.inschiet;
            cbInschiet.SelectedItem = selected.inschietType;
            nudJumlahPlat.Value = selected.totalPlat;
            
            int sisiCetak1 = Int32.Parse(selected.sidePrint.Substring(0,selected.sidePrint.IndexOf("/")));
            int sisiCetak2 = Int32.Parse(selected.sidePrint.Substring(selected.sidePrint.IndexOf("/") + 1));
            cbSisiCetak.SelectedItem = sisiCetak1+"";
            cbSisiCetak2.SelectedItem = sisiCetak2+"";

            DateTime deadline = selected.deadline;
            if (deadline < new DateTime(2000, 01, 01))
            {
                ckbDeadline.Checked = false;
                ckbDeadline_CheckedChanged();
            }
            else
            {
                ckbDeadline.Checked = true;
                ckbDeadline_CheckedChanged();
                dtpDeadline.Value = deadline;
            }

            nudHargaAsli.Value = selected.hargaAsli;
            nudHargaTotal.Value = selected.hargaOngkosCetak + selected.hargaMaterial;
            nudMaterial.Value = selected.hargaMaterial;
            nudOngkosCetak.Value = selected.hargaOngkosCetak;
            if (nudHargaAsli.Value == nudHargaTotal.Value)
            {
                ckbTitipan.Checked = false;
                ckbTitipan_CheckedChanged();
            }
            else
            {
                ckbTitipan.Checked = true;
                ckbTitipan_CheckedChanged();
            }

            nudCounter.Value = selected.jobType == "DG" ? selected.digitalCounter : selected.offsetCounter;

            DrawFinishing(selected.finishing);
        }

        private void ckbTitipan_CheckedChanged(object sender, EventArgs e)
        {
            ckbTitipan_CheckedChanged();
        }

        private void ckbTitipan_CheckedChanged()
        {
            if (ckbTitipan.Checked)
            {
                lblHargaAsli.Visible = true;
                nudHargaAsli.Visible = true;
                nudHargaAsli.Enabled = true;
                panel14.Visible = true;
                lblViewHargaAsli.Visible = true;
                nudViewHargaAsli.Visible = true;
            }
            else
            {
                lblHargaAsli.Visible = false;
                nudHargaAsli.Visible = false;
                nudHargaAsli.Enabled = false;
                panel14.Visible = false;
                lblViewHargaAsli.Visible = false;
                nudViewHargaAsli.Visible = false;
            }
        }

        private void SubSalesOffset_Load(object sender, EventArgs e)
        {
            ckbTitipan_CheckedChanged(sender, e); // refresh HARGA ASLI
            gridFinishing.Columns.Add("Judul", "Finishing");
            gridFinishing.Columns[0].Width = 200;
            gridFinishing.Columns.Add("Keterangan", "Keterangan");
            gridFinishing.Columns[1].Width = 310;
            gridFinishing.Columns.Add("Keterangan", "Note");
            gridFinishing.Columns[2].Width = 200;

            setCounter();
            cbSisiCetak.SelectedIndex = 0;
            cbSisiCetak2.SelectedIndex = 0;

            /*tbKeteranganCetak.Text = "Tidak pakai potong, karena cuma ongkos cetak, tidak di bungkus, orangnya mau ambil";
            tbJudulCetakan.Text = "Weddingku Festival Fair Fall Season 2016";
            tbJenisCetakan.Text = "Ongkos Cetak";
            nudJumlahCetak.Value = 200000;
            nudInschiet.Value = 2000;
            btnA3Plus_Click(sender, e);
            button3_Click(sender, e);
            btnOF_Click(sender, e);
            tbUkuranGambar.Text = "12x12cm";
            btn4Per0_Click(sender, e);
            tbNote.Text = "tidak diantar, diambil langsung sama orangnya, namanya si Budi";
            ckbDeadline.Checked = false;
            ckbDeadline_CheckedChanged(sender, e);
            ckbTitipan.Checked = false;
            ckbTitipan_CheckedChanged(sender, e);
            nudHargaAsli.Value = 1200000;
            nudMaterial.Value = 2000000;
            nudOngkosCetak.Value = 100000;

            cbSisiCetak.SelectedIndex = 0;
            cbSisiCetak2.SelectedIndex = 0;
            cbJumlahCetak.SelectedIndex = 0;
            cbInschiet.SelectedIndex = 0;
            nudJumlahPlat.Value = 4;*/

            cbJumlahCetak.SelectedIndex = 0;
            cbInschiet.SelectedIndex = 0;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnFinishing_Click(object sender, EventArgs e)
        {
            List<string[]> temp = new List<string[]>();
            foreach (DataGridViewRow i in gridFinishing.Rows)
            {
                temp.Add(new string[] { i.Cells[0].Value.ToString(), i.Cells[1].Value.ToString(), i.Cells[2].Value.ToString() });
            }

            SubSalesFinishing finishing = new SubSalesFinishing(this, temp);
            finishing.ShowDialog();
        }

        internal void DrawFinishing(List<string[]> finishing)
        {
            gridFinishing.Rows.Clear();
            foreach (string[] i in finishing)
            {
                gridFinishing.Rows.Add(i[0], i[1], i[2]);
            }
        }

        private void GetFinishing()
        {
            finishing.Clear();
            foreach (DataGridViewRow i in gridFinishing.Rows)
            {
                finishing.Add(new string[] { i.Cells[0].Value.ToString(), i.Cells[1].Value.ToString(), i.Cells[2].Value.ToString() });
            }
        }

        string ukuranKertas = "";
        string ukuranCetakan = "";
        string sisiCetak = "";
        string plat = "";
        string bahan = "";

        private void setViewDetail()
        {
            string detil = "";
            if (ukuranCetakan != "") detil += (detil != "" ? ", " : "") + "Gambar. " + ukuranCetakan;
            if (ukuranKertas != "") detil += (detil != "" ? ", " : "") + "Krts. " + ukuranKertas;
            if (sisiCetak != "") detil += (detil != "" ? ", " : "") + sisiCetak;
            if (plat != "") detil += (detil != "" ? ", " : "") + plat + " plat";
            if (bahan != "") detil += (detil != "" ? ", " : "") + bahan;
            tbViewDetail.Text = detil;
        }

        private void tbJenisCetakan_TextChanged(object sender, EventArgs e)
        {
            tbViewJenisCetakan.Text = tbJenisCetakan.Text;
        }

        private void tbJudulCetakan_TextChanged(object sender, EventArgs e)
        {
            tbViewJudulCetakan.Text = tbJudulCetakan.Text;
        }

        private void tbKeteranganCetak_TextChanged(object sender, EventArgs e)
        {
            tbViewKeterangan.Text = tbKeteranganCetak.Text;
        }

        private void tbMaterial_TextChanged(object sender, EventArgs e)
        {
            bahan = tbMaterial.Text;
            setViewDetail();
        }

        private void tbUkuranKertas_TextChanged(object sender, EventArgs e)
        {
            ukuranKertas = tbUkuranKertas.Text;
            setViewDetail();
        }

        private void tbUkuranGambar_TextChanged(object sender, EventArgs e)
        {
            ukuranCetakan = tbUkuranGambar.Text;
            setViewDetail();
        }

        private void cbSisiCetak2_SelectedIndexChanged(object sender, EventArgs e)
        {
            sisiCetak = cbSisiCetak.Text + "/" + cbSisiCetak2.Text;
            setViewDetail();
        }

        private void cbSisiCetak_SelectedIndexChanged(object sender, EventArgs e)
        {
            sisiCetak = cbSisiCetak.Text + "/" + cbSisiCetak2.Text;
            setViewDetail();
        }

        private void nudJumlahPlat_ValueChanged(object sender, EventArgs e)
        {
            plat = nudJumlahPlat.Value.ToString();
            setViewDetail();
        }

        private void tbNote_TextChanged(object sender, EventArgs e)
        {
            tbViewNote.Text = tbNote.Text;
        }

        private void ckbTempo_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void ckbDeadline_CheckedChanged(object sender, EventArgs e)
        {
            ckbDeadline_CheckedChanged();
        }

        private void ckbDeadline_CheckedChanged()
        {
            if (ckbDeadline.Checked)
            {
                dtpDeadline.Visible = true;
                tbViewDeadline.Text = dtpDeadline.Value.ToString("dd/MM/yy HH:mm");
            }
            else
            {
                dtpDeadline.Visible = false;
                tbViewDeadline.Text = "No Deadline";
            }
        }

        private void nudInschiet_ValueChanged(object sender, EventArgs e)
        {
            tbViewInschiet.Text = "+ " + nudInschiet.Value.ToString("#,##0") + " " + cbInschiet.Text;
        }

        private void cbInschiet_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbViewInschiet.Text = "+ " + nudInschiet.Value.ToString("#,##0") + " " + cbInschiet.Text;
        }

        private void nudJumlahCetak_ValueChanged(object sender, EventArgs e)
        {
            tbViewQty.Text = "(" + nudJumlahCetak.Value.ToString("#,##0") + " " + cbJumlahCetak.Text + ")";
        }

        private void cbJumlahCetak_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbViewQty.Text = "(" + nudJumlahCetak.Value.ToString("#,##0") + " " + cbJumlahCetak.Text + ")";
        }

        private void btn4Per4_Click(object sender, EventArgs e)
        {
            cbSisiCetak.SelectedItem = "4";
            cbSisiCetak2.SelectedItem = "4";
        }

        private void btn4Per0_Click(object sender, EventArgs e)
        {
            cbSisiCetak.SelectedItem = "4";
            cbSisiCetak2.SelectedItem = "0";
        }

        private void btn1Per0_Click(object sender, EventArgs e)
        {
            cbSisiCetak.SelectedItem = "1";
            cbSisiCetak2.SelectedItem = "0";
        }

        private void btn4Per4_Click_1(object sender, EventArgs e)
        {
            tbMaterial.Text = "ArtPaper 120gsm";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbMaterial.Text = "ArtPaper 150gsm";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tbMaterial.Text = "ArtCarton 260gsm";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tbMaterial.Text = "HVS Paper 100gsm";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tbMaterial.Text = "Bluish White (BW)";
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dtpDeadline_ValueChanged(object sender, EventArgs e)
        {
            tbViewDeadline.Text = dtpDeadline.Value.ToString("dd/MM/yy HH:mm");
        }

        private void dtpTempo_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void nudHargaAsli_ValueChanged(object sender, EventArgs e)
        {
            nudViewHargaAsli.Value = nudHargaAsli.Value;
        }

        private void nudMaterial_ValueChanged(object sender, EventArgs e)
        {
            nudViewMaterial.Value = nudMaterial.Value;
            nudHargaTotal.Value = nudMaterial.Value + nudOngkosCetak.Value;
        }

        private void nudOngkosCetak_ValueChanged(object sender, EventArgs e)
        {
            nudViewOngkosCetak.Value = nudOngkosCetak.Value;
            nudHargaTotal.Value = nudMaterial.Value + nudOngkosCetak.Value;
        }

        private void nudHargaTotal_ValueChanged(object sender, EventArgs e)
        {
            nudViewHargaTotal.Value = nudHargaTotal.Value;
        }

        private void btnKertas61_Click(object sender, EventArgs e)
        {
            tbUkuranKertas.Text = "31.5x42 cm";
        }

        private void btnA3Plus_Click(object sender, EventArgs e)
        {
            tbUkuranKertas.Text = "32x48 cm";
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (tbJenisCetakan.Text.Trim() == "")
                main.SetMessage("Isi Jenis Cetakan!");
            else if (tbJudulCetakan.Text.Trim() == "")
                main.SetMessage("Isi Judul Cetakan!");
            else if (nudJumlahCetak.Value == 0)
                main.SetMessage("Isi Jumlah Cetakan!");
            else if (tbMaterial.Text.Trim() == "")
                main.SetMessage("Isi Material!");
            else if (tbUkuranGambar.Text.Trim() == "")
                main.SetMessage("Isi Ukuran Gambar!");
            else
            {
                if (status == "update")
                {
                    if (selected != null)
                        createSales.deleteList(selected);
                }

                //add data
                GetFinishing();

                createSales.addNewCart(tbTipeJob.Text, tbViewJenisCetakan.Text, tbViewJudulCetakan.Text, "",
                    nudJumlahCetak.Value, cbJumlahCetak.Text, nudCounter.Value, nudInschiet.Value, cbInschiet.Text,
                    tbMaterial.Text, tbUkuranKertas.Text, tbUkuranGambar.Text, cbSisiCetak.Text + "/"
                    + cbSisiCetak2.Text, nudJumlahPlat.Value, tbViewKeterangan.Text, tbViewNote.Text,
                    ckbTitipan.Checked == true ? nudHargaAsli.Value : nudHargaTotal.Value,
                    nudViewMaterial.Value, nudViewOngkosCetak.Value, ckbDeadline.Checked == true ?
                    dtpDeadline.Value : DateTime.MinValue, finishing);

                this.Dispose();
            }
        }

        private void btn4Plat_Click(object sender, EventArgs e)
        {
            nudJumlahPlat.Value = 4;
        }

        private void btn8Plat_Click(object sender, EventArgs e)
        {
            nudJumlahPlat.Value = 8;
        }

        private void setCounter()
        {
            nudCounter.Value = 0;
            if (tbTipeJob.Text == "DG")
            {
                panelCounter.Visible = true;
            }
            else
            {
                panelCounter.Visible = false;
            }
        }

        private void btnLL_Click(object sender, EventArgs e)
        {
            LL();
        }

        private void LL()
        {
            tbTipeJob.Text = "LL";
            btnLL.BackColor = Color.Lime;
            btnOF.BackColor = Color.White;
            btnDG.BackColor = Color.White;
            btnPL.BackColor = Color.White;
            setCounter();
        }

        private void btnOF_Click(object sender, EventArgs e)
        {
            OF();
        }

        private void OF()
        {
            tbTipeJob.Text = "OF";
            btnLL.BackColor = Color.White;
            btnOF.BackColor = Color.Lime;
            btnDG.BackColor = Color.White;
            btnPL.BackColor = Color.White;
            setCounter();
        }

        private void btnDG_Click(object sender, EventArgs e)
        {
            DG();
        }

        private void DG()
        {
            tbTipeJob.Text = "DG";
            btnLL.BackColor = Color.White;
            btnOF.BackColor = Color.White;
            btnDG.BackColor = Color.Lime;
            btnPL.BackColor = Color.White;
            setCounter();
        }

        private void btnPL_Click(object sender, EventArgs e)
        {
            PL();
        }

        private void PL()
        {
            tbTipeJob.Text = "PL";
            btnLL.BackColor = Color.White;
            btnOF.BackColor = Color.White;
            btnDG.BackColor = Color.White;
            btnPL.BackColor = Color.Lime;
            setCounter();
        }

        private void btnSticker_Click(object sender, EventArgs e)
        {
            tbJenisCetakan.Text = "Sticker";
        }

        private void btnFlyer_Click(object sender, EventArgs e)
        {
            tbJenisCetakan.Text = "Flyer";
        }

        private void btnA3Plus2_Click(object sender, EventArgs e)
        {
            tbJenisCetakan.Text = "A3+";
        }

        private void btnPoster_Click(object sender, EventArgs e)
        {
            tbJenisCetakan.Text = "Poster";
        }

        private void btnSpanduk_Click(object sender, EventArgs e)
        {
            tbJenisCetakan.Text = "Spanduk";
        }

        private void btnBuku_Click(object sender, EventArgs e)
        {
            tbJenisCetakan.Text = "Buku";
        }

        private void nudCounter_ValueChanged(object sender, EventArgs e)
        {
            if (nudCounter.Value != 0)
                tbViewCounter.Text = nudCounter.Value.ToString("#,##0");
            else
                tbViewCounter.Text = "";
        }

        private void btnA3Plus3_Click(object sender, EventArgs e)
        {
            tbUkuranGambar.Text = "A3+";
        }

    }
}
