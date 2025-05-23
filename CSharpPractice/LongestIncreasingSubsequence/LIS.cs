using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice.LongestIncreasingSubsequence
{
    public static class LIS
    {
        public static int LengthOfLIS(int[] nums)
        {
            int result = 0;
            if (nums.Length == 0) return result;
            // 10, 9, 2, 5, 3, 7, 101, 18

            // make the array distinct
            HashSet<int> hashNums = new HashSet<int>(nums);
            var uniqueNums = hashNums.ToArray();
            // we need to see if the current one < next one
            // if that satisfies add both [i] + [i+1] to new array [2,5]
            // if you have array, compare latest one array[array.length] < next one

            if (uniqueNums.Length == 1) return uniqueNums.Length;

            var resultList = new List<int>();
            for (int i = 0; i < uniqueNums.Length - 1; i++)
            {
                var length = resultList.Count;
                if (length > 0)
                {
                    if (resultList[length - 1] < uniqueNums[i + 1])
                    {
                        resultList.Add(uniqueNums[i + 1]);
                        continue;
                    }
                }
                else if (uniqueNums[i] < uniqueNums[i + 1])
                {
                    resultList.Add(uniqueNums[i]);
                    resultList.Add(uniqueNums[i + 1]);
                }
                
            }
            return resultList.Count;
        }
    }
}
