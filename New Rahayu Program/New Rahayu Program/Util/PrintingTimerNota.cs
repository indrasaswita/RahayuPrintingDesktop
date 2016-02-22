using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Data;

namespace Rahayu_Program.Util
{
    class PrintingTimerNota
    {
        private static Point p(int x, int y)
        {
            return new Point(x, y);
        }

        public static void printTimerReceipt(Graphics g, Font f, int printingTimerID, int HARGA_PER_JAM, DataTable header, DataTable detail)
        {
            StringFormat mid = new StringFormat();
            mid.Alignment = StringAlignment.Center;

            Brush b = Brushes.Black;
            string customerName = header.Rows[0]["customerName"].ToString();
            string customerPhone = header.Rows[0]["phone"].ToString();
            string employeeName = header.Rows[0]["employeeName"].ToString();
            g.DrawString(String.Format("{0,-4} {1:D7}{2,20}", "NOTA", printingTimerID, employeeName), f, b, p(0, 10));
            g.DrawString(String.Format("{0,32}", customerName + (customerPhone != "" ? "(" + customerPhone + ")" : "")), f, b, p(0, 25));

            g.DrawRectangle(new Pen(Brushes.Black, 1), new Rectangle(0, 45, 250, 18));
            g.DrawString("RINCIAN BIAYA SETTING", f, b, p(0, 47));

            int y = 66; //awal dari item list beli

            //DETAIL <---------------
            int grandTotal = 0;
            if (detail != null)
            {
                for (int i = 0; i < detail.Rows.Count; i++)
                {
                    DateTime awal = Other.Parser.TimeFromString(detail.Rows[i]["awal"].ToString());
                    DateTime akhir = Other.Parser.TimeFromString(detail.Rows[i]["akhir"].ToString());

                    int harga = Convert.ToInt32((akhir - awal).TotalSeconds * (HARGA_PER_JAM / 3600));
                    g.DrawString(String.Format("{0,8} - {1,8} :Rp{2, 9}", awal.ToString("HH:mm:ss"), akhir.ToString("HH:mm:ss"), harga.ToString("#,##0")), f, b, p(0, y));
                    y += 16;
                    //g.DrawString(String.Format("{0,58} {1,18}", qty.ToString("#,##0") + " " + pvcTypeUnit + " x @ Rp" + sellPrice.ToString("#,##0") + " =", subtotal.ToString("#,##0")), f, b, p(0, y));
                    grandTotal += harga;
                    //y += 20;
                }
                g.DrawLine(new Pen(Brushes.Black, 1), new Point(0, y + 1), new Point(250, y + 1));
                if (HARGA_PER_JAM / 2 > grandTotal)
                {
                    g.DrawString(String.Format("{0,19} =Rp{1, 9}", "TOTAL ITEM", grandTotal.ToString("#,##0")), f, b, p(0, y + 5));
                    g.DrawString(String.Format("{0,19} =Rp{1, 9}", "MINIMUM", (HARGA_PER_JAM / 2 - grandTotal).ToString("#,##0")), f, b, p(0, y + 20));
                    g.DrawLine(new Pen(Brushes.Black, 1), new Point(100, y + 37), new Point(251, y + 37));
                    g.DrawString(String.Format("{0,19} =Rp{1, 9}", "TOTAL BELANJA", (HARGA_PER_JAM / 2).ToString("#,##0")), f, b, p(0, y + 40));
                    y = y + 65;
                }
                else
                {
                    g.DrawString(String.Format("{0,19} =Rp{1, 9}", "TOTAL BELANJA", grandTotal.ToString("#,##0")), f, b, p(0, y + 5));
                    y = y + 30;
                }

                g.DrawString("Seluruh FILE HASIL SETTING,", f, b, p(125, y + 5), mid);
                g.DrawString("sepenuhnya milik pelanggan.", f, b, p(125, y + 18), mid);

                g.DrawString("TERIMA KASIH", f, b, p(125, y + 35), mid);

                g.DrawString("HOTLINE 0813 1551 9889", f, b, p(125, y + 75), mid);
            }
            y += 40;


            //PAYMENT <-----------------
            //int totalBayar = 0;
            //if (payment != null)
            //{
            //    g.DrawString("                        -----------------------------------------------------", f, b, p(0, y));
            //    y += 10;
            //    g.DrawString("                        ===================RINCIAN PEMBAYARAN================", f, b, p(0, y));
            //    y += 10;
            //    g.DrawString("                        -----------------------------------------------------", f, b, p(0, y));
            //    y += 15;
            //    for (int i = 0; i < payment.Rows.Count; i++)
            //    {
            //        int ammount = Int32.Parse(payment.Rows[i]["ammount"].ToString());
            //        DateTime paymentTime = Other.Parser.TimeFromString(payment.Rows[i]["paymentTime"].ToString());
            //        string method = payment.Rows[i]["paymentMethod"].ToString();

            //        g.DrawString(String.Format("                        {0,-16} {1,15} {2,20}", paymentTime.ToString("dd.MM.yyyy HH:mm"), method, ammount.ToString("#,##0")), f, b, p(0, y));
            //        y += 18;
            //        totalBayar += ammount;
            //    }
            //    g.DrawString("                        -----------------------------------------------------", f, b, p(0, y - 8));
            //    g.DrawString(String.Format("{0,61} {1,15}", "TOTAL BAYAR = Rp", totalBayar.ToString("#,##0")), f, b, p(0, y + 5));
            //    g.DrawString(String.Format("{0,61} {1,15}", "SISA BAYAR = Rp", (grandTotal - totalBayar).ToString("#,##0")), f, b, p(0, y + 23));
            //    y += 25;

            //    g.DrawRectangle(new Pen(Brushes.Black, 1), new Rectangle(0, 420, 790, 60));
            //    g.DrawString("          Penerima                                      Hormat Kami     ", f, b, p(0, 420));
            //    g.DrawString("     Barang Sudah Dihitung", new Font("Segoe UI", 10, FontStyle.Italic), b, p(50, 460));
            //    g.DrawString("PERHATIAN!!", new Font("Segoe UI", 10, FontStyle.Bold), b, p(335, 420));
            //    g.DrawString("Barang Yang Sudah Dibeli,", new Font("Segoe UI", 10, FontStyle.Regular), b, p(300, 433));
            //    g.DrawString("Tidak Dapat Dikembalikan/Ditukar.", new Font("Segoe UI", 10, FontStyle.Regular), b, p(275, 446));
            //    g.DrawString("-Thank You-", new Font("Segoe UI", 8, FontStyle.Regular), b, p(348, 464));
            //}

        }
    }
}
