using AbstractOverrideSealed.Models;

namespace AbstractOverrideSealed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Abstract
            //Dog dog = new Dog
            //{
            //    AvgLifeTime = 8,
            //    Breed = "Germna Shepard",
            //    Gender = "male",
            //    Name = "Rex"
            //};

            //Cow cow = new Cow
            //{
            //    AvgLifeTime = 6,
            //    Gender = "female",

            //};
            //Animal[] ferma = { dog, cow };

            //foreach (Animal animal in ferma)
            //{

            //    Console.WriteLine(animal.Gender);
            //    animal.Eat();
            //    animal.MakeSound();
            //    Console.WriteLine(animal.AvgLifeTime);


            //}


            //dog.MakeSound();
            //cow.MakeSound();

            //cow.Eat();
            //dog.Eat();
            //Animal animal = new Animal { AvgLifeTime = 20, Gender = "male" }; 
            #endregion



            #region Virtual Override

            //Student student = new Student
            //{
            //    Name = "Sabuhi",
            //    Surname = "Camalzade",
            //    Age = 19,
            //    Course = 3,
            //    University = "Aztu"
            //};

            //string Data=student.ToString();

            //Console.WriteLine(Data);

            //Console.WriteLine(student);
            //student.GetInfo();

            //Master master = new Master
            //{
            //    Name = "Aqil",
            //    Surname = "Baxshiyev",
            //    Age = 19,
            //    //Course = 3,
            //    //University = "Aztu",
            //    Diplom = "Red"
            //};


            //student.GetInfo();
            //master.GetInfo(); 
            #endregion
        }
    }
}