/*Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
массив размером 3 x 3
12(0,0) 22(0,0)
45(1,0) 53(1,0)
*/

// int rows = 3;
// int columns = 3;
Console.Write("Введи количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введи количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

Console.WriteLine("Начальная матрица:");
int[,] matrix = new int[rows, columns];

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        matrix[i, j] = new Random().Next(10);
        Console.Write(matrix[i, j] + "\t");
    }
    Console.WriteLine();
}

Console.WriteLine();

Console.WriteLine("Матрица с добавлением индексов:");

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write($"{matrix[i, j]}({i},{j});  ");
    }
    Console.WriteLine();
}
