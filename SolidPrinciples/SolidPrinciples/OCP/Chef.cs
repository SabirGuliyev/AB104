using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.OCP
{
    internal class Chef
    {


        public void Cook(IMeal meal)
        {
            meal.MakeMeal();
        }

        //public void Potato()
        //{
        //    Console.WriteLine("1");
        //}
    }
}
