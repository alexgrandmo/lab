using System;
namespace lab9
{
    static class Sorting
    {
        static private int[] GettingPerimeterValue(int[,] array)
        {
            int arraySide = (int)Math.Sqrt(array.Length);
            int[] result = new int[(arraySide * 4 - 4)];
            int next = 0;
            for (int i = 0; i < arraySide; i++)
            {
                result[next++] = array[0, i];
            }
            for (int i = 1; i < arraySide - 1; i++)
            {
                result[next++] = array[i, arraySide - 1];
            }
            for (int i = arraySide - 1; i > 0; i--)
            {
                result[next++] = array[arraySide - 1, i];
            }
            for (int i = arraySide - 1; i > 0; i--)
            {
                result[next++] = array[i, 0];
            }
            return result;
        }
        static public int[,] SortPerimeterArray(int[,] array)
        {
            int[] sortedValue = GettingPerimeterValue(array);
            Array.Sort(sortedValue);
            int arraySide = (int)Math.Sqrt(array.Length);
            int next = 0;
            for (int i = 0; i < arraySide; i++)
            {
                array[0, i] = sortedValue[next++];
            }
            for (int i = 1; i < arraySide - 1; i++)
            {
                array[i, arraySide - 1] = sortedValue[next++];
            }
            for (int i = arraySide - 1; i > 0; i--)
            {
                array[arraySide - 1, i] = sortedValue[next++];
            }
            for (int i = arraySide - 1; i > 0; i--)
            {
                array[i, 0] = sortedValue[next++];
            }
            return array;
        }
    }
}
