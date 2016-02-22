using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Rahayu_Program.Printing.Sales.SubSales
{
    public partial class PrintingCreateSalesList : UserControl
    {
        public string printingType;
        public string printingTitle;
        public string previewFile;
        public string jobType;
        public long quantity;
        public string quantityType;
        public int inschiet;
        public string inschietType;
        public string material;
        public string paperSize;
        public string imageSize;
        public string sidePrint;
        public int totalPlat;
        public string description;
        public string note;
        public long hargaAsli;
        public long hargaMaterial;
        public long hargaOngkosCetak;
        public DateTime deadline;
        public List<string[]> finishing;
        public int digitalCounter;
        public int offsetCounter;
        CreateSalesPrinting parent;

        public PrintingCreateSalesList(CreateSalesPrinting parent, string jobType, string printingType, string printingTitle, string previewFile, decimal quantity, string quantityType, decimal counter, decimal inschiet, string inschietType, string material, string paperSize, string imageSize, string sidePrint, decimal totalPlat, string description, string note, decimal hargaAsli, decimal hargaMaterial, decimal hargaOngkosCetak, DateTime deadline, List<string[]> finishing)
        {
            this.parent = parent;
            this.printingType = printingType;
            this.printingTitle = printingTitle;
            this.previewFile = previewFile;
            this.jobType = jobType;
            this.quantity = Convert.ToInt32(quantity);
            this.quantityType = quantityType;
            this.inschiet = Convert.ToInt32(inschiet);
            this.inschietType = inschietType;
            this.material = material;
            this.paperSize = paperSize;
            this.imageSize = imageSize;
            this.sidePrint = sidePrint;
            this.totalPlat = Convert.ToInt32(totalPlat);
            this.description = description;
            this.note = note;
            this.hargaAsli = Convert.ToInt64(hargaAsli);
            this.hargaMaterial = Convert.ToInt64(hargaMaterial);
            this.hargaOngkosCetak = Convert.ToInt64(hargaOngkosCetak);
            this.deadline = deadline;
            this.finishing = finishing;
            if (jobType == "DG") digitalCounter = Convert.ToInt32(counter);
            else if (jobType == "OF") offsetCounter = Convert.ToInt32(counter);

            InitializeComponent();
        }

        public long GetHargaAsli()
        {
            return hargaAsli;
        }

        public long GetHargaMaterial()
        {
            return hargaMaterial;
        }

        public long GetHargaOngkosCetak()
        {
            return hargaOngkosCetak;
        }

        private void PrintingCreateSalesList_Load(object sender, EventArgs e)
        {
            insertData();
        }

        private void insertData()
        {
            tbJenisCetakan.Text = printingType;
            tbJudulCetakan.Text = printingTitle;
            tbQty.Text = quantity + " " + quantityType;
            tbCounter.Text = jobType == "DG" ? digitalCounter.ToString("#,##0") : offsetCounter.ToString("#,##0");
            tbInschiet.Text = "+ " + inschiet + " " + inschietType;
            tbDeadLine.Text = deadline > DateTime.Now ? deadline.ToString("dd/MM/yy HH:mm") : "No Deadline";
            tbJobType.Text = jobType;
            string detil = "";
            if (imageSize != "") detil += (detil != "" ? ", " : "") + "Gambar. " + imageSize;
            if (paperSize != "") detil += (detil != "" ? ", " : "") + "Krts. " + paperSize;
            if (sidePrint != "") detil += (detil != ""? ", " : "") + sidePrint;
            if (totalPlat != 0) detil += (detil != ""? ", " : "") + totalPlat + " plat";
            if (material != "") detil += (detil != ""? ", " : "") + material;
            tbDetail.Text = detil;
            tbKeterangan.Text = description;
            tbNote.Text = note;
            nudHargaAsli.Value = hargaAsli;
            if (hargaAsli == hargaMaterial + hargaOngkosCetak)
            {
                nudHargaAsli.Visible = false;
                lblViewHargaAsli.Visible = false;   
                panel12.Visible = false;
            }
            nudMaterial.Value = hargaMaterial;
            nudOngkosCetak.Value = hargaOngkosCetak;

            gridFinishing.Columns.Add("Judul", "Finishing");
            gridFinishing.Columns[0].Width = 200;
            gridFinishing.Columns.Add("Keterangan", "Keterangan");
            gridFinishing.Columns[1].Width = 310;
            gridFinishing.Columns.Add("Keterangan", "Note");
            gridFinishing.Columns[2].Width = 200;

            gridFinishing.Rows.Clear();
            if (finishing != null)
                foreach (string[] i in finishing)
                {
                    gridFinishing.Rows.Add(i[0], i[1], i[2]);
                }

            /*
            int y = 105;
            if (finishing == null)
            {
                //NO FINISHING
            }
            else
            {
                if (finishing.Count == 0)
                {
                }
                else
                {
                    for (int i = 0; i < finishing.Count; i++)
                    {
                        TextBox judul = new TextBox();
                        judul.Text = finishing[i][0];
                        judul.Location = new Point(3, y);
                        judul.Size = new Size(158, 25);
                        judul.BackColor = Color.Black;
                        judul.ForeColor = Color.White;
                        judul.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                        Controls.Add(judul);

                        TextBox isi = new TextBox();
                        isi.Text = finishing[i][1];
                        isi.Location = new Point(159, y);
                        isi.Size = new Size(574, 25);
                        isi.BackColor = Color.Black;
                        isi.ForeColor = Color.White;
                        isi.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                        Controls.Add(isi);

                        y += 23;
                    }
                    y += 5;
                }
            }

            nudQty.Location = new Point(nudQty.Location.X, y);
            nudPrice.Location = new Point(nudPrice.Location.X, y);
            nudSubTotal.Location = new Point(nudSubTotal.Location.X, y);
            lblPrice.Location = new Point(lblPrice.Location.X, y + 8);
            lblTotal.Location = new Point(lblTotal.Location.X, y + 8);
            panelTutup1.Location = new Point(panelTutup1.Location.X, y - 3);
            panelTutup2.Location = new Point(panelTutup2.Location.X, y - 3);
            panelTutup3.Location = new Point(panelTutup3.Location.X, y - 3);

            this.Size = new Size(this.Width, y + 40);
             * */
        }

        private void nudMaterial_ValueChanged(object sender, EventArgs e)
        {
            getTotalHarga();
        }

        private void nudOngkosCetak_ValueChanged(object sender, EventArgs e)
        {
            getTotalHarga();
        }

        private void getTotalHarga()
        {
            nudHargaTotal.Value = nudMaterial.Value + nudOngkosCetak.Value;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            parent.deleteList(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            parent.updateList(this);
        }
    }
}
