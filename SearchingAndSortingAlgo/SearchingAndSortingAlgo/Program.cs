
#region Linear Search
//int[] numbers = { 3, 8, 1, 5, 4, 22, 11 };

//int search = 11;

////big O(n)
//for (int i = 0; i < numbers.Length; i++)
//{
//    if (numbers[i]==search)
//    {
//        Console.WriteLine(i);
//        break;
//    }
//} 
#endregion

#region Binary Search

//Big O(log n)
//int search = 34;
//int[] numbers = { 1, 4, 6, 11, 34, 56, 79, 81, 102 };

//int step = 0;

//int low = 0;
//int high = numbers.Length - 1;
//int mid = (low + high) / 2;

//while (numbers[mid]!=search)
//{
//    step++;
//    mid = (low + high) / 2;
//    if (numbers[mid]>search)
//    {
//        high = mid - 1;
//    }
//    else
//    {
//        low= mid + 1;
//    }


//}

//Console.WriteLine(numbers[mid]);

//Console.WriteLine("Addimlar "+step); 
#endregion

#region Buble Sort


int[] numbers = { 4, 2, 5, 3, -1, 22, 15, 65, -2 };

int step = 0;
int temp = 0;
for (int i = 0; i < numbers.Length; i++)
{
    for (int j = 0; j < numbers.Length - 1 - i; j++)
    {
        step++;
        if (numbers[j] > numbers[j + 1])
        {
            //1ci
            temp = numbers[j];
            numbers[j] = numbers[j + 1];
            numbers[j + 1] = temp;

            //2ci
            //numbers[j]+=numbers[j+1];
            //numbers[j + 1] = numbers[j] - numbers[j+1];
            //numbers[j] = numbers[j] - numbers[j+1];
        }
    }
}


for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine(numbers[i]);
}

Console.WriteLine("Addimlar " + step); 
#endregion

