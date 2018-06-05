using System;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Здравствуй! Задание таково: Дана строка, состоящая из русских слов,разделенных пробелами.Вывести строку,содержащую эти же слова, но расположенные в обратном порядке. \n\n");
            Console.Write("Введи строку: ");
            string str = Console.ReadLine();
            ReverseString Reverser = new ReverseString();
            string reversedstr = Reverser.Reverse(str);
            Console.WriteLine("Посмотри результат: {0}", reversedstr);
            Console.ReadKey(true);
        }
    }
}
