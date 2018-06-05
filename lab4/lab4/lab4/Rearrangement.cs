namespace ImprovedFourthLR
{
    class Rearrangement
{
    public int[] Rearrange(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            int variable = array[2];
            array[2] = array[4];
            array[4] = variable;
        }
        return array;
    }
}
}
