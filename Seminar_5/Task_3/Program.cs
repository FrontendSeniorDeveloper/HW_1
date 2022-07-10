/*Задача 38: Задайте массив вещественных чисел.
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/
double[] array = new double[7];

double size = array.Length;
double maximumArrayElement = 0;
double minimumArrayElement = 100;
double differenceMaximumAndMinimum = 0;

for (int i = 0; i < size; i++)
{
    array[i] = new Random().NextDouble();
    if (array[i] < minimumArrayElement)
    {
        minimumArrayElement = array[i];
    }
    if (array[i] > maximumArrayElement)
    {
        maximumArrayElement = array[i];
    }

    differenceMaximumAndMinimum = maximumArrayElement - minimumArrayElement;
}

Console.WriteLine($"Массив вещественных чисел: {String.Join("; ", array)}");
Console.WriteLine(
    $"Разница между максимальным и минимальным элементом массива = {differenceMaximumAndMinimum}"
);
