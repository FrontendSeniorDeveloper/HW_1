// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
             Random r = new Random();
            int size = 5;
            int[] arr = new int[size];

            for (int i = 0; i < size; i++)
            {
                 arr[i] = r.Next(0, 9);
                Console.Write(arr[i] + "");
            }

            if (arr[0] == arr[4] && arr[1] == arr[3])
            {
                Console.Write( " - Палиндром");
            }
            else
            {
                Console.Write(" - Не палиндром");
            }
        }
    }
}
