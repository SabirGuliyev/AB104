using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpcastingImplicit
{
    internal class Manat
    {
        public decimal Azn { get; set; }
        public int Inflation { get; set; }
        public Manat(decimal azn)
        {
            Azn = azn;
        }



        public static bool operator ==(Manat manat,Manat manat2)
        {
            return manat.Azn == manat2.Azn;
        }
        public static bool operator !=(Manat manat, Manat manat2)
        {
            return manat.Azn != manat2.Azn;
        }

        public static bool operator >(Manat manat,Manat manat2)
        {
            return manat.Azn > manat2.Azn;
        }
        public static bool operator <(Manat manat, Manat manat2)
        {
            return manat.Azn < manat2.Azn;
        }

        public static bool operator >(Manat manat, decimal value)
        {
            return manat.Azn > value;
        }
        public static bool operator <(Manat manat, decimal value)
        {
            return manat.Azn < value;
        }

        public static Manat operator +(Manat manat,Manat manat2)
        {
            return new Manat(manat.Azn + manat2.Azn);
        }














        public static implicit operator Manat(Dollar dollar)
        {
            return new Manat(dollar.Usd * 1.7m);
        }
        //public static implicit operator Manat(decimal value)
        //{
        //    return new Manat(value);
        //}

    }
}
