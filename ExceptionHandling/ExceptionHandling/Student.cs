using ExceptionHandling.Utilities.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class Student
    {
        public string _name;

        public string Name
        {
            get { return _name; }
            set { 
                value = value.Trim();
                if (value.Length>=3)
                {
                    _name = value;
                }
                //else
                //{
                //    throw new NameFormatException(value+" was not in correct format");
                //}
              
            }
        }

        public Student(string name)
        {
            Name = name;
        }

    }
}
