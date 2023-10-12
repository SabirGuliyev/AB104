using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractOverrideSealed.Models
{
    internal class Student:Person
    {
        public byte Course { get; set; }
        public string University { get; set; }

        public sealed override void GetInfo()
        {
            Console.WriteLine($"{Name} {Surname} {Age} {Course} {University}");
        }


        public override string ToString()
        {
            return $"Name:{Name} Surname:{Surname}";
            
        }


    }
}
