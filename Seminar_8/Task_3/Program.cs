/* Задача 58: Задайте две матрицы.
Напишите программу, которая будет находить произведение двух матриц.
Например, заданы 2 массива:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
и
1 5 8 5
4 9 4 2
7 2 2 6
2 3 4 7
Их произведение будет равно следующему массиву:
1 20 56 10
20 81 8 6
56 8 4 24
10 6 24 49
*/

Console.WriteLine("Введи количество строк первой матрицы: ");
int firstRows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введи количество столбцов первой матрицы: ");
int firstColumns = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введи количество строк второй матрицы: ");
int secondRows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введи количество столбцов второй матрицы: ");
int secondColumns = Convert.ToInt32(Console.ReadLine());

int[,] firstMatrix = new int[firstRows, firstColumns];

Console.WriteLine("Первая матрица:");

for (int i = 0; i < firstMatrix.GetLength(0); i++)
{
    for (int j = 0; j < firstMatrix.GetLength(1); j++)
    {
        firstMatrix[i, j] = new Random().Next(11);
        Console.Write(firstMatrix[i, j] + "\t");
    }
    Console.WriteLine();
}

Console.WriteLine();

int[,] secondMatrix = new int[secondRows, secondColumns];

Console.WriteLine("Вторая матрица:");

for (int i = 0; i < secondMatrix.GetLength(0); i++)
{
    for (int j = 0; j < secondMatrix.GetLength(1); j++)
    {
        secondMatrix[i, j] = new Random().Next(11);
        Console.Write(secondMatrix[i, j] + "\t");
    }
    Console.WriteLine();
}

Console.WriteLine();

int[,] compositionMatrix = new int[firstRows, firstColumns];

Console.WriteLine("Произведение первой и второй матрицы:");

for (int i = 0; i < compositionMatrix.GetLength(0); i++)
{
    for (int j = 0; j < compositionMatrix.GetLength(1); j++)
    {
        int composition = 0;
        composition = firstMatrix[i, j] * secondMatrix[i, j];
        compositionMatrix[i, j] = composition;
        Console.Write(compositionMatrix[i, j] + "\t");
    }
    Console.WriteLine();
}
