using ClassObjectInheritence.Models;

namespace ClassObjectInheritence
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Anonymous Object
            //object student = new
            //{
            //    Name = "Adil",
            //    Surname = "Nasirli",
            //    Age = 18

            //};

            //object student2 = new
            //{
            //    Name = "Sabuhi",
            //    Surname = "Camalzade"


            //};

            //Console.WriteLine(student.GetType().GetProperty("Name").GetValue(student)); 
            #endregion

            //Person person = new Person("a", "s", 18);

            //person.Name = "Adil";
            //person.Surname = "Nasirli";
            //person.Age = 18;

            //Person person2 = new Person
            //{
            //    Name = "Sabuhi",
            //    Surname = "Camalzade",
            //    Age = 19
            //};


            //person.GetInfo();
            //person2.GetInfo();

            //Person person3 = new Person("sabir","aliyev",18);

            ////person3.GetInfo();


            //Person person4 = new Person("Sabuhi", "Camalzade");
            //person4.GetInfo();

            //Person person5 = new Person("Sabir","Quliyev",19);

            //Person person = new Person("aa","bb",18);

            //person.GetInfo();




            Student student = new Student("Adil");
            student.GetInfo();
          


            //Teacher teacher = new Teacher
            //{
            //    Age = 25,
            //    Name = "Sabir",
            //    Surname = "Quliyev",

            //    Experience = 20,
            //    Salary = 23456
            //};

            //student.GetInfo();
            //teacher.GetInfo();  




        }
    }

    class Person
    {
        //Fields

        public string Name;
        

        public string Surname;

        public byte Age;

        //Constructor
        public Person(string name)
        {
            Name = name;
        }

        public Person()
        {

        }
        #region ctor overload
        //public Person()
        //{
        //    Console.WriteLine("Created person");
        //}
        //public Person(string name):this()
        //{

        //    Name = name;
        //}

        //public Person(string name,string surname):this(name)
        //{

        //    Surname = surname;
        //}
        //public Person(string name, string surname,byte age):this(name,surname)
        //{

        //    Age = age;
        //} 
        #endregion


        //Method

        public void GetInfo()
        {
            Console.WriteLine($"{Name} {Surname} {Age}");
        }

    }



}