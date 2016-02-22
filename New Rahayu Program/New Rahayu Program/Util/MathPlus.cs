using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rahayu_Program.Util
{
    static class MathPlus
    {
        public static Decimal pembulatan500(Decimal qty, Decimal harga)
        {
            Decimal temp = qty * harga;
            return Convert.ToInt32(Math.Ceiling(Convert.ToDouble(temp) / 500)) * 500;
        }
    }
}
