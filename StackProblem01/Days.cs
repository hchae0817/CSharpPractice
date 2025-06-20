using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackProblem01
{
    public class Days
    {
        public static int[] GetResult(int[] nums)
        {
            // Example:
            // Input: [73, 74, 75, 71, 69, 72, 76, 73]
            // Output: [1, 1, 4, 2, 1, 1, 0, 0]

            // store the output to stack
            // loop input array
            // 73 74  ( i < i + 1)
            // 74 75 // calculate how many times we have to add to stack
            // 75, 71 69 72 76 

            int n = nums.Length;
            int[] result = new int[n];
            Stack<int> stack = new Stack<int>(); // store indices
            // stack: index of temp which still hasnt found warm temp
            for (int i = 0; i < n; i++)
            {
                // found warm
                while (stack.Count > 0 && nums[stack.Peek()] <= nums[i])
                {
                    int prevIndex = stack.Pop(); //0
                    result[prevIndex] = i - prevIndex;
                }
                stack.Push(i);

            }

            return result;
        }

    }
}
