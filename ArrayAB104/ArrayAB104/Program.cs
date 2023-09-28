

//string name = "Nigar";


//Console.WriteLine(name[3]);

//string[] students = { "Adil", "Aqil", "Zulfiyya", "Murad", name ,"Sabir"};

//int step = 0;
//for (int i = 0; i < students.Length; i++)
//{
//    Console.WriteLine(students[i]);
//    step++;
//}
//Console.WriteLine(step);
//Console.WriteLine(students[0]);
//Console.WriteLine(students[1]+" " + students[2]);

//string[] students2 = new string[4];
//students2[0] = "Salam";
//students2[1] = students[0];


//for (int i = 0; i < students2.Length; i++)
//{
//    Console.WriteLine(students2[i]);
//}
//Console.WriteLine(students[10]);
//for (int i = 0; i < 10; i++)
//{
//    Console.WriteLine(students[i]);
//}

//Console.WriteLine(students[students.Length-1]);
//for (int i = 0; i < students.Length; i++)
//{
//    if (i<3)
//    {
//        students[i] += " AB104";
//    }

//    Console.WriteLine(students[i]);
//}

//students[0] = "Yusif";

//Console.WriteLine(students[0]);

//int[] numbers = { 1, 5, 6, 11, 7 };

//int[,] multi =
//{
//    {1,2 },

//    {4,5},

//    {5,6}

//};
//Console.WriteLine(multi[2,0]);




//int age = 200;

//if (age>17)
//{
//    Console.WriteLine("Yetkin yashina catib");
//}





//int num = 49;

//int step = 0;
//for (int i = 2; i*i <= num; i++)
//{
//    step++;
//    if (num%i==0)
//    {
//        Console.WriteLine("Murrekebdir");
//        break;

//    }

//}
//Console.WriteLine(step);
//int num = 20;

//for (int i = 0; i < num; i++)
//{
//    Console.WriteLine("1-ci dongu");
//    for (int j = 0; j < num; j++)
//    {
//        Console.WriteLine("2-ci dongu");
//        step++;
//    }
//}


//Console.WriteLine(step);

string name = "sadil";
bool result = false;
char test = ' ';
for (int i = 0; i < name.Length; i++)
{
    if (name[i] == 'a' || name[i]=='A')
    {
        test = name[i];
        result = true;
        break;
    }
}

if (result)
{
    Console.WriteLine("a herfi movcuddur");
}
else
{
    Console.WriteLine("Movcud deyil");
}


