using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceStatic.Models
{
    internal class Person
    {
        //public static Person[] People = new Person[0];



        //public static byte _retirementAge=65;

        //public static int _peopleCount=10000;


        public static int Count=0;

        public int Id { get; set; }  
        public string Name { get; set; }
        public string Surname { get; set; }

        //static Person()
        //{
        //    _retirementAge = 65;
        //}

        public Person()
        {
            
            Count++;
            Id = Count;
        }

      
        public void GetInfo()
        {
            Console.WriteLine($"{Name} {Surname}");
               
            
        }

       

        //public static void AddPeopleCount()
        //{
        //    _peopleCount+=1000;
        //} 
    }
}
