using System;
namespace lab9
{
    class Program
    {
        static void Main()
        {
            Console.Write("Отсортировать элементы по периметру матрицы по возрастанию.\n\n");
            Console.Write("Введите размер матрицы:");
            string stringSize = Console.ReadLine();
            int size = Convert.ToInt32(stringSize);
            Random rand = new Random();
            int[,] array = new int[size, size];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rand.Next(-100, 100);
                }
            }
            Console.WriteLine("Матрица\n");
            int arraySide = (int)Math.Sqrt(array.Length);
            for (int i = 0; i < arraySide; i++)
            {
                for (int j = 0; j < arraySide; j++)
                {
                    Console.Write("{0}\t", array[i, j]);
                }
                Console.Write("\n");
            }
            Console.WriteLine("\nНовая отсортированная матрица: \n");
            Sorting.SortPerimeterArray(array);
            for (int i = 0; i < arraySide; i++)
            {
                for (int j = 0; j < arraySide; j++)
                {
                    Console.Write("{0}\t", array[i, j]);
                }
                Console.Write("\n");
            }
            Console.ReadKey();
        }
    }
}
