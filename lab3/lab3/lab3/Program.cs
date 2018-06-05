using System;
namespace ImprovedThirdLR
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Привет! Задание таково: Дан целочисленный массив размера N.Определить максимальное количество его одинаковых элементов. \n\n");
            Repeat Max = new Repeat();
            Max.Iteration();
            Console.ReadKey(true);
        }
    }
}
