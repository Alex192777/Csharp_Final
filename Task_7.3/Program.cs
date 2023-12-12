// Задача 3: Задайте произвольный массив. Выведете
// его элементы, начиная с конца. Использовать
// рекурсию, не использовать циклы.
// Пример:
// [1, 2, 5, 0, 10, 34] => 34 10 0 5 2 1 


using System;

class Program
{
    static void Main()
    {
        int[] array = GenerateArray(6); // Генерируем массив из 6 элементов
        Console.WriteLine("Исходный массив:");
        PrintArray(array); // Выводим исходный массив
        Console.WriteLine("Массив, выведенный рекурсивно с конца:");
        PrintReversedArray(array, array.Length - 1); // Выводим массив, используя рекурсию

        Console.ReadLine();
    }

    // Генератор случайных чисел для заполнения массива
    static int[] GenerateArray(int length)
    {
        int[] array = new int[length];
        Random rand = new Random();
        for (int i = 0; i < length; i++)
        {
            array[i] = rand.Next(1, 100); // Генерируем случайное число от 1 до 100
        }
        return array;
    }

    // Вывод массива на экран
    static void PrintArray(int[] array)
    {
        foreach (int item in array)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }

    // Рекурсивный метод для вывода массива с конца
    static void PrintReversedArray(int[] array, int index)
    {
        if (index >= 0)
        {
            Console.Write(array[index] + " ");
            PrintReversedArray(array, index - 1); // Рекурсивный вызов метода для следующего элемента
        }
    }
}

