using DSA;

namespace DSA.test
{
    public class AlgorithmTesting
    {
        [Fact]
        public void LinearSearch_ValueIsFound()
        {
            int[] integerArray = [1, 2, 3, 4, 5];
            int value = 4;

            bool result = Algorithms.LinearSearch(integerArray, value);

            Assert.True(result);
        }

        [Fact]
        public void LinearSearch_ValueIsNotFound()
        {
            int[] integerArray = [1, 2, 3, 4, 5];
            int value = 6;

            bool result = Algorithms.LinearSearch(integerArray, value);

            Assert.False(result);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(9)]
        public void BinarySearch_ValueIsFound(int value)
        {
            int[] sortedIntegerArray = [1, 2, 3, 4, 5, 6, 7, 8, 9];

            bool result = Algorithms.BinarySearch(sortedIntegerArray, value);

            Assert.True(result);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(10)]
        public void BinarySearch_ValueIsNotFound(int value)
        {
            int[] sortedIntegerArray = [1, 2, 3, 4, 5, 6, 7, 8, 9];

            bool result = Algorithms.BinarySearch(sortedIntegerArray, value);

            Assert.False(result);
        }
    }
}