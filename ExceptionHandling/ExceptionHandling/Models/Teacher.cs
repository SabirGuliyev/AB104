using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling.Models
{
    internal class Teacher
    {
        public string _name;
        private decimal _salary;


        public string Surname { get; set; }

        public Teacher()
        {
            _salary = 23456;
        }

    }
}
