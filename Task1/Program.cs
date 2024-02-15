/*    Задача 1: Задайте значения M и N. Напишите программу, 
    которая выведет все натуральные числа в промежутке 
    от M до N. Использовать рекурсию, не использовать циклы.
*/

void recursia(int m, int n)
{
    if (m <= n)
    {
        System.Console.Write(value: $"{m} ");
        recursia(m: m + 1, n);
    }
}
System.Console.WriteLine(value: $"Введите первое число M:");
int m = Convert.ToInt32(value: Console.ReadLine()!);
System.Console.WriteLine(value: $"Введите второе число N больше первого:");
int n = Convert.ToInt32(value: Console.ReadLine()!);
recursia(m, n);