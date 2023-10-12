using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractOverrideSealed.Models
{
    internal abstract class Animal
    {

        public byte AvgLifeTime { get; set; }

        public string Gender { get; set; }

        public Animal()
        {
            //Console.WriteLine("Animal ctor ishe dushdu");
        }
        public virtual void Eat()
        {
            Console.WriteLine("Yem ile qidalanir");
        }

        public abstract void MakeSound();
        
    }
}
