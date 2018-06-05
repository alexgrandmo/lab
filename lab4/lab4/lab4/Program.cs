using System;
namespace ImprovedFourthLR
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Поменять местами элементы на 3 и 5 позициях.\n");
            Console.WriteLine("Исходный массив: ");
            int number = 15;
            int[] array = new int[number];
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(0, 100);
                Console.Write(array[i] + " ");
            }
            Rearrangement Transfer = new Rearrangement();
            int[] result = Transfer.Rearrange(array);
            Console.WriteLine();
            Console.WriteLine("Pезультат:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
