using ExceptionHandling.Models;
using ExceptionHandling.Utilities.Exceptions;
using System.Reflection;

namespace ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Exception
            //int num;
            //int num2;

            //try
            //{
            //num = int.Parse(Console.ReadLine());
            //num2 = int.Parse(Console.ReadLine());

            //    Console.WriteLine(num/num2);

            //    string word = "salam";

            //    Console.WriteLine(word[45]);

            //}
            //catch(DivideByZeroException e)
            //{
            //    Console.WriteLine(e.Message);
            //    num2 = 1;

            //    Console.WriteLine("Divide olan catch ishe dushdu");
            //} 
            //catch(FormatException e)
            //{
            //    Console.WriteLine(e.Message);
            //    num = 0;
            //    num2 = 0;
            //    Console.WriteLine("2ci catch ishe dushdu");
            //}
            //catch(Exception e)
            //{
            //    Console.WriteLine("Qaqa bunu mende gozlemirdim");
            //}


            //Console.WriteLine("Bu setire catdi");




            //string[] names = { "Adil", "Shamama", "Vagif", "Murad" };


            //string name = "sabir";

            //try
            //{
            //    Search("adil", names);
            //    Console.WriteLine("Bele telebe movcuddur");
            //}
            //catch (Exception e)
            //{

            //}
            //finally
            //{
            //    Console.WriteLine("bu setr her zaman ishleyir");
            //}

            //Console.WriteLine("Salam bu str oxunmayacaq");




            //Console.WriteLine("salam");



            //Student student = new Student("s");


            //Console.WriteLine(student.Name);


            #endregion


            Assembly assembly = Assembly.GetExecutingAssembly();

            //Type[] types=assembly.GetTypes();



            //foreach (var type in types)
            // {

            //     Console.WriteLine("-----------------------------------------");
            //     Console.WriteLine(type.Name);

            //     foreach (MemberInfo member in type.GetMembers())
            //     {
            //         Console.WriteLine(member);
            //     }
            //
            // 


           Teacher teacher = new Teacher();

            Type type = teacher.GetType();

            Type type2 = assembly.GetType("ExceptionHandling.Models.Teacher");

            Console.WriteLine(type2.Name);

            FieldInfo field=type.GetField("_salary",BindingFlags.NonPublic |BindingFlags.Instance);

            field.SetValue(teacher, 40000m);

            Console.WriteLine(field.GetValue(teacher));









        }

        public static bool Search(string search, string[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Trim().ToLower()==search.Trim().ToLower())
                {
                    return true;
                }
            }

            //throw new NotFoundException($"{search} was not found");
            return false;

        }

    }
}