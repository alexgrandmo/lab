using System;
using System.Collections.Generic;
namespace lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Удалить элементы массива кратные разнице его первого и последнего элементов(элементы и разницу рассматривать по модулю).\n\nИсходный массив: ");
            List<int> array = new List<int> { 5, 3, 4, 6, 2, -2, -3, -8 };
            for (int i = 0; i < array.Count; i++)
            {
                Console.Write("{0} ", array[i]);
            }
            Removal operation = new Removal();
            List<int> result = operation.Delete(array);
            Console.Write("\n\nИзмененный массив: ");
            foreach (int element in array)
            {
                Console.Write("{0} ", element);
            }
            Console.ReadKey();
        }
    }
}
