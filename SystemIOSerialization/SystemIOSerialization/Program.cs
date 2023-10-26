using Newtonsoft.Json;
using SystemIOSerialization.Models;

namespace SystemIOSerialization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Directory,File, Stream
            //Directory.CreateDirectory(@"C:\Users\sabir\Desktop\Test");



            //if (!File.Exists(@"C:\Users\sabir\Desktop\Test\text.txt"))
            //{
            //    File.Create(@"C:\Users\sabir\Desktop\Test\text.txt").Close();
            //}


            //File.Delete(@"C:\Users\sabir\Desktop\Test\text.txt");
            //if (Directory.Exists(@"C:\Users\sabir\Desktop\Test2"))
            //{
            //    Directory.Delete(@"C:\Users\sabir\Desktop\Test2", true);
            //}

            //DirectoryInfo directory = new DirectoryInfo(@"C:\Users\sabir\Desktop\Test2");

            //directory.Create();
            //directory.Delete();
            //directory.Exists;

            //FileInfo 
            //StreamReader sr = new StreamReader(@"C:\Users\sabir\Desktop\Test\text.txt");
            //try
            //{


            //    //Console.WriteLine(sr.ReadLine());
            //    //Console.WriteLine(sr.ReadLine());
            //    //Console.WriteLine(sr.ReadLine());

            //    Console.WriteLine(sr.ReadToEnd());

            //}
            //catch (Exception)
            //{

            //    throw;
            //}
            //finally
            //{
            //    sr.Close();
            //}








            //StreamWriter sw = new StreamWriter(@"C:\Users\sabir\Desktop\Test\text.txt", true);

            //sw.WriteLine("Sabuhi3 Camalzade");
            //sw.WriteLine("Vagif3 Qarayev");
            //sw.WriteLine("Muslum3 Xalilov");

            //sw.Close();


            //using StreamWriter sw=new StreamWriter(@"C:\Users\sabir\Desktop\Test\text.txt", true))
            //{
            //    sw.WriteLine("Salam gencler3");
            //}

            //string result;

            //using(StreamReader sr=new StreamReader(@"C:\Users\sabir\Desktop\Test\text.txt"))
            //{
            //    result=sr.ReadToEnd();
            //}

            //Console.WriteLine(result); 
            #endregion


            Category category = new Category { Name = "Mobile" };

            Product product = new Product { Id = 1, Category = category, Name = "Iphone 15" };
            Product product2 = new Product { Id = 2, Category = category, Name = "Samsung S22" };
            Product product3 = new Product { Id = 3, Category = category, Name = "Xiaomi POCO X5" };

            List<Product> products = new List<Product> { product, product2, product3 };


            //string result = JsonConvert.SerializeObject(products);


            //using(StreamWriter sw=new StreamWriter(@"C:\Users\sabir\OneDrive\Рабочий стол\SystemIOSerialization\SystemIOSerialization\Files\JsonObjects.json"))
            //{
            //    sw.Write(result);
            //}


            string json;
            using (StreamReader sr = new StreamReader(@"C:\Users\sabir\OneDrive\Рабочий стол\SystemIOSerialization\SystemIOSerialization\Files\JsonObjects.json"))
            {
               json= sr.ReadToEnd();
            }

            List<Product> getProducts=  JsonConvert.DeserializeObject<List<Product>>(json);


            getProducts.Add(new Product { Id = 5, Category = category, Name = "Sony Erikson" });


            string result2 = JsonConvert.SerializeObject(getProducts);

            using(StreamWriter sw=new StreamWriter(@"C:\Users\sabir\OneDrive\Рабочий стол\SystemIOSerialization\SystemIOSerialization\Files\JsonObjects.json"))
            {
                sw.WriteLine(result2);
            }



            Console.WriteLine(Directory.GetCurrentDirectory());


            //foreach (var item in getProducts)
            //{
            //    Console.WriteLine(item.Name);
            //}







        }
    }
}