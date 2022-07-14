/*Задача 41: Пользователь вводит с клавиатуры M чисел.
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

Console.Write($"Введите количество чисел: ");
int startNumber = Convert.ToInt32(Console.ReadLine());
int[] array = new int[startNumber];
int size = array.Length;
int resultPositive = 0;
int index = 0;

while (index < size)
{
    Console.Write($"Введите {index + 1} число: ");
    array[index] = Convert.ToInt32(Console.ReadLine());
    index++;
}

Console.WriteLine($"[{String.Join("; ", array)}]");

for (int i = 0; i < size; i++)

    if (array[i] > 0)
    {
        resultPositive += 1;
    }

Console.WriteLine($"Количество чисел больше нуля = {resultPositive}");
