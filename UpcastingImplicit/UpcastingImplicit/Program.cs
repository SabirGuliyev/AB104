using UpcastingImplicit.Models;

namespace UpcastingImplicit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Upcasting Downcasting Boxing unboxing
            //Dog animalDog = new Dog { Breed = "Golden retriever", Name = "Bobik", AvgLifetime = 16 };
            //Eagle eagle = new Eagle { FlySpeed = 200, Name = "Shahingozlum", AvgLifetime = 25 };

            //object[] objects= { animalDog, eagle,"Salam",45m };

            //foreach (var item in objects)
            //{
            //    Eagle eagle1 = item as Eagle;

            //    if (eagle1!=null)
            //    {
            //        Console.WriteLine(eagle1.FlySpeed);
            //    }
            //}




            //Animal[] zoo = { animalDog, eagle };

            //foreach (Animal animal in zoo)
            //{

            // Dog dog2 = (Dog)animal;1) Explicit

            //Dog dog=animal as Dog;2) As casting operator

            //if (dog is not null)
            //{
            //    Console.WriteLine(dog.Breed);
            //}

            //3) is operatoru cast operatoru deyil!!!!!!!!!!!!!!
            //if (animal is Dog dog)
            //{
            //    Console.WriteLine(dog.Breed);
            //    dog.Bark();
            //}

            //Console.WriteLine(dog2.Breed);
            //dog2.Bark();
            //}





            //Animal animal= new Dog { Breed = "Golden retriever", Name = "Bobik", AvgLifetime = 16 };   //implicit casting

            //Animal animal2 = new Eagle { FlySpeed = 200 };

            //Dog dog2 = (Dog)animal2;

            //Console.WriteLine(dog2.Breed);
            //dog2.Bark();

            //foreach (Animal animal in zoo)
            //{
            //    animal.
            //} 
            #endregion



            //Dollar dollar = new Dollar(200);
            //Manat manat = new Manat(340);

            //dollar = manat;
            //manat = 200m;

            //Console.WriteLine(manat.Azn);

            //manat = dollar;


            //Manat manat2 = dollar1;

            //Console.WriteLine(manat2.Azn);

            //dollar = new Dollar(manat.Azn / 1.7m);

           
            


            Manat manat = new Manat(200);
            Manat manat2 = new Manat(100);

            Console.WriteLine(manat>100m);

            manat += manat2;

            //Type type = typeof(Manat);


            Console.WriteLine(manat.Azn);
        }

      
    }
}