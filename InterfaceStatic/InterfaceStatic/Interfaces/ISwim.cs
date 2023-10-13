using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceStatic.Interfaces
{
    internal interface ISwim
    {
        short SwimSpeed { get; set; }

        void Swim();
    }
}
