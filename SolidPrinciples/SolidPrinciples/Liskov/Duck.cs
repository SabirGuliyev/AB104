using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.Liskov
{
    internal class Duck : Bird, ISwim,IFly
    {
        public int SwimSpeed { get  ; set ; }
        public int FlySpeed { get  ; set ; }

        public void Fly()
        {
            Console.WriteLine("Duck flied away");
        }

        public void Swim()
        {
            Console.WriteLine("Duck swam away");
        }
    }
}
