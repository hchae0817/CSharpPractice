using SortedInputArray;

namespace SortedArray.Test
{
    public class SumTest
    {
        [Theory]
        [InlineData(new int[] { 1, 2, 3 }, 3, new int[] { 1, 2 })]
        [InlineData(new int[] { 2, 7, 11, 15 }, 9, new int[] { 1, 2 })]
        [InlineData(new int[] { -10, -3, 1, 2, 4, 6 }, 1, new int[] { 2, 5 })]
        [InlineData(new int[] { 2, 7, 11, 15 }, 9, new int[] { 1, 2 })]
        [InlineData(new int[] { -5, -2, 0, 3, 6 }, 1, new int[] { 1, 5 })]
        [InlineData(new int[] { 1, 2 }, 3, new int[] { 1, 2 })]
        public void TestSum(int[] nums, int target, int[] expected)
        {
            int[] result = Sum.GetResult(nums, target);
            Assert.Equal(expected, result);
        }
    }
}