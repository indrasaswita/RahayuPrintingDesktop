using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace Rahayu_Program.Util
{
    class Converter
    {
        public static string addThousandSeparator(int input)
        {
            return input.ToString("#,###");
        }

        public static string addThousandSeparator(string input)
        {
            try
            {
                return Int32.Parse(input).ToString("#,###");
            }
            catch
            {
                return "";
            }
        }

        public static string MD5Hash(string text)
        {
            MD5 md5 = new MD5CryptoServiceProvider();

            //compute hash from the bytes of text
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(text));

            //get hash result after compute it
            byte[] result = md5.Hash;

            StringBuilder strBuilder = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                //change it into 2 hexadecimal digits
                //for each byte
                strBuilder.Append(result[i].ToString("x2"));
            }

            return strBuilder.ToString();
        }

        public static string GetTerbilang(decimal input)
        {
            //string input = angka + "";
            //int panjang = input.Length;

            //string hasil = "";

            //for (int i = 0; i < panjang; i++)
            //{
            //    if (input[i] != '0')
            //        hasil += GetKataDariAngka(input[i]) + " ";
            //    hasil += GetThousandPlace(panjang - i - 1, input[i]);
            //}

            //return hasil + " = " + angka.ToString("#,##0");


            Int64 angka = Convert.ToInt64(input);
            return (terbilang(angka) + " Rupiah").Replace("  ", " ");
        }

        public static string terbilang(Int64 angka)
        {
            string strterbilang = "";
            // membuat array untuk mengubah 1 - 11 menjadi terbilang 
            string[] a = { "", "Satu", "Dua", "Tiga", "Empat", "Lima", "Enam", "Tujuh", "Delapan", "Sembilan", "Sepuluh", "Sebelas" };

            if (angka < 12)
            {
                strterbilang = " " + a[angka];
            }
            else if (angka < 20)
            {
                strterbilang = terbilang(angka - 10) + " Belas";
            }
            else if (angka < 100)
            {
                strterbilang = terbilang(angka / 10) + " Puluh" + terbilang(angka % 10);
            }
            else if (angka < 200)
            {
                strterbilang = " Seratus" + terbilang(angka - 100);
            }
            else if (angka < 1000)
            {
                strterbilang = terbilang(angka / 100) + " Ratus" + terbilang(angka % 100);
            }
            else if (angka < 2000)
            {
                strterbilang = " Seribu" + terbilang(angka - 1000);
            }
            else if (angka < 1000000)
            {
                strterbilang = terbilang(angka / 1000) + " Ribu" + terbilang(angka % 1000);
            }
            else if (angka < 1000000000)
            {
                strterbilang = terbilang(angka / 1000000) + " Juta" + terbilang(angka % 1000000);
            }

            // menghilangkan multiple space 
            strterbilang = System.Text.RegularExpressions.Regex.Replace(strterbilang, @"^\s+|\s+$", " ");
            // mengembalikan hasil terbilang 
            return strterbilang;
        }
    }
}
