using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTypeCollections.Animals
{
    internal class Lion:Animal
    {
        public bool IsAlpha { get; set; }
        public void Roar()
        {
            Console.WriteLine("Roaaar");
        }
    }
}
