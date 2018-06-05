using System;
using System.Collections.Generic;
namespace lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" Удалить столбец, содержащий  минимальное отрицательное.  \n\n");
            List<List<int>> array = new List<List<int>>();
            array.Add(new List<int>() { -8, 2, 3, 0 });
            array.Add(new List<int>() { 5, -5, 6, 1 });
            array.Add(new List<int>() { 7, -6, -9, -12 });
            array.Add(new List<int>() { -22, 8, -9, 11 });
            Console.Write("Исходный массив: \n");
            for (int i = 0; i < array.Count; i++)
            {
                for (int j = 0; j < array[i].Count; j++)
                {
                    Console.Write(array[i][j] + "  ");
                }
                Console.WriteLine();
            }
            Removeer transfer = new Removeer();
            List<List<int>> result = transfer.Delete(array);
            Console.Write("\nРезультат: \n");
            for (int i = 0; i < array.Count; i++)
            {
                for (int j = 0; j < array[i].Count; j++)
                {
                    Console.Write(array[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
