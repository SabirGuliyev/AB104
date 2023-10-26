using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.Liskov
{
    internal abstract class Bird
    {

       
        public virtual void Eat()
        {
            Console.WriteLine("Yem ile qidalanir");
        }
    }
}
