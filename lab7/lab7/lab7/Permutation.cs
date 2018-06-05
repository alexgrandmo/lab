namespace lab7
{
    class Permutation
    {
        public int[][] Rearrange(int[][] array, int sizeString, int sizeColumn)
        {
            int min = array[0][0];
            int max = array[0][0];
            int minIndex = 0;
            int maxIndex = 0;
            for (int n = 0; n < sizeString; n++)
            {
                for (int m = 0; m < sizeColumn; m++)
                {
                    if (array[n][m] % 2 == 0)
                    {
                        if (min > array[n][m])
                        {
                            min = array[n][m];
                            minIndex = m;
                        }
                    }
                    if (array[n][m] % 2 == 1)
                    {
                        if (max < array[n][m])
                        {
                            max = array[n][m];
                            maxIndex = m;
                        }
                    }
                }
            }
            if (maxIndex == minIndex)
            {
                for (int n = 0; n < sizeString; n++)
                {
                    array[n][maxIndex] = 0;
                }
            }
            else
            {
                for (int n = 0; n < sizeString; n++)
                {
                    int temp = array[n][maxIndex];
                    array[n][maxIndex] = array[n][minIndex];
                    array[n][minIndex] = temp;
                }
            }
            return array;
        }
    }
}
