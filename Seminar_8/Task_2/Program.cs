/*Задача 56: Задайте прямоугольный двумерный массив.
Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

Console.Write("Введи количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введи количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

int[,] matrix = new int[rows, columns];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().Next(0, 10);
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine();

int minSumElements = int.MaxValue,
    indexSumMinElements = 0;

for (int i = 0; i < rows; i++)
{
    int sumElements = 0;
    for (int j = 0; j < columns; j++)
        sumElements += matrix[i, j];
    if (sumElements < minSumElements)
    {
        minSumElements = sumElements;
        indexSumMinElements = i;
    }
}

Console.Write("Строка с минимальной суммой элементов: ");
for (int j = 0; j < rows; j++)
    Console.Write(matrix[indexSumMinElements, j] + " ");
