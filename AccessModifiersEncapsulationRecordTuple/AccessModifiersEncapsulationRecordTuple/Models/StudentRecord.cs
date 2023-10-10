using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiersEncapsulationRecordTuple.Models
{
    internal record StudentRecord:PersonRecord
    {
        public StudentRecord(string name, string surname) : base(name, surname)
        {

        }
    }
}
