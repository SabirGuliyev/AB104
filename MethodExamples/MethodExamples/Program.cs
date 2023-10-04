namespace MethodExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Salam");
            //GetDiscount(90,10);
            //int product = 70;
            //int discount = 10;

            //int value= GetDiscount(product, discount);

            // product -= value;
            // Console.WriteLine(product);

            //------------------------------------------

            //Console.WriteLine(GetFullname()+" AB104");

            //------------------------------------------



            //int[] numbers = { 1, 5, 23, 2, 4 };

            //int[] ints = { 1, 2, 4 };

            //GetEven(numbers);
            //GetEven(ints);


            //----------------------------------------



            //GetFullname("Sabir", "Guliyev");
            //GetFullname("Sabir");

            //----------------------------------------

            //string[] arr = { "Salam", "Gencler", "Hello", "World" };
            //GetSentence(arr);

            //GetSentence("Salam","bu","Paramsla","Ishleyir");
            //GetSentence("Salam","2","Paramsla");


            //Sum(1,1, 6, 7, 34, 56);

            //-------------------------------------------------









            //Sum(5, 6);
            //Sum(5, 6,10);
            //Sum(4.3,6.7);
            //Sum("Salam");
            //Sum(10, 4.6);
            //Sum(4.5, 10);






            int num = 5;
            Cem(ref num);

            Console.WriteLine(num);

            //Check(0);
            
        }
        public static void Cem(ref int num)
        {
            num += 10;
        }



        public static void Check(int num)
        {

            if (num==0)
            {
                Console.WriteLine("neytral");
                return;
            }

            if (num%2==0)
            {
                Console.WriteLine("cut");
            }
            else
            {
                Console.WriteLine("Tek");
            }
                
        }






       
        //public static void Sum(int num,int num2)
        //{
        //    Console.WriteLine("1ci method ishe dushdu");
        //}
        //public static void Sum(int num, int num2, int num3 = 3)
        //{
        //    Console.WriteLine("2ci method ishe dushdu");
        //}
        //public static void Sum(params int[] numbers)
        //{
        //    Console.WriteLine("3ci method ishe dushdu");

        //}













        //public static void Sum(double num, double num2)
        //{
        //    Console.WriteLine("#cci ishe dushdu");
        //}
        //public static void Sum(string word)
        //{
        //    Console.WriteLine("4ci method ishe dushdu");
        //}

        //public static void Sum(double num, int num2)
        //{
        //    Console.WriteLine("sira 1ci method ishe dushdu");

        //}

        //public static void Sum(int num2, double num)
        //{
        //    Console.WriteLine("sira 2ci method ishe dushdu");

        //}













        //public static void Sum(params int[] numbers)
        //{
        //    int sum = 0;
        //    for (int i = 0; i < numbers.Length; i++)
        //    {
        //        sum+=numbers[i];
        //    }

        //    Console.WriteLine(sum);
        //}


        //public static void GetSentence(string[] arr)
        //{
        //    string sentence = "";
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        sentence += arr[i];
        //        sentence+=" ";
        //    }
        //    Console.WriteLine(sentence);
        //}







        //public static void GetFullname(string name,string surname="XXXX")
        //{

        //    Console.WriteLine(name+" "+surname);
        //}

















        //public static void GetEven(int[] arr)
        //{
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        if (CheckEvenOrOdd(arr[i]))
        //        {
        //            Console.WriteLine(arr[i]);
        //        }
        //    }
        //}

        //public static bool CheckEvenOrOdd(int num)
        //{
        //    if (num%2==0)
        //    {
        //        return true;
        //    }
        //    else 
        //    {
        //        return false;
        //    }
        //}










        //public static string GetFullname()
        //{
        //    Console.WriteLine("Adinizi daxil edin");
        //    string name=Console.ReadLine();

        //    Console.WriteLine("Soyadinizi daxil edin");
        //    string surname=Console.ReadLine();

        //   return name+" "+surname;

        //}







        //public static int GetDiscount(int price,int percent)
        //{
        //    int result=price*percent/100;

        //    return result;
        //    //Console.WriteLine(result);
        //}

    }


}