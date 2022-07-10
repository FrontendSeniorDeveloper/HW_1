/*Задайте массив заполненный случайными положительными трёхзначными числами.
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/
int[] array = new int[10];

int size = array.Length;
int numberОfEvenNumbers = 0;

for (int i = 0; i < size; i++)
{
    array[i] = new Random().Next(100, 1000);
    if (array[i] % 2 == 0)
    {
        numberОfEvenNumbers += 1;
    }
}

Console.WriteLine($"Исходный массив: {String.Join("; ", array)}");
Console.WriteLine($"Количество четных чисел в массиве = {numberОfEvenNumbers}");
