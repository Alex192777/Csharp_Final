// Задача 2: Напишите программу вычисления функции
// Аккермана с помощью рекурсии. Даны два
// неотрицательных числа m и n. 
// Пример:
// m = 2, n = 3 -> A(m,n) = 29 (неправильный ответ)

// A  |    n=0    1     2     3     4     5     6     7     8     9    10
// -----+-----------------------------------------------------------------
//  m=0 |   1     2     3     4     5     6     7     8     9    10    11
//    1 |   2     3     4     5     6     7     8     9    10    11    12
//    2 |   3     5     7     9    11    13    15    17    19    21    23
//    3 |   5    13    29    61   125   253   509  1021  2045  4093  8189



class Program
{
   static void Main()
{
    Console.Write("Введите целое неотрицательное число m: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите целое неотрицательное число n: ");
    int n = Convert.ToInt32(Console.ReadLine());

    int result = AckermannFunction(m, n);
    Console.WriteLine("A({0},{1}) = {2}", m, n, result);
}

    static int AckermannFunction(int m, int n)
    {
        if (m == 0)
        {
            return n + 1;
        }
        else if (m > 0 && n == 0)
        {
            return AckermannFunction(m - 1, 1);
        }
        else
        {
            return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
        }
    }
}