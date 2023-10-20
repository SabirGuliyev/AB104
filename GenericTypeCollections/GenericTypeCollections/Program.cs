using GenericTypeCollections.Animals;
using GenericTypeCollections.Foods;
using System.Collections;

namespace GenericTypeCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region GenericType

            //Product<int> product = new Product<int>(90);
            //product.Quality += 5;
            //Console.WriteLine(product.Quality);


            //Product<char> product2 = new Product<char>('A');
            //product2.Quality = char.ToLower(product2.Quality);
            //Console.WriteLine(product2.Quality);

            //Product<string> product3 = new Product<string>("High");
            //product3.Quality = "Low";
            //Console.WriteLine(product3.Quality);


            //Lion lion = new Lion { AvgLifetime=30,IsAlpha=true,Name="Simba"};
            //Lion lion2 = new Lion { AvgLifetime=30,IsAlpha=false,Name="Alex"};

            //Meat meat = new Meat { TypeName="Beef"};

            //ZooCage<Lion,Meat> zooLion = new ZooCage<Lion,Meat>(meat);

            //zooLion.Add(lion);
            //zooLion.Add(lion2);
            //zooLion.ShowAnimals();
            //zooLion.ShowFoodType();

            //Console.WriteLine("--------------------------------------------");

            //Elephant elephant = new Elephant { AvgLifetime=40,TeethWeight=20,Name="Hakuna"};
            //Elephant elephant2 = new Elephant { AvgLifetime=40,TeethWeight=25,Name="Matata"};

            //Grass grass = new Grass { TypeName="Yonca"};

            //ZooCage<Elephant,Grass> zooElephant = new ZooCage<Elephant,Grass>(grass);

            //zooElephant.Add(elephant);
            //zooElephant.Add(elephant2);
            //zooElephant.ShowAnimals();
            //zooElephant.ShowFoodType();


            //Person person=new Person { Name="Subhan"};

            //ZooCage<Lion, Meat> zooCage = new ZooCage<int, string>("salam");


            #endregion


            //Array List
            //ArrayList arr=new ArrayList();

            //arr.Add(34);
            //arr.Add("salam");
            //arr.Add('c');

            //foreach(var item in arr)
            //{
            //    Console.WriteLine(item);
            //}

            //SortedList sortedList = new SortedList();
            //sortedList.Add(6,"Adil");
            //sortedList.Add(2,"Kamal");
            //sortedList.Add(1,"Kamal");

            //foreach (DictionaryEntry item in sortedList)
            //{
            //    Console.WriteLine(item.Value);
            //}



            //SortedList<char, string> sorted = new SortedList<char, string>();

            //sorted.Add('b', "Adil");
            //sorted.Add('z', "Adil2");
            //sorted.Add('f', "Murad");
            //sorted.Add('a', "Leyla");
            //Console.WriteLine(sorted.TryAdd('z', "Zulfiyye") ); 


            //foreach (var item in sorted)
            //{
            //    Console.WriteLine(item.Key+" "+item.Value);
            //}
            //Console.WriteLine(sorted['f']);


            //LIFO
            //Stack<string> names=new Stack<string>();

            //names.Push("Baki");
            //names.Push("Berde");
            //names.Push("Sumqayit");
            //names.Push("Naxcivan");
            //names.Push("Shusha");
            //Console.WriteLine(names.Peek()+" axrinci daxil olan");
        
           

            //string popedData;
            //Console.WriteLine(names.TryPop(out popedData)) ;
            //Console.WriteLine(popedData);



            //foreach (var item in names)
            //{
            //    Console.WriteLine(item);
            //}


            Queue<string> queue = new Queue<string>();
            queue.Enqueue("Asiman");
            queue.Enqueue("Nihat");
            queue.Enqueue("Reshad");

            //queue.Peek();

            //queue.TryDequeue();
            //queue.Dequeue();
            //queue.Dequeue();
            //queue.Dequeue();


            //foreach (var item in queue)
            //{
            //    Console.WriteLine(item);
            //}
            //for (int i = 0; i < queue.Count; i++)
            //{
            //    Console.WriteLine(queue.ElementAt(i));
            //}


            //Dictionary<string, string> dictionary = new Dictionary<string, string>();

            //dictionary.Add("c3", "Muslum");
            //dictionary.Add("c1", "Shamama");
            //dictionary.Add("c2", "Tofiq");
            //dictionary.TryAdd("c2", "Tofiq");

            //foreach (var item in dictionary)
            //{
            //    Console.WriteLine(item.Key+" "+item.Value);
            //}
            //Console.WriteLine(dictionary["c1"]);

            //Evde LinkedList


            List<int> nums=new List<int>();
            List<int> nums2=new List<int> { 8,9,100};
            nums.Add(1);
            nums.Add(2);
            nums.Add(0);
            nums.Add(7);

            //nums.Remove(7);

            nums.AddRange(nums2);

            nums.RemoveAll(x => x > 5);

            for (int i = 0; i < nums.Count; i++)
            {
                Console.WriteLine(nums[i]);
            }

            //foreach (var item in nums)
            //{
            //    Console.WriteLine(item);
            //}


        }
    }
}