using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTypeCollections.Animals
{
    internal abstract class Animal
    {
        public int AvgLifetime { get; set; }
        public string Name { get; set; }

        //public override string ToString()
        //{
        //    return $"{Name}";
        //}
    }
}
