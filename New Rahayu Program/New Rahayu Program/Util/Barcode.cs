using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OnBarcode.Barcode;
using System.Drawing.Printing;
using System.Drawing;
using System.Data;

namespace Rahayu_Program.Util.Barcode
{
    public static class Barcode
    {
        public static string buatKodeHuruf(string price)
        {
            string kode = "";
            for (int i = 0; i < price.Length; i++)
            {
                if (price[i] == '1') kode += 'J';
                else if (price[i] == '2') kode += 'U';
                else if (price[i] == '3') kode += 'M';
                else if (price[i] == '4') kode += 'P';
                else if (price[i] == '5') kode += 'S';
                else if (price[i] == '6') kode += 'O';
                else if (price[i] == '7') kode += 'V';
                else if (price[i] == '8') kode += 'E';
                else if (price[i] == '9') kode += 'R';
                else if (price[i] == '0' && i != price.Length - 1)
                    if (price[i + 1] != '0')
                    {
                        kode += 'J';
                        break;
                    }
                    else
                    {
                        break;
                    }
            }

            if (kode.Length > 0)
                return kode.Substring(0, (kode.Length < 3) ? kode.Length : 3);
            else
                return "";
        }

        public static int buatHargaDariKode(string kode, int sellPrice)
        {
            string price = "";
            for (int i = 0; i < kode.Length; i++)
            {
                if (kode[i] == 'J') price += '1';
                else if (kode[i] == 'U') price += '2';
                else if (kode[i] == 'M') price += '3';
                else if (kode[i] == 'P') price += '4';
                else if (kode[i] == 'S') price += '5';
                else if (kode[i] == 'O') price += '6';
                else if (kode[i] == 'V') price += '7';
                else if (kode[i] == 'E') price += '8';
                else if (kode[i] == 'R') price += '9';
            }

            string sell = sellPrice + "";
            int panjangSell = sell.Length;
            int panjangBuy = price.Length;
            int selisih = panjangSell - panjangBuy;
            for (int i = 0; i < selisih; i++)
            {
                price += "0";
            }

            if (price == "")
            {
                return 0;
            }
            else if (Int32.Parse(price) >= sellPrice)
            {
                return Int32.Parse(price) / 10;
            }
            else
            {
                return Int32.Parse(price);
            }
        }

        public static void printBarcodeLayout(Graphics g, Font font, Font font2, Image barcodeImg, string namaBarang, string nomorBarang, string hargaBeli, int hargaJual)
        {
            Image img = barcodeImg;
            g.DrawString(namaBarang, font, Brushes.Black, new Point(4, 1));
            g.DrawString(namaBarang, font, Brushes.Black, new Point(143, 1));
            g.DrawString(namaBarang, font, Brushes.Black, new Point(282, 1));

            Point location = new Point(4, 10);
            g.DrawImage(img, location);
            location = new Point(143, 10);
            g.DrawImage(img, location);
            location = new Point(282, 10);
            g.DrawImage(img, location);

            g.DrawString(nomorBarang, font, Brushes.Black, new Point(4, 50));
            g.DrawString(nomorBarang, font, Brushes.Black, new Point(143, 50));
            g.DrawString(nomorBarang, font, Brushes.Black, new Point(282, 50));

            StringFormat f = new StringFormat();
            f.Alignment = StringAlignment.Far;

            g.DrawString(hargaJual.ToString("#,###"), font, Brushes.Black, new Point(4 + 127, 50), f);
            g.DrawString(hargaJual.ToString("#,###"), font, Brushes.Black, new Point(143 + 127, 50), f);
            g.DrawString(hargaJual.ToString("#,###"), font, Brushes.Black, new Point(282 + 127, 50), f);

            g.DrawString(Util.Barcode.Barcode.buatKodeHuruf(hargaBeli), font2, Brushes.Black, new Point(4 + 127, 25), f);
            g.DrawString(Util.Barcode.Barcode.buatKodeHuruf(hargaBeli), font2, Brushes.Black, new Point(143 + 127, 25), f);
            g.DrawString(Util.Barcode.Barcode.buatKodeHuruf(hargaBeli), font2, Brushes.Black, new Point(282 + 127, 25), f);
        }

        public static void printBarcodeFromDataTable(Graphics g, Font font, Font font2, DataTable dt)
        {
            
        }

        private static Image cropImage(Image img, Rectangle cropArea)
        {
            Bitmap bmpImage = new Bitmap(img);
            Bitmap bmpCrop = bmpImage.Clone(cropArea, bmpImage.PixelFormat);
            bmpImage.Dispose();
            return (Image)(bmpCrop);
        }

        public static Image createBarcode(string kode)
        {
            Image barImg = null;
            
            // Create a linear object and set barcode symbology type to Code-39
            Linear barcode = new Linear();
            barcode.Type = BarcodeType.CODE128;

            // Set barcode value
            barcode.Data = kode;

            // Set barcode bar width (X module) and bar height (Y module)
            barcode.X = 1;
            barcode.Y = 60;

            // Generate barcode and encode barcode to gif format
            barcode.Format = System.Drawing.Imaging.ImageFormat.Jpeg;
            barcode.drawBarcode("barcode.jpg");

            // Print barcode to C# Bitmap object
            Bitmap barcodeInBitmap = barcode.drawBarcode();

            //pictureBox1.Image = barcodeInBitmap;
            //MessageBox.Show("height: " + barcodeInBitmap.Width);
            barImg = cropImage(barcodeInBitmap, new Rectangle(0, 15, barcodeInBitmap.Width, 39));
            
            return barImg;
        }


        internal static void printBarcodeFromArray(Graphics g, Font font, Font kodeFont, string[] nomorBarang, string[] namaBarang, int[] sellPrice, int[] buyPrice)
        {
            StringFormat f = new StringFormat();
            f.Alignment = StringAlignment.Far;
            Image img;
            Point location;
            for (int i = 0; i < 3; i++)
            {
                img = createBarcode(nomorBarang[i]);

                g.DrawString(namaBarang[i], font, Brushes.Black, new Point(i==0?4:i==1?143:282, 1));
                g.DrawString(nomorBarang[i], font, Brushes.Black, new Point(i == 0 ? 4 : i == 1 ? 143 : 282, 50));
                location = new Point(i == 0 ? 4 : i == 1 ? 143 : 282, 10);
                g.DrawImage(img, location);

                g.DrawString(sellPrice[i].ToString("#,###"), font, Brushes.Black, new Point((i == 0 ? 4 : i == 1 ? 143 : 282) + 127, 50), f);
                g.DrawString(Util.Barcode.Barcode.buatKodeHuruf(buyPrice[i] + ""), kodeFont, Brushes.Black, new Point((i == 0 ? 4 : i == 1 ? 143 : 282) + 127, 25), f);
            }
        }
    }
}
