//Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
class Program
{
    static void Main(string[] args)
    {
    
        int m = 2;
        int n = 2;

    
        int result = Ackermann(m, n);
        Console.WriteLine($"Ackermann({m}, {n}) = {result}");
    }

    static int Ackermann(int m, int n)
    {
        if (m == 0)
        {
            return n + 1;
        }
        else if (m > 0 && n == 0)
        {
            return Ackermann(m - 1, 1);
        }
        else
        {
            return Ackermann(m - 1, Ackermann(m, n - 1));
        }
    }
}