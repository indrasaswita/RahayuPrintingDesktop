using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Data;

namespace Rahayu_Program.Util
{
    public static class PVCSalesNota
    {
        private static Point p(int x, int y)
        {
            return new Point(x, y);
        }

        public static void printSalesReceipt(Graphics g, Font f, int pvcSalesID, DataTable header, DataTable detail, DataTable payment)
        {
            Brush b = Brushes.Black;
            DateTime tm = Other.Parser.TimeFromString(header.Rows[0]["salesTime"].ToString());
            string customerName = header.Rows[0]["customerName"].ToString();
            string customerPhone = header.Rows[0]["phone"].ToString();
            g.DrawString(String.Format("{0,-44}{1,33}", "NOTA", tm.ToString("dd.MM.yy hh:mm")), f, b, p(0, 0));
            g.DrawString(String.Format("{0,-46}{1,31}", "PVC: CORE, OVERLAY, DIGITAL, MAGNETIC", customerName + (customerPhone != "" ? "(" + customerPhone + ")" : "")), f, b, p(0, 20));
            g.DrawString("     MIFARE, SEALCOAT, ONGKOS CETAK", f, b, p(0, 37));
            g.DrawString("-----------------------------------------------------------------------------", f, b, p(0, 50));
            g.DrawString("==============================RINCIAN BARANG PVC=============================", f, b, p(0, 60));
            g.DrawString("-----------------------------------------------------------------------------", f, b, p(0, 70));
            int y = 85; //awal dari item list beli

            //DETAIL <---------------
            int grandTotal = 0;
            if (detail != null)
            {
                for (int i = 0; i < detail.Rows.Count; i++)
                {
                    Decimal qty = Decimal.Parse(detail.Rows[i]["quantity"].ToString());
                    int sellPrice = Int32.Parse(detail.Rows[i]["sellPrice"].ToString());
                    int subtotal = Convert.ToInt32(qty * sellPrice);
                    Decimal pvcPerPack = Decimal.Parse(detail.Rows[i]["pvcPerPack"].ToString());
                    string pvcName = detail.Rows[i]["pvcName"].ToString();
                    string pvcTypeUnit = detail.Rows[i]["pvcTypeUnit"].ToString();

                    g.DrawString(String.Format("{0,6}{1,-19}{2,16} {3,-35}", (qty / pvcPerPack).ToString("#,##0"), " x " + pvcPerPack + " " + pvcTypeUnit + " = ", qty.ToString("#,##0") + " " + pvcTypeUnit + ".", pvcName), f, b, p(0, y));
                    y += 16;
                    g.DrawString(String.Format("{0,58} {1,18}", qty.ToString("#,##0") + " " + pvcTypeUnit + " x @ Rp" + sellPrice.ToString("#,##0") + " =", subtotal.ToString("#,##0")), f, b, p(0, y));
                    grandTotal += subtotal;
                    y += 20;
                }
                g.DrawString("-----------------------------------------------------------------------------", f, b, p(0, y - 8));
            }
            g.DrawString(String.Format("{0,61} {1,15}", "TOTAL BELANJA = Rp", grandTotal.ToString("#,##0")), f, b, p(0, y + 5));
            y += 40;


            //PAYMENT <-----------------
            int totalBayar = 0;
            if (payment != null)
            {
                g.DrawString("                        -----------------------------------------------------", f, b, p(0, y));
                y += 10;
                g.DrawString("                        ===================RINCIAN PEMBAYARAN================", f, b, p(0, y));
                y += 10;
                g.DrawString("                        -----------------------------------------------------", f, b, p(0, y));
                y += 15;
                for (int i = 0; i < payment.Rows.Count; i++)
                {
                    int ammount = Int32.Parse(payment.Rows[i]["ammount"].ToString());
                    DateTime paymentTime = Other.Parser.TimeFromString(payment.Rows[i]["paymentTime"].ToString());
                    string method = payment.Rows[i]["paymentMethod"].ToString();

                    g.DrawString(String.Format("                        {0,-16} {1,15} {2,20}", paymentTime.ToString("dd.MM.yyyy HH:mm"), method, ammount.ToString("#,##0")), f, b, p(0, y));
                    y += 18;
                    totalBayar += ammount;
                }
                g.DrawString("                        -----------------------------------------------------", f, b, p(0, y - 8));
                g.DrawString(String.Format("{0,61} {1,15}", "TOTAL BAYAR = Rp", totalBayar.ToString("#,##0")), f, b, p(0, y + 5));
                g.DrawString(String.Format("{0,61} {1,15}", "SISA BAYAR = Rp", (grandTotal - totalBayar).ToString("#,##0")), f, b, p(0, y + 23));
                y += 25;

                g.DrawRectangle(new Pen(Brushes.Black, 1), new Rectangle(0, 420, 790, 60));
                g.DrawString("          Penerima                                      Hormat Kami     ", f, b, p(0, 420));
                g.DrawString("     Barang Sudah Dihitung", new Font("Segoe UI", 10, FontStyle.Italic), b, p(50, 460));
                g.DrawString("PERHATIAN!!", new Font("Segoe UI", 10, FontStyle.Bold), b, p(335, 420));
                g.DrawString("Barang Yang Sudah Dibeli,", new Font("Segoe UI", 10, FontStyle.Regular), b, p(300, 433));
                g.DrawString("Tidak Dapat Dikembalikan/Ditukar.", new Font("Segoe UI", 10, FontStyle.Regular), b, p(275, 446));
                g.DrawString("-Thank You-", new Font("Segoe UI", 8, FontStyle.Regular), b, p(348, 464));
            }

        }
    }
}
