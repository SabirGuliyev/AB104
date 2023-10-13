using InterfaceStatic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceStatic.Models
{
    internal class Duck : Bird,ISwimFly
    {
        public short FlySpeed { get ; set; }
        public short SwimSpeed { get ; set ; }

        public void Fly()
        {
           
            Console.WriteLine("Duck flied away " + FlySpeed * 5);
        }

        public override void MakeSound()
        {
            Console.WriteLine("caqk");
        }

        public void Swim()
        {
            throw new NotImplementedException();
        }
    }
}
