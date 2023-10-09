using System.Text;
using System.Text.RegularExpressions;

namespace StringVsStringBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region String Methods
            //string word = "aksjdlkajsd!050 624 32 52 1";
            //word=word.Trim();
            //word.ToLower();
            //word.ToUpper();
            //word.Contains("BiR");
            //word.StartsWith("Sab");
            //word.IndexOf('a');
            //word.Substring(20,4);
            //word.Replace(" ","");
            //string[] array=word.Split('2');
            //char[] arr= word.ToCharArray();

            //String.Concat("Sabir", " ", "Guliyev")
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}
            //string[] words = { "Salam", "Gencler", "Necesiniz" };
            //String.Join(" ", words); 
            #endregion

            #region StringBuilder

            //  //Mutable Immutable
            //  //string name = "Sabir";
            //  //name += "Guliyev";

            //  //name += "Mehti";
            //string name=Console.ReadLine().Trim();

            // Capitalize(name);
            //  Console.WriteLine(name); 
            #endregion

            #region Array Methods
            //string word=Console.ReadLine();

            //word = word.Trim().ToLower().Replace(' ','-');

            //int[] nums = new int[4] { 1, 2, 3, 4 };

            //int[] numbers = { 9, 2, 6, 4, 1, 0, 7 };
            //int[] numbers2 = new int[numbers.Length];
            //Array.Copy(numbers, numbers2, 3);

            //numbers.Append(23).ToArray();
            //numbers.Min();
            //numbers.Max();
            //numbers.Sum();
            //numbers.Average();
            //numbers.CopyTo(numbers2, 0);

            //Array.Sort(numbers);
            //Array.Reverse(numbers);
            //Array.ForEach(numbers, num => Console.WriteLine(num));


            //numbers2[0] = 1000;



            //foreach (int num in numbers)
            //{
            //    Console.WriteLine(num);
            //} 
            #endregion

            #region MyRegion
            //string name = "Sa1";

            //foreach (char element in name)
            //{
            //    if (Char.IsDigit(element))
            //    {
            //        Console.WriteLine(element);
            //    }

            //} 
            #endregion

            #region Regex
            //string word = Console.ReadLine().ToLower();

            //Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");

            //if (regex.IsMatch(word))
            //{
            //    Console.WriteLine("Duz daxil edilib");
            //}
            //else
            //{
            //    Console.WriteLine("Yanlish deyer bir daha gonderin");
            //} 
            #endregion



        }


        public static string Capitalize(string str)
        {
            StringBuilder sb=new StringBuilder();
            sb.Append(Char.ToUpper(str[0]));

            for (int i = 1; i < str.Length; i++)
            {
                sb.Append(Char.ToLower(str[i]));
            }

            return sb.ToString();
        }

    
    }
  
}