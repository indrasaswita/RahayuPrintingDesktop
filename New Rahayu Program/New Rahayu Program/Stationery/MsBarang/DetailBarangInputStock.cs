using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OnBarcode.Barcode;
using System.Drawing.Printing;

namespace Rahayu_Program.Stationery.MsBarang
{
    public partial class DetailBarangInputStock : UserControl
    {
        private Image barImg;
        private Font courierFont, kodeFont;

        private string hargaBeli;
        private int hargaJual;
        private int min, stock;
        private string nomorBarang;
        private string namaBarang;

        private InputStockByBarang parent;

        public DetailBarangInputStock(InputStockByBarang parent, string nomorBarang, string namaBarang, int stock, int min, int hargaJual, int hargaBeli)
        {
            this.nomorBarang = nomorBarang;
            this.parent = parent;

            this.namaBarang = namaBarang;
            this.hargaJual = hargaJual;
            this.hargaBeli = "" + hargaBeli;
            this.stock = stock;
            this.min = min;

            InitializeComponent();
            
            courierFont = new Font("Courier New", 6, FontStyle.Bold);
            kodeFont = new Font("Courier New", 12, FontStyle.Bold);
        }

        public DataTable ExecuteQuery(string query)
        {
            return parent.ExecuteQuery(query);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //PRINT BARCODENYA

            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(printPage);
            pd.PrinterSettings.PrinterName = "ZDesigner GK420t";
            pd.PrintController = new StandardPrintController(); ;

            pd.Print();
        }

        private void printPage(object o, PrintPageEventArgs e)
        {
            barImg = Util.Barcode.Barcode.createBarcode(tbNomorBarang.Text);
            Util.Barcode.Barcode.printBarcodeLayout(e.Graphics, courierFont, kodeFont, barImg, namaBarang, nomorBarang, hargaBeli, hargaJual);
        }

        public void setFocus()
        {
            nudStock.Focus();
            nudStock.Select(0, 9);
        }

        private void DetailBarangInputStock_Load(object sender, EventArgs e)
        {
            RefreshUI();
        }

        private void RefreshUI()
        {
            tbNomorBarang.Text = nomorBarang;
            tbNamaBarang.Text = namaBarang;
            nudHarga.Value = hargaJual;
            nudMin.Value = min;
            nudStock.Value = stock;
        }

        private void tbNamaBarang_TextChanged(object sender, EventArgs e)
        {
            namaBarang = tbNamaBarang.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ExecuteQuery("UPDATE MsBarang SET sellPrice = " + nudHarga.Value + ", stock = " + nudStock.Value + ", batasStock = " + nudMin.Value + " WHERE barangID = '" + nomorBarang + "'");
            RefreshData();
            RefreshUI();

            parent.SetNext(this);
        }

        public void FocusOn()
        {
            nudStock.Focus();
            nudStock.Select(0, 9);
        }
        
        private void RefreshData()
        {
            if (tbNomorBarang.Text.Length == 6)
            {
                DataTable dt = ExecuteQuery("SELECT * FROM MsBarang WHERE barangID = '" + nomorBarang + "'");
                if (dt.Rows.Count == 1)
                {
                    hargaJual = Int32.Parse(dt.Rows[0]["sellPrice"].ToString());
                    hargaBeli = dt.Rows[0]["buyPrice"].ToString();
                    min = Int32.Parse(dt.Rows[0]["batasStock"].ToString());
                    stock = Int32.Parse(dt.Rows[0]["stock"].ToString());
                    namaBarang = dt.Rows[0]["namaBarang"].ToString();
                }
                else
                {
                    MessageBox.Show("Error Ni Program di Detail Barang Input Stock");
                    Application.Exit();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RefreshData();
            RefreshUI();
            button3.Focus();
        }

        private void nudStock_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                nudMin.Focus();
                nudMin.Select(0, 9);
            }
        }

        private void nudMin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                nudHarga.Focus();
                nudHarga.Select(0, 9);
            }
        }

        private void nudHarga_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button3.Focus();
            }
        }
        
    }
}
