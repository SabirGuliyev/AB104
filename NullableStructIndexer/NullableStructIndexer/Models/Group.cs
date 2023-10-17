using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableStructIndexer.Models
{
    internal class Group
    {
        public string Name { get; set; }


        public Student[] Students { get; set; }


        public Student this[string index] { get
            {
                for (int i = 0; i < Students.Length; i++)
                {
                    if (Students[i].Fin==index)
                    {
                        return Students[i];
                    }
                }

                return null;
            } }
    }
}
