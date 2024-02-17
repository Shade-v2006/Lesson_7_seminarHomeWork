/*
    Задача 3: Задайте произвольный массив. Выведете его элементы, 
    начиная с конца. Использовать рекурсию, не использовать циклы.
*/
void printBackArray(int[] array, int i = 0)
{
    if (i==array.Length)
    System.Console.WriteLine("\nПеревернутый массив:");
    if (i < array.Length)
    {
        Console.Write(" " + array[i]);
        printBackArray(array, i: i + 1);
        Console.Write(" " + array[i]);
    }
}

int[] array = { 23, 22, 33, 45, 57, 68, 74, 8, 9 };
System.Console.WriteLine("Заданный массив:");
printBackArray(array);
