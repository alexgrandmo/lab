using System;
namespace lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Поменять местами столбцы с максимальным нечетным элементом и минимальным четным. \n\n");
            Console.Write(" Ввeдите количество строк массива: ");
            int sizeString = Convert.ToInt32(Console.ReadLine());
            Console.Write(" Ввeдите количество столбцов массива: ");
            int sizeColumn = Convert.ToInt32(Console.ReadLine());
            int[][] array = new int[sizeString][];
            Random random = new Random();
            for (int n = 0; n < sizeString; n++)
            {
                array[n] = new int[sizeColumn];

                for (int m = 0; m < sizeColumn; m++)
                {
                    array[n][m] = random.Next(30) + 10;
                }
            }
            foreach (int[] input in array)
            {
                Console.WriteLine();
                foreach (int off in input)
                {
                    Console.Write(' ');
                    Console.Write(off);
                }
            }
            Permutation Transfer = new Permutation();
            int[][] result = Transfer.Rearrange(array, sizeString, sizeColumn);
            Console.WriteLine();
            foreach (int[] input in array)
            {
                Console.WriteLine();
                foreach (int off in input)
                {
                    Console.Write(' ');
                    Console.Write(off);
                }
            }
            Console.ReadKey();
        }
    }
}
