using InterfaceStatic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceStatic.Models
{
    internal class Plane : IFly
    {
        public short FlySpeed { get ; set ; }

        public void Fly()
        {
            short speed = (short)(FlySpeed/2);
            Console.WriteLine("Plane Flied away "+speed);
        }
    }
}
