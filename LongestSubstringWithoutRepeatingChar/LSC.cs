using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestSubstringWithoutRepeatingChar
{
    public static class LSC
    {
        // input = "abcdabcbb"
        // input = "qtydabcdbb"

        public static int LengthOfLongestSubstring(string s)
        {
            if (string.IsNullOrEmpty(s)) return 0;

            var lastSeen = new Dictionary<char, int>();
            int left = 0; // substring start pointer
            int maxLen = 0;

           for(var right = 0; right < s.Length; right++)
           {
                var c = s[right];
                if (lastSeen.TryGetValue(c, out int duplicatedIndex) && left <= duplicatedIndex)
                {
                    left = duplicatedIndex + 1;
                }
                lastSeen[c] = right;
                maxLen = Math.Max(maxLen, right - left + 1);
           }

            return maxLen;
        }


    }
}
