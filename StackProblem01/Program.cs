using System;
using System.Diagnostics;
using System.Runtime.Intrinsics.X86;
using StackProblem01;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace StackProblem01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Given an array of integers, return an array result
            // where result[i] is the number of days
            // you would have to wait after the i-th day
            // to get a warmer temperature.
            // If there is no future day for which this is possible,
            // put 0 instead.

            // start time : 15:30
            // Example:
            // Input: [73, 74, 75, 71, 69, 72, 76, 73]
            // Output: [1, 1, 4, 2, 1, 1, 0, 0]

            int[] nums = new int[] { 73, 74, 75, 71, 69, 72, 76, 73 };
            int target = 9;

            int[] result = Days.GetResult(nums);
            // output: [1,2]
            foreach (int i in result)
            {
                Console.WriteLine(i);
            }
        }
    }
}
