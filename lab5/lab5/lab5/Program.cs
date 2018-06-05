using System;
using System.Collections.Generic;
namespace ImprovedFivethLR
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> array = new List<int> { 12, 2, 5, 4, 11, 6, 7, 8, 133, 544, 10 };
            Console.Write("Здравствуй! Вот задание: Дан массив размера N. Вставить ноль после каждого четного элемента и осуществить циклический сдвиг элементов массива вправо на одну позицию. \n\n");
            Console.Write("Исходный массив:\n");
            Console.WriteLine(string.Join(" ", array));
            Console.Write("Измененный массив:\n");
            Mover Number = new Mover();
            List<int> result = Number.InsertAndRearrange(array);
            Console.WriteLine();
            foreach (int element in array)
            {
                Console.Write(element + " ");
            }
            Console.ReadKey();
        }
    }
}
