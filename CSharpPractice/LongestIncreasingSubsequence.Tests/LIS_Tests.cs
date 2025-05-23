using System.Collections.Generic;
using Xunit;
using CSharpPractice.LongestIncreasingSubsequence;

namespace LongestIncreasingSubsequence.Tests;

public class LIS_Tests
{
    [Theory]
    [InlineData(new int[] { 10, 9, 2, 5, 3, 7, 101, 18 }, 4)]
    [InlineData(new int[] { 0, 1, 0, 3, 2, 3 }, 4)]
    [InlineData(new int[] { 7, 7, 7, 7 }, 1)]
    [InlineData(new int[] { }, 0)]
    public void LengthOfLIS_ReturnsExpectedResult(int[] input, int expected)
    {
        var result = LIS.LengthOfLIS(input);
        Assert.Equal(expected, result);
    }
}