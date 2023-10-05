namespace RefOutAB104
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region TryParse
            //Console.WriteLine("Yashinizi daxil edin:");
            //int num = int.Parse(Console.ReadLine());



            //string str=Console.ReadLine();
            //int num;
            //bool result=  int.TryParse(str, out num);

            //if (result)
            //{
            //    Console.WriteLine("sizin yashiniz "+num);
            //}
            //else
            //{
            //    Console.WriteLine("Yanlish deyer gonderildi");
            //} 
            #endregion


            #region Reference and Calu types example
            //Console.WriteLine(a);

            //int[] arr = { 1, 2, 3 };
            //int[] arr2 = arr;


            //arr2[0] = 200;

            //Console.WriteLine(arr[0]);



            //Console.WriteLine(a==b);


            //Console.WriteLine(arr == arr2); 
            #endregion


            //ref and out
            #region Ref example
            //int a = 5;

            //ChangeValue(ref a);

            //Console.WriteLine(a);

            //int[] arr = { 1, 2, 3, 4, 5 };

            //ResetArray(ref arr);

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //} 
            #endregion


            #region Out example
            //int a=10;
            //ChangeValue(ref a);

            //Console.WriteLine(a); 
            #endregion


            #region Array Resize
            //int[] numbers = { 1, 2, 3 };

            //Array.Resize(ref numbers, numbers.Length + 1);
            //numbers[numbers.Length - 1] = 56;

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}


            //ArrayResize(ref numbers,89);

            //ArrayResize(ref numbers, 900);
            //ArrayResize(ref numbers, 123);


            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //} 
            #endregion

        }

        //public static void ArrayResize(ref int[] arr,int num)
        //{
        //    int[] copy = new int[arr.Length + 1];

        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        copy[i] = arr[i];
        //    }

        //    copy[copy.Length - 1] = num;

        //    arr = copy;
        //}

        #region Ref in Value types example
        //public static void ChangeValue(ref int num)
        //{

        //    num += 10;
        //}

        #endregion


        #region ResetArray ref example

        //public static void ResetArray(ref int[] nums)
        //{
        //    nums = new int[nums.Length];

        //    //for (int i = 0; i < nums.Length; i++)
        //    //{
        //    //    Console.WriteLine(nums[i]);
        //    //}
        //} 
        #endregion


      
    }
}