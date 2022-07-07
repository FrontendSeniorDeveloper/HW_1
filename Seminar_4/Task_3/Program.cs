/*Задача 29: Напишите программу,
которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/
// Method 1:

// int [] array = {1,2,3,4,5,6,7,8};
// Console.WriteLine($"[{String.Join(", ", array)}]");

//Method 2:

int [] array = GetArray(8);
int [] GetArray(int length)
{
    int[] resultArray = new int[length];
    for(int i = 0; i < length; i++)
    {
        resultArray[i] = new Random().Next(100);
    }
    return resultArray;
}

Console.WriteLine($"[{String.Join(", ", array)}]");
