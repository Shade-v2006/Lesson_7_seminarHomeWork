﻿/*
    Задача 3: Задайте произвольный массив. Выведете его элементы, 
    начиная с конца. Использовать рекурсию, не использовать циклы.
*/
void Print(int[] array, int i = 0)
{    
    if (i < array.Length)
    {
        Print(array, i + 1);
        Console.Write(" " + array[i]);
    }

}

int[] array = { 3, 4, 5, 6, 7, 8, 9 };
Print(array);
