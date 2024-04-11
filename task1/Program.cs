//  Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.
class Program
{
    static void Main(string[] args)
    {
        // Задаем значения M и N
        int M = 5;
        int N = 10;

        PrintNumbers(M, N);
    }

    static void PrintNumbers(int m, int n)
    {
        if (m > n)
        {
            return;
        }
        Console.WriteLine(m);
        PrintNumbers(m + 1, n);
    }
}
