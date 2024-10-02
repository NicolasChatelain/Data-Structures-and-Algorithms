namespace DSA
{
    public class Algorithms
    {
        // Time complexity = O(N)
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

        // Assume low is inclusive, high is exclusive. Time complexity = O(log N)
        public static bool BinarySearch(int[] sortedIntegerArray, int value)
        {
            int low = 0;
            int high = sortedIntegerArray.Length;

            do
            {
                int midpoint = (int)Math.Floor((double)(low + (high - low) / 2));
                var current = sortedIntegerArray[midpoint];

                if (current == value)
                {
                    return true;
                }
                else if (current < value)
                {
                    low = midpoint + 1;
                }
                else
                {
                    high = midpoint;
                }

            } while (low < high);

            return false;

        }


        public static void BubbleSort(int[] integerArray)
        {
            for (int i = 0; i < integerArray.Length; i++)
            {
                for (int j = 0; j < integerArray.Length - 1 - i; j++)
                {
                    if (integerArray[j] > integerArray[j + 1])
                    {
                        (integerArray[j], integerArray[j + 1]) = (integerArray[j + 1], integerArray[j]);
                    }
                }
            }
        }
    }
}
