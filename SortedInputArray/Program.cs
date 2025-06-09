using System;
using System.Diagnostics;
using System.Runtime.Intrinsics.X86;
using SortedInputArray;

namespace SortedInputArray
{
    class Program
    {
        static void Main(string[] args)
        {
            // Given a sorted array of integers nums and an integer target,
            // return the 1-based indices of the two numbers
            // such that they add up to target.

            // You may assume that each input would have exactly one solution,
            // and you may not use the same element twice.

            int[] nums = new int[] { 2, 7, 11, 15 };
            int target = 9;

            int[] result = Sum.GetResult(nums, target); 
            // output: [1,2]
            foreach(int i in result)
            {
                Console.WriteLine(i);
            }
        }
    }
}
