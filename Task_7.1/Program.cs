// Задача 1: Задайте значения M и N. Напишите
// программу, которая выведет все натуральные числа
// в промежутке от M до N. Использовать рекурсию, не
// использовать циклы.
// Пример:
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите число M: ");
        int M = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите число N: ");
        int N = Convert.ToInt32(Console.ReadLine());

        PrintNumbersInRange(M, N);
    }

    static void PrintNumbersInRange(int start, int end)
    {
        if (start <= end)
        {
            Console.Write(start);

            if (start < end)
            {
                Console.Write(", ");
            }

            PrintNumbersInRange(start + 1, end);
        }
    }
}
