//Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

class Program
{
    static void Main(string[] args)
    {
        // Задаем произвольный массив
        int[] array = {1, 2, 3, 4, 5};

        // Выводим элементы массива, начиная с конца
        PrintArrayInReverse(array, array.Length - 1);
    }

    static void PrintArrayInReverse(int[] array, int index)
    {
        if (index < 0)
        {
            return;
        }
        Console.WriteLine(array[index]);
        PrintArrayInReverse(array, index - 1);
    }
}
