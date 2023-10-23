namespace DelegateAnonymousMethods
{
    //internal delegate bool CheckNumber(int num);
    //internal delegate void PrintText(string text);
    //internal delegate void PrintText<T>(T text);

    //internal delegate string Test(char a,int b,int c);


    internal class Program
    {
       
        static void Main(string[] args)
        {

            #region Action, Predicate some examples

            //List<string> names = new List<string> { "Leyla", "Adil", "Tofiq" };
            //Console.WriteLine(names.Find(x => x.ToLower().Contains("Ad".ToLower())));

            //names.ForEach(x=> Console.WriteLine(x));


            //names.RemoveAll(x => x.Length > 4); 
            #endregion


            #region Function, Action

            //Func<string> func = delegate ()
            //{
            //    return "salam";
            //};


            //Action<string> action = x => Console.WriteLine(x);

            //action += PrintLower;
            //action += PrintUpper;
            //action += PrintCapitalize;

            //action("sAlaM"); 
            #endregion



            //int[] ints = { 1, 2, 3, 4, 5, 12, 7, 14 };

            //int result = Sum(ints, CheckEven);

            //Console.WriteLine(result);


            //int result = Sum(ints, x => x > 3 && x < 10);

            //int result2 = Sum(ints, delegate(int num)
            //{
            //    return num > 3 && num < 10;
            //});



            //int result3 = Sum(ints, x => x % 7 == 0);

            //Console.WriteLine(result3);

            //int result = Sum(ints, CheckEven);
            //int result = Sum(ints, CheckOdd);
            //int result2 = Sum(ints, CheckDivideThree);


            //Console.WriteLine(result);
            //Console.WriteLine(result2);


            #region Anonymous methods
            //string word = "sAlAM";


            //PrintText<string> print = delegate (string w)
            //{
            //    Console.WriteLine(w[0]);
            //};

            //print += w => Console.WriteLine(w[0]);

            //PrintText<int> printNums = delegate (int num)
            //{
            //    Console.WriteLine(num);
            //};
            //print -= w => Console.WriteLine(w[0]);

            //print += PrintUpper;
            //print += PrintCapitalize;
            //print -= PrintCapitalize;

            //print(word); 
            #endregion

        }


        public static void PrintLower(string word)
        {
            Console.WriteLine(word.ToLower());
        }
        public static void PrintUpper(string word)
        {
            Console.WriteLine(word.ToUpper());
        }
        public static void PrintCapitalize(string name)
        {
            Console.WriteLine(char.ToUpper(name[0])+name.Substring(1).ToLower());
        }

        public static int Sum(int[] arr,Predicate<int> predicate )
        {
            int sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (predicate(arr[i]))
                {
                    sum += arr[i];
                }
            }
            return sum;
        }

        //public static int Sum(int[] arr,CheckNumber func)
        //{
        //    int sum = 0;

        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        if (func(arr[i]))
        //        {
        //            sum += arr[i];
        //        }
        //    }
        //    return sum;
        //}
        public static bool CheckEven(int num)
        {
            return num % 2 == 0;
        }
        public static bool CheckOdd(int num)
        {
            return num % 2 != 0;
        }
        public static bool CheckDivideThree(int num)
        {
            return num % 3 == 0;
        }

    }
}