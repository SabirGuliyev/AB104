using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractOverrideSealed.Models
{
    internal class Master:Person
    {
        public string Diplom { get; set; }

        public override void GetInfo()
        {
            base.GetInfo();
        }
    }
}
