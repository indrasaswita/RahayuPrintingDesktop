using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rahayu_Program.Other
{
    public static class Validasi
    {
        public static Boolean isDigit(string text)
        {
            Boolean digit = true;
            for (int i = 0; i < text.Length; i++)
            {
                if (Char.IsDigit(text[i]) == false)
                {
                    digit = false;
                    break;
                }
            }
            return digit;
        }
    }
}
