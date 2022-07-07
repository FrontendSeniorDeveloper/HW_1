/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
 и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

// Решение 1
// double numberA = Convert.ToInt32(Console.ReadLine());
// double numberB = Convert.ToInt32(Console.ReadLine());
// double degreeОfNumber = Math.Pow(numberA, numberB);
// Console.WriteLine($"Возведенное число A в степень B : " + degreeОfNumber);


Console.Write("Введите число: ");
double numberA = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите степень: ");
int numberB = Convert.ToInt32(Console.ReadLine());

double degreeOfNumber = 1;

for (int i = 0; i < numberB; i++)
{
    degreeOfNumber = degreeOfNumber*numberA;
}
Console.WriteLine($"число:{numberA} в степени:{numberB} = {degreeOfNumber}");
