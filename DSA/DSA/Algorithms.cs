namespace DSA
{
    public class Algorithms
    {
        public static bool LinearSearch(int[] integerArray, int value)
        {
            for (int i = 0; i < integerArray.Length; i++)
            {
                if (integerArray[i] == value)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
