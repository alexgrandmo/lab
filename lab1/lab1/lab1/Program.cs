using System;
using System.Numerics;
namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Привет! Задание таково: Определить количество повторений каждой из цифр 0,1,2,...,9 в числе N^N, где N <= 1000. \n");
                Console.WriteLine("А теперь введи число: \n");
                var number = int.Parse(Console.ReadLine());
                Console.WriteLine("N = " + number);

                if (number < 1 || number > 1000)
                {
                    Console.WriteLine("N должно быть в диапозоне от 1 до 1000");
                    return;
                }

                Counters counters = new Counters();
                BigInteger powedNumber = counters.Pow(number);
                Console.WriteLine("N^N = " + powedNumber);
                int[] counterNumber = counters.CountDigits(powedNumber);
                for (var i = 0; i < counterNumber.Length; i++)
                {
                    Console.WriteLine("Цифра " + i + " повторяется " + counterNumber[i] + " раз");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
                Console.ReadLine();
            }
            Console.ReadLine();
        }
    }
}









