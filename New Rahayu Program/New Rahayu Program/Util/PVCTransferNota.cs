using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Drawing;

namespace Rahayu_Program.Util
{
    public static class PVCTransferNota
    {

        private static Point p(int x, int y)
        {
            return new Point(x, y);
        }

        internal static void printTransferReceipt(Graphics g, Font f, int pvcSalesID, DataTable header, DataTable detail)
        {
            StringFormat mid = new StringFormat();
            mid.Alignment = StringAlignment.Center;

            Brush b = Brushes.Black;
            DateTime tm = Other.Parser.TimeFromString(header.Rows[0]["transferTime"].ToString());
            string deliveryOfficer = header.Rows[0]["deliveryOfficer"].ToString();


            g.DrawString(String.Format("{0,-44}{1,33}", "LAPORAN PENGIRIMAN BARANG", tm.ToString("dd.MM.yy hh:mm"), tm.ToString("")), f, b, p(0, 0));
            g.DrawString(String.Format("{0,-77}", "CINCIN -> RAHAYU"), f, b, p(0, 18));
            g.DrawString("-----------------------------------------------------------------------------", f, b, p(0, 36));
            g.DrawString("==============================RINCIAN BARANG PVC=============================", f, b, p(0, 46));
            g.DrawString("-----------------------------------------------------------------------------", f, b, p(0, 56));

            int y = 72;
            //DETAIL <---------------
            if (detail != null)
            {
                int count = 0;
                for (int i = 0; i < detail.Rows.Count; i++, count++)
                {
                    Decimal qty = Decimal.Parse(detail.Rows[i]["quantity"].ToString());
                    Decimal pvcPerPack = Decimal.Parse(detail.Rows[i]["pvcPerPack"].ToString());
                    string pvcName = detail.Rows[i]["pvcName"].ToString();
                    string pvcTypeUnit = detail.Rows[i]["pvcTypeUnit"].ToString();

                    g.DrawString(String.Format("{0,6}{1,-19}{2,16} {3,-35}", (qty / pvcPerPack).ToString("#,##0"), " x " + pvcPerPack + " " + pvcTypeUnit + " = ", qty.ToString("#,##0") + " " + pvcTypeUnit + ".", pvcName), f, b, p(0, y));
                    y += 18;
                }
                y -= 4;
                g.DrawString("-----------------------------------------------------------------------------", f, b, p(0, y));
                y += 18;
                g.DrawString("                                                   JUMLAH ITEM : " + String.Format("{0,2}", count) + " ITEM(s).", f, b, p(0, y));
                y += 26;
                g.DrawString(String.Format("{0,77}", "PENGIRIM BARANG : " + deliveryOfficer), f, b, p(0, y));

                g.DrawRectangle(new Pen(Brushes.Black, 1), new Rectangle(0, 420, 790, 60));
                g.DrawString("          Pengecek                                        Pengirim           ", f, b, p(0, 420));
                g.DrawString(deliveryOfficer, new Font("Segoe UI", 11, FontStyle.Italic), b, p(642, 458), mid);
                g.DrawString("     Barang Sudah Dihitung", new Font("Segoe UI", 10, FontStyle.Italic), b, p(50, 460));
            }
        }
    }
}
