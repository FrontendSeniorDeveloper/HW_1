Console.WriteLine("Введите первое число: ");
int number_1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число число: ");
int number_2 = Convert.ToInt32(Console.ReadLine());

if (number_1 > number_2)
{
    Console.WriteLine("Максимальное число: " + number_1);
    Console.WriteLine("Минимальное число : " + number_2);
}

else 
{
    Console.WriteLine("Максимальное число: " + number_2);
    Console.WriteLine("Минимальное число: " + number_1);
}
 