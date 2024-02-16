/*
Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
*/
int akkerman(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0)
    {
        return akkerman(m: m - 1, n: 1);
    }
    else return akkerman(m: m - 1, n: akkerman(m, n: n - 1));
}
Console.Write($"Функция Аккермана равно {akkerman(m, n)}");

Console.Write("Введите значение M: ");
int m = Convert.ToInt32(Console.ReadLine()!);
Console.Write("Введите значение N: ");
int n = Convert.ToInt32(Console.ReadLine()!);