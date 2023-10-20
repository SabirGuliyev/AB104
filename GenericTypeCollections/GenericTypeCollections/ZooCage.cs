using GenericTypeCollections.Animals;
using GenericTypeCollections.Foods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTypeCollections
{                               //generic constraints
    internal class ZooCage<T,U> where T:Animal,new()
                                where U : Food,new()
    {
        public T[] _animals = new T[0];

        public  U Food;

        public ZooCage(U food)
        {
            Food = food;

           
        }

        public void Add(T animal)
        {
            Array.Resize(ref _animals, _animals.Length + 1);
            _animals[_animals.Length-1] = animal;
        }
        public void ShowAnimals()
        {
            foreach (T animal in _animals)
            {
                Console.WriteLine(animal.Name);
            }
        }

        public void ShowFoodType()
        {
            Console.WriteLine(Food.TypeName);
        }
    }
}
