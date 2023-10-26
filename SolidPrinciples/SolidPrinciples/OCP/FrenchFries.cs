using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.OCP
{
    internal class FrenchFries : IMeal
    {
        public void MakeMeal()
        {
            Console.WriteLine("French fries hazirlandi");
        }
    }
}
