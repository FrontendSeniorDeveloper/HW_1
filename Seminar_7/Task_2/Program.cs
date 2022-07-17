/*
Задача 50. Напишите программу,
которая на вход принимает позиции элемента в двумерном массиве,
и возвращает значение этого элемента или же указание,
что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/

Console.Write("Введи количество строчек: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введи количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

Console.Write("Введи число: ");
int startNumber = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[rows, columns];

bool checkingElement = false;

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().Next(1, 11);
    }
}

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (startNumber == matrix[i, j])
        {
            Console.WriteLine($"Значение элемента {startNumber} = matrix[{i},{j}]");
            checkingElement = true;
        }
    }
}

if (checkingElement == false)
{
    Console.WriteLine($"Такого злемента  нет");
}
