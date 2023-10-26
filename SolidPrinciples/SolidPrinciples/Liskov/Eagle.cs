using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.Liskov
{
    internal class Eagle : Bird,IFly
    {
        public int Age { get; set; }
      
        public int FlySpeed { get; set; }

        public override void Eat()
        {
            if (Age<5)
            {
                Console.WriteLine("worms ile qidalanir ");
            }
            else
            {
                Console.WriteLine("Meat ile qidalanir");
            }
        }

        public void Fly()
        {
            Console.WriteLine("Flied away");
        }

     
    }
}
