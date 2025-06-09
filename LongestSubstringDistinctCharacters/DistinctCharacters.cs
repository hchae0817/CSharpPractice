using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestSubstringDistinctCharacters
{
    public static class DistinctCharacters
    {
        //string s = "eceba";
        //Input: s = "ccaabbb"
        //Output: 3  // "ece" has length 3 with two distinct characters: e and c

        public static int GetResult(string s)
        {
            if(s == null || s == "") return 0;

 
            int left = 0;
            int result = 0;
            Dictionary<char, int> freq = new Dictionary<char, int>();

            for (int right = 0; right < s.Length; right++)
            {
                var rightElement = s[right];
                freq[rightElement] = freq.GetValueOrDefault(rightElement) + 1;


                while (freq.Count > 2)
                {
                    var leftElement = s[left];

                    freq[leftElement] = freq[leftElement] - 1;

                    if (freq[leftElement] == 0)
                    {
                        freq.Remove(leftElement);
                    }
                    left++;
                }
                result = Math.Max(result, right - left + 1);

            }

            return result;
        }
    }
}
