/*
Задача 54: Задайте двумерный массив.
Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:

1 4 7 2  ||  1 2 4 7
5 9 2 3  ||  2 3 5 9
8 4 2 4  ||  2 4 4 8
В итоге получается вот такой массив:
*/

Console.Write("Введите количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите левую границу рандома: ");
int minRandom = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите правую границу рандома: ");
int maxRandom = Convert.ToInt32(Console.ReadLine());

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return matrix;
}

void PrintArray(int[,] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            Console.Write(inputArray[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

int[,] array = GetArray(rows, columns, minRandom, maxRandom);
PrintArray(array);

void OrderedArray(int[,] matrix)
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for (int k = 0; k < columns - 1; k++)
            {
                if (array[i, k] > array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
}
OrderedArray(array);
Console.WriteLine("Упорядоченный массив:");
PrintArray(array);
