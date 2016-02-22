using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Rahayu_Program.Util
{
    class PrintingDetailCustomer
    {
        private static int y = 0;
        private static int spacing = 14;

        private static void addY()
        {
            y += spacing;
        }

        private static Point p(int x, int y)
        {
            return new Point(x, y);
        }

        // MAX X : 250

        public static void printDetailCustomer(Graphics g, Font f, string coName, string coAddress, string coPhone, string cuName, string cuAddress, string cuPhone)
        {

            StringFormat mid = new StringFormat();
            mid.Alignment = StringAlignment.Center;
            Brush b = Brushes.Black;
            //g.DrawString("0123456789012345678901234567890123456789012345678901234567890123456789", f, b, p(0, 10));
            g.DrawString("ALAMAT PENGIRIMAN", f, b, p(0, y));
            addY();
            g.DrawString("Print Date : " + DateTime.Now.ToString("dd/MM/yy"), f, b, p(0, y));
            
            //g.DrawRectangle(new Pen(Brushes.Black, 1), new Rectangle(0, 45, 250, 18));
            //g.DrawString(coName, f, b, p(0, 47));
            y = 60;


            g.DrawString("TUJUAN : ", f, b, p(0, y));
            addY();
            if (coName != "")
            {
                printString(g, coName, f); 
                printString(g, "Up. " + cuName, f);
            }
            if (coPhone != "") printString(g, coPhone, f);
            if (coAddress != "") printString(g, coAddress, f);
            addY();
            if (cuName != "") printString(g, cuName, f);
            if (cuPhone != "") printString(g, cuPhone, f);
            if (cuAddress != "") printString(g, cuAddress, f);

            addY();
            addY();
            g.DrawString("DARI : ", f, b, p(0, y));
            addY();
            printString(g, "RAHAYU PRINTING", f);
            printString(g, "Jl. Pangeran Jayakarta 113, Mangga Dua Selatan, Jakarta Pusat 10730", f);
            printString(g, "(021) 649 1502, 649 1101", f);
            printString(g, "0813 1551 9889", f);
        }

        private static void printString(Graphics g, string txt, Font f)
        {
            int line = 0;
            for (int ix = 0; ix < txt.Length; )
            {
                int chars;

                string temp;
                if (txt.Length - ix > 25)
                {
                    temp = txt.Substring(ix, 25);

                    int spIdx = temp.LastIndexOf(" ");
                    if (spIdx != -1)
                    {
                        chars = spIdx;
                    }
                    else
                    {
                        chars = 25;
                    }
                    g.DrawString(txt.Substring(ix, chars), f, Brushes.Black, p(0, y));

                    addY();

                    ++line;
                    ix += chars;
                }
                else
                {
                    temp = txt.Substring(ix);
                    g.DrawString(txt.Substring(ix), f, Brushes.Black, p(0, y));
                    
                    addY();

                    ++line;
                    break;
                }
            }
        }

    }
}
