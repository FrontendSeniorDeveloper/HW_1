/*Задача 68:
Напишите программу вычисления функции Аккермана с помощью рекурсии.
Даны два неотрицательных числа m и n.

m = 3, n = 2 -> A(m,n) = 29
*/

Console.WriteLine("Введите число m:");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число n:");
int n = Convert.ToInt32(Console.ReadLine());

/// A(m,n) = n+1 -> m = 0; A(m-1,1) -> n = 0 , m > 0; A(m-1,A(m,n-1)) -> m > 0, n > 0 -> end

int FunctionAkkerman(int m, int n)
{
    if (m == 0)
        return n + 1;
    else if (m > 0 && n == 0)
        return FunctionAkkerman(m - 1, 1);
    else
        return FunctionAkkerman(m - 1, FunctionAkkerman(m, n - 1));
}

Console.Write("Функция Аккермана = " + FunctionAkkerman(m, n));
