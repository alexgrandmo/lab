using System.Collections.Generic;
using System;
namespace lab6
{
    class Removal
    {
        public List<int> Delete(List<int> array)
        {
            int multiple = Math.Abs(Math.Abs(array[0]) - Math.Abs(array[array.Count - 1]));
            for (int j = 0; j < array.Count; j++)
                if (array[j] % multiple == 0)
                {
                    array.RemoveAt(j);
                    j--;
                }
            return array;
        }
    }
}
