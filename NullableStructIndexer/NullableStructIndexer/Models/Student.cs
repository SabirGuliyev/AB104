using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableStructIndexer.Models
{
    internal class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Fin { get; set; }


        public Gender Gender { get; set; }
    }
}
