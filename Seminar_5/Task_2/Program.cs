/*Задача 36: Задайте одномерный массив, заполненный случайными числами.
 Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

int[] array = { -4, -6, 89, 6 };

int size = array.Length;
int sumOfElements = 0;
for (int i = 1; i < size; i++)
{
    sumOfElements += array[i++];
}
Console.WriteLine($"Cумма элементов,стоящих на нечётных позициях в массиве = {sumOfElements}");
