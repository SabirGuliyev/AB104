using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers.Models
{
    public class Person
    {
        private protected string Salary { get; set; }
        //protected internal string Name2 { get; set; }
        protected internal string Surname { get; set; }
    }
}
