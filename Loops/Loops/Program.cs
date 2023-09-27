int num = 10;

//string answer = "";
//do
//{
//    Console.WriteLine("dovr devam etsin?");
//    answer = Console.ReadLine();

//} while (answer == "yes");

//Console.WriteLine("dovr devam etsin?");
//answer = Console.ReadLine();
//while (answer == "yes")
//{
//    Console.WriteLine("dovr devam etsin?");
//  answer = Console.ReadLine();
//}


//string choice = "no";
//while (choice=="no")
//{
//    Console.WriteLine("Dovr bitsin?");
//    choice=Console.ReadLine();
//}
//int i = 0;
//while (i<10)
//{

//}

//int a = 0;
//while (a<10)
//{

//}


//for (int i = 1; i < 50; i++)
//{
//    if (i == 20)
//    {
//        Console.WriteLine($"buna beraberdir {i}");
//        break;
//    }

//    Console.WriteLine(i);
//}

//for (; ;)
//{
//    Console.WriteLine("Hello world");
//}


//for (int i = 20; i >0; i-=2)
//{
//    Console.WriteLine(i);
//}


//Task 1

//for (int i = 1; i < 90; i++)
//{
//    if (i%2==0)
//    {
//        Console.WriteLine(i);
//    }
//}

//Task 2


//int sum = 0;
//for (int i = 1; i < 100; i++)
//{

//    sum += i;

//}

//Console.WriteLine(sum);


//Task 3


int a = 20;
int b = 20;

int less = 0;
int greater = 0;
if (a < b)
{
    less = a;
    greater = b;
}
else
{
    less = b;
    greater = a;
}


for (int i = less; i < greater; i++)
{
    if (i % 3 == 0)
    {
        Console.WriteLine(i);
    }
}

