// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает,
// что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int number = new Random().Next(10, 1000);

Console.WriteLine(number);
int third = number % 10;

if (number > 100 && number < 1000)
{
    Console.WriteLine(third);
}
else
{
    Console.WriteLine("Третьего числа нет");
}
