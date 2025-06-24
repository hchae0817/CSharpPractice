using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Xml.Linq;
using Array;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace Array
{
    class Array
    {
        //Two Sum(Easy)
        // Given an array of integers nums and an integer target,
        // return the indices of the two numbers such that they add up to target.
        // You may assume that each input has exactly one solution, and you may not use the same element twice.
        // You can return the answer in any order.

        // Input
        // nums: an array of integers

        // target: an integer

        // Output
        // An integer array of length 2, containing the indices of the two numbers whose sum equals target.


        //Example 1:
        //Input:  nums = [2, 7, 11, 15], target = 9
        //Output: [0, 1]
        //Explanation: nums[0] + nums[1] == 9

        //Example 2:
        //Input:  nums = [3, 2, 4], target = 6
        //Output: [1, 2]
        //Explanation: nums[1] + nums[2] == 6

        public static int[] TwoSum(int[] nums, int target)
        {
            // value, index
            Dictionary<int, int> ints = new Dictionary<int, int>();

            for(int i = 0; i < nums.Length; i++)
            {

                var leftover = target - nums[i]; // 7
                if (ints.ContainsKey(leftover))
                {
                    return new[] { i, ints[leftover] };
                }
                ints.Add(nums[i], i);
            }
            return new[] { 0 };
        }

        static void Main(string[] args)
        {


            Console.WriteLine(string.Join(",", TwoSum(new[] { 2, 7, 11, 15 }, 9)));    // [0,1]
            Console.WriteLine(string.Join(",", TwoSum(new[] { 3, 2, 4 }, 6)));    // [1,2]
            Console.WriteLine(string.Join(",", TwoSum(new[] { 3, 3 }, 6)));    // [0,1]

        }
    }
}