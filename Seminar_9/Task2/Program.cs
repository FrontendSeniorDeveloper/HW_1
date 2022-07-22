/*Задача 66: 
Задайте значения M и N. 
Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

Console.WriteLine("Введите число M:");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число N:");
int secondNumber = Convert.ToInt32(Console.ReadLine());

int PrintSumm (int firstNumber, int secondNumber)
{
    if(firstNumber == secondNumber) return firstNumber;
    return (firstNumber + PrintSumm(firstNumber + 1,secondNumber));
}
Console.Write("Cумма чисел в промежутке от М до N = ");
Console.WriteLine(PrintSumm(firstNumber,secondNumber));