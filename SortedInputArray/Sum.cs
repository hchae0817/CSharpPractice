using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedInputArray
{
    public static class Sum
    {
        //int[] nums = new int[] { 2, 7, 11, 15 };
        //int target = 9;
        // only one set exist

        //Input: nums = [-10, -3, 1, 2, 4, 6], target = 1  
        //Output: [3, 6]
        public static int[] GetResult(int[] nums, int target)
        {
            if(nums == null || nums.Length == 0) { return Array.Empty<int>(); }

            int left = 0;
            int right = nums.Length - 1;

            while(right > left)
            {
                int sum = nums[right] + nums[left];

                // target not matched
                if(sum != target)
                {
                    // larger than target
                    if(sum > target)
                    {
                        right--; // use smaller value
                    }
                    else
                    {
                        left++; // use bigger value
                    }
                }
                else if (sum == target)
                {
                    return new int[] { left + 1, right + 1 };
                }

            }
            return Array.Empty<int>();
        }
    }
}
