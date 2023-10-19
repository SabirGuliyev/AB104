using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpcastingImplicit
{
    internal class Dollar
    {
        public decimal Usd { get; set; }

        public Dollar(decimal usd)
        {
            Usd = usd;
        }
        //public static explicit operator Dollar(Manat manat)
        //{
        //    return new Dollar(manat.Azn / 1.7m);
        //}
        public static implicit operator Dollar(Manat manat)
        {
            return new Dollar(manat.Azn / 1.7m);
        }


    }
}
