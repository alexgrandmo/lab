using System;
namespace ImprovedThirdLR
{
    class Repeat
    {
        public void Iteration()
        {
            int totalQuantity = 0, maxRepetition = 0, value = 0;
            int[] mass = new[] { 1, 2, 2, 7, 2, 7, 2, 8, 7, 8, 2, 2, 37, 11, 1 };
            foreach (int i in mass)
            {
                foreach (int j in mass)
                    if (i == j)
                    {
                        totalQuantity += 1;
                    }
                if (maxRepetition < totalQuantity)
                {
                    maxRepetition = totalQuantity;
                    value = i;
                }
                totalQuantity = 0;
            }
            Console.WriteLine("Частое число: {0}    Количество повторений: {1}", value, maxRepetition);
        }
    }
}
