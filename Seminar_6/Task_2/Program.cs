// Задача 43: Напишите программу,
// которая найдёт точку пересечения двух прямых,
// заданных уравнениями
// y = k1 * x + b1,
// y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите первое чиcло : ");
double firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе чиcло : ");
double secondNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье чиcло : ");
double thirdNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите четвертое чиcло : ");
double fourthNumber = Convert.ToInt32(Console.ReadLine());
// y = y ->
// k1*x+b1 = k2*x+b2 ->
// k1*x-k2*x = b2-b1 ->
// (k1-k2)*x = b2-b1 -> 
// x = (b2-b1) / (k1-k2)
double firstСoordinate = (thirdNumber - firstNumber) / (secondNumber - fourthNumber);
double secondCoordinate = secondNumber * firstСoordinate + firstNumber;

Console.WriteLine($"Точка пересечения координат: ({firstСoordinate}; {secondCoordinate})");
