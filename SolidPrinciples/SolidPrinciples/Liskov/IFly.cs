using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.Liskov
{
    internal interface IFly
    {
        int FlySpeed { get; set; }
        void Fly();
    }
}
