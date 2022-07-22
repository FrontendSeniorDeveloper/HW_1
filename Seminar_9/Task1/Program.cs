/*Задача 64:
Задайте значения M и N.
Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5. -> ""1, 2, 3, 4, 5""
M = 4; N = 8. -> ""4, 6, 7, 8""
*/
Console.WriteLine("Введите число M:");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число N:");
int secondNumber = Convert.ToInt32(Console.ReadLine());

string PrintNumbers(int firstNumber, int secondNumber)
{
    if (firstNumber == secondNumber) return firstNumber.ToString();

    return (firstNumber + ", " + PrintNumbers(firstNumber + 1, secondNumber));
}

Console.Write("Результат : ");
Console.WriteLine(PrintNumbers(firstNumber, secondNumber));
