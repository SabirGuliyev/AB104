using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.DIP
{
    internal class Knife : ICut
    {

        public Knife()
        {
            throw new Exception("Lisenziya yoxdur");
        }
        public void Cut()
        {
            Console.WriteLine("Cut by knife");
        }
    }
}
