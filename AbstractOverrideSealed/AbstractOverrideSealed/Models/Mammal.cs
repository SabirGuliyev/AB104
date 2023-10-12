using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractOverrideSealed.Models
{
    internal abstract class Mammal:Animal
    {
        public void BornAChild()
        {
            Console.WriteLine("Welcome");
        }
    }
}
