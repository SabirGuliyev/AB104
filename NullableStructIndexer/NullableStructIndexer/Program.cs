using NullableStructIndexer.Models;

namespace NullableStructIndexer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Nullable
            //string name = String.Empty;

            //int[] arr=null;


            //if (!String.IsNullOrEmpty(name))
            //{
            //    Console.WriteLine(name.Length);
            //}

            //if (arr is null)
            //{
            //    Console.WriteLine("Nulldir");
            //}
            //else
            //{
            //    Console.WriteLine(arr.Length);
            //}


            //arr = new int[] { 1, 2, 3 };

            //Console.WriteLine(name[0]);

            //int num = null;

            //Console.WriteLine();
            //int age;
            //age = 20;


            //int? num=null;

            //int num3=num.GetValueOrDefault(5);


            //Console.WriteLine(num3);
            //if (num.HasValue)
            //{
            //    int num2 = num.Value;
            //    Console.WriteLine(num);
            //}
            //else
            //{
            //    Console.WriteLine("Nulldir");
            //}


            #endregion
            #region Struct

            //PointClass pointClass;
            //pointClass = new PointClass { X=3,Y=4};
            //pointClass.X = 2;
            //Console.WriteLine(pointClass.X);

            //Console.WriteLine("-----------------------------");

            //PointStruct pointStruct;
            //pointStruct = new PointStruct { X=3,Y=4}; 
            //pointStruct.X = 2;
            //Console.WriteLine(pointStruct.X);

            #endregion
            #region Indexer

            CustomList<int> listInt = new CustomList<int>(10);
            //listInt[15] = 30;
            CustomList<int> listInt1 = new CustomList<int>(1, 2, 3, 4, 5, 6, 77, 88);
            //Console.WriteLine(listInt[15]);

            for (int i = 0; i < listInt1.Length; i++)
            {
                Console.WriteLine(listInt1[i]);
            }

            listInt1.Add(1);


            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6 };
            numbers.Add(1);
           

            Student student = new Student { Name = "Sabuhi", Surname = "Camalzade", Fin = "c",Gender=Gender.Male };
            //Student student2 = new Student { Name = "Zulfiyya", Surname = "Camalzade", Fin = "c1" };
            //Student student3 = new Student { Name = "Asiman", Surname = "Camalzade", Fin = "c2" };
            //Student student4 = new Student { Name = "Aqil", Surname = "Camalzade", Fin = "c3" };

            //Group group = new Group
            //{
            //    Name = "AB102",
            //    Students = new Student[] { student, student2, student3, student4 }
            //};


            //Console.WriteLine(group.Students[0].Name);
            //Student searched = group["c3"];

            //if (searched != null)
            //{
            //    Console.WriteLine(searched.Name);
            //}
            //else
            //{
            //    Console.WriteLine("Bele telebe movcud deyil");

            //} 








            //CustomList<string> customList = new CustomList<string>("Salam", "Hello", "Halo", "Shalom");

            //CustomList<char> customList1 = new CustomList<char>('a', 'v', 'g');

            #endregion


            //Console.WriteLine((int)WeekDays.Sunday);

            Console.WriteLine("Please choose deay of week");
            foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
            {
                Console.WriteLine((int)day+")"+day);
            }

            
            int choice;
            string str = Console.ReadLine();

            int.TryParse(str, out choice);


            switch (choice)
            {
                case (byte)WeekDays.Monday:
                    Console.WriteLine(WeekDays.Monday);
                    break;
                case (int)WeekDays.Tuesday:
                    Console.WriteLine(WeekDays.Tuesday);
                    break;
                case (int)WeekDays.Wednesday:
                    Console.WriteLine(WeekDays.Wednesday);
                    break;
                case (int)WeekDays.Thursday:
                    Console.WriteLine(WeekDays.Thursday);
                    break;
                case (int)WeekDays.Friday:
                    Console.WriteLine(WeekDays.Friday);
                    break;
                case (int)WeekDays.Saturday:
                    Console.WriteLine(WeekDays.Saturday);
                    break;
                case (int)WeekDays.Sunday:
                    Console.WriteLine(WeekDays.Sunday);
                    break;
                default:
                    Console.WriteLine("Wrong input");
                    break;
            }




            switch (choice)
            {
                case 1:
                    Console.WriteLine("Moday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wenesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;

                case 7:
                    Console.WriteLine("Sunday");
                    break;
                case 8:
                    Console.WriteLine("SundayPromax");
                    break;
                default:
                    Console.WriteLine("Wrong input");
                    break;
            }

        }








        //public static void Test(PointStruct point)
        //{
        //    Console.WriteLine(point.X);
        //}
        //public static void Test(PointClass point)
        //{
        //    Console.WriteLine(point.X);
        //}
    }
}