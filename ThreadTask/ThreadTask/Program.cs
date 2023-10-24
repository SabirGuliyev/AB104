namespace ThreadTask
{
    internal class Program
    {
        public static int Count=0;

        public static object BlockObject=new object();
        public static object BlockObject2=new object();
        static void Main(string[] args)
        {
            //Thread thread = new Thread(Loop);
            //Thread thread2 = new Thread(Loop2);

            //thread.Start();
            //thread2.Start();

            //Console.WriteLine("jaskdjhsakjdhsakjdhaskjdhsakjdhsakjhdkjsahdkjashdkjad");

            //thread.Join();
            //thread2.Join();

            //Console.WriteLine(Count);
            //Console.WriteLine("butun kodlar ishleyib bitdi");


           var task= Task.WhenAll(MakeLoop(), MakeLoop2());
            task.Wait();
            Console.WriteLine(task.IsCompletedSuccessfully);



        }

        public static async Task MakeLoop()
        {
            await Task.Run(() =>
             {
                 for (int i = 0; i < 100000; i++)
                 {
                     Console.WriteLine($"1ci dovr ishe dushur {i}");

                 }
             });

        }
        public static async Task MakeLoop2()
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < 100000; i++)
                {
                    Console.WriteLine($"2ci dovr {i}");

                }
            });

        }


        //public static void Loop()
        //{
        //    for (int i = 0; i < 100000; i++)
        //    {
        //        Console.WriteLine($"1ci dovr ishe dushur {i}");

        //        //lock (BlockObject2)
        //        //{
        //        //    lock (BlockObject)
        //        //    {
        //        //        Count++;
        //        //    }

        //        //}


        //    }
        //}
        //public static void Loop2()
        //{
        //    for (int i = 0; i < 100000; i++)
        //    {
        //        //Console.WriteLine($"2ci dovr {i}");

        //        lock (BlockObject)
        //        {
        //            lock (BlockObject2)
        //            {
        //                Count--;
        //            }
        //        }


        //    }
        //}
    }
}