using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.Liskov
{
    internal class FlyShow<T> where T :IFly,new()
    {
        T bird = new T();
        public void MakeShow()
        {
            bird.Fly();
        }
    }
}
