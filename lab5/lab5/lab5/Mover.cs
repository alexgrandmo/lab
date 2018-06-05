using System.Collections.Generic;
namespace ImprovedFivethLR
{
    class Mover
    {
        public List<int> InsertAndRearrange(List<int> array)
        {
            int numberShift = 1;
            int nextIndex = 0;
            for (int i = 0; i < array.Count - 1; ++i)
            {
                nextIndex += numberShift;
                nextIndex %= array.Count;
                int shift = array[nextIndex];
                array[nextIndex] = array[0];
                array[0] = shift;
            }
            for (int i = 0; i < array.Count; ++i)
            {
                if (array[i] % 2 == 0)
                {
                    array.Insert(++i, 0);
                }
            }
            return array;
        }
    }
}
