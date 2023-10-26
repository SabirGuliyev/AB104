using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.Liskov
{
    internal interface ISwim
    {
        int SwimSpeed { get; set; }
        void Swim();
    }
}
