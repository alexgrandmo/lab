using System.Numerics;
namespace lab1
{
    class Counters
    {
        public BigInteger Pow(int number)
        {
            BigInteger result = 1;
            for (int i = 0; i < number; i++)
            {
                result *= number;
            }

            return result;
        }

        public int[] CountDigits(BigInteger number)
        {
            var counterNumber = new int[10];
            while (number != 0)
            {
                var index = (int)(number % 10);
                counterNumber[index]++;
                number /= 10;
            }
            return counterNumber;
        }
    }
}
