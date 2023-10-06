using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObjectInheritence.Models
{
    internal class Student:Person
    {

        public byte Course;

        public string Profession;
        public Student()
        {

        }
        public Student(string name) : base(name)
        {
            Console.WriteLine("Student created");
        }
    }
}
