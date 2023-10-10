using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiersEncapsulationRecordTuple.Models
{
    //internal record PersonRecord
    //{
        //public string Name { get; init; }
        //public string Surname { get; init; }
        //public int Age { get; init; }
        //public PersonRecord(string name, string surname,int age)
        //{
        //   (Name,Surname,Age)=(name,surname,age);
        //}
    //}

    internal record PersonRecord(string Name, string Surname);
}
