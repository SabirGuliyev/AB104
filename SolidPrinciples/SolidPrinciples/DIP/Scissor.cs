using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.DIP
{
    internal class Scissor : ICut
    {
        public void Cut()
        {
            Console.WriteLine("Cut by scissor");
        }
    }
}
