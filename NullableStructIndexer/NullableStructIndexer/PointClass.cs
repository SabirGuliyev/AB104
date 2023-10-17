using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableStructIndexer
{
    internal class PointClass
    {
        //public int X { get; set; }
        //public int Y { get; set; }

        //public string Name { get; set; } = null!;
        //public string Surname { get; set; }=null!;

        //public PointClass()
        //{

        //}

    }

    internal struct PointStruct
    {
        public int X { get; set; }
        public int Y { get; set; }
     

        //public PointStruct(int x)
        //{
        //    X= x;   
        //   Y= 0;
        //    Test = 0;
        //}
    }
    interface ITest
    {
        int Test { get; set; }
    }
}
