using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceStatic.Models
{
    public abstract class Animal
    {
        public byte AvgLifetime { get; set; }
        public string Gender { get; set; }

        public abstract void MakeSound();

        public virtual void Eat()
        {
            Console.WriteLine("Yem ile qidalanir");
        }
    }
}
