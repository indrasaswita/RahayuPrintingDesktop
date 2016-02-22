using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace Rahayu_Program.Other
{
    class Parser
    {
        public static String StringToMD5(String text)
        {
            MD5 temp = System.Security.Cryptography.MD5.Create();
            String encPass = GetMd5Hash(temp, text);

            return encPass;
        }

        public static String GetMd5Hash(MD5 md5Hash, String input)
        {
            Byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
            StringBuilder sBuilder = new StringBuilder();

            for(int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            return sBuilder.ToString();
        }

        public static DateTime TimeFromString(string text)
        {
            int sp1 = text.IndexOf("/");
            int sp2 = text.Substring(sp1 + 1).IndexOf("/") + sp1 + 1;
            int sp3 = text.Substring(sp2 + 1).IndexOf(" ") + sp2 + 1;
            int sp4 = text.Substring(sp3 + 1).IndexOf(":") + sp3 + 1;
            int sp5 = text.Substring(sp4 + 1).IndexOf(":") + sp4 + 1;
            int sp6 = text.Substring(sp5 + 1).IndexOf(" ") + sp5 + 1;

            int tanggal = Int32.Parse(text.Substring(0, sp1));
            int bulan = Int32.Parse(text.Substring(sp1 + 1, sp2 - sp1 - 1));
            int tahun = Int32.Parse(text.Substring(sp2 + 1, sp3 - sp2 - 1));
            int jam = Int32.Parse(text.Substring(sp3 + 1, sp4 - sp3 - 1));
            int menit = Int32.Parse(text.Substring(sp4 + 1, sp5 - sp4 - 1));
            int detik;
            if (sp6 - sp5 - 1 <= 0)
            {
                detik = Int32.Parse(text.Substring(sp5 + 1));
            }
            else
            {
                detik = Int32.Parse(text.Substring(sp5 + 1, sp6 - sp5 - 1));
                string ampm = text.Substring(sp6 + 1);
                jam += (ampm == "AM") ? 0 : (jam == 12) ? 0 : 12;
            }
            
            return new DateTime(tahun, bulan, tanggal, jam, menit, detik);
        }
    }
}
