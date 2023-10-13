using InterfaceStatic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceStatic.Extensions
{
    internal static class Helper
    {

        public static string Capitalize(this string word)
        {
            return word.Substring(0, 1).ToUpper() + word.Substring(1).ToLower();
        }

        public static int Squared(this int num)
        {
            return num * num;
        }

        public static void Sum(this int num,int num2)
        {
            Console.WriteLine(num+num2);
        }

        public static void GetName(this Person person)
        {
            Console.WriteLine(person.Name);
        }
    }
}
