using System;
using CSharpPractice.LongestIncreasingSubsequence;

namespace LongestIncreasingSubsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 0, 1, 0, 3, 2, 3 };
            int result = LIS.LengthOfLIS(nums);

            Console.WriteLine("Length of LIS: " + result);
            Console.ReadKey();
        } 
    }
}
