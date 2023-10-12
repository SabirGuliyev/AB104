using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractOverrideSealed.Models
{
    internal class Cow:Mammal
    {

        public void MakeMilk()
        {
            Console.WriteLine("Produced milk");
        }

        public override void MakeSound()
        {
            Console.WriteLine("Mooooooo");
        }
    }
}
