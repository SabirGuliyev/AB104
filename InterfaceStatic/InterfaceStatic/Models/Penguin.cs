using InterfaceStatic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceStatic.Models
{
    internal class Penguin:Bird,ISwim
    {
        public short SwimSpeed { get ; set; }

        public override void MakeSound()
        {
            Console.WriteLine("Penguin sound");
        }

        public void Swim()
        {
            Console.WriteLine("Swam away");
        }

       
    }
}
