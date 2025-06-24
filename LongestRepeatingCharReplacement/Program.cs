using System.Security.Cryptography;
using System.Threading.Channels;

namespace LongestRepeatingCharReplacement
{
    class Program
    {

        // Problem:
        // Given a string s and an integer k, you can choose any character of the string and change it to any other uppercase English character.
        // You can perform this operation at most k times.
        // Return the length of the longest substring containing the same letter you can get after performing the above operations.

        //Input
        //s: string of uppercase English letters(A–Z)

        //k: maximum number of replacements allowed

        //Output
        //The length of the longest substring achievable with at most k character changes so that all characters in that substring are identical.

        //Example 1:
        //Input: s = "ABAB", k = 2
        //Output: 4
        //Explanation: Replace the two ‘A’s with ‘B’s or vice versa.Result: "BBBB" or "AAAA".

        //Example 2:
        //Input: s = "AABABBA", k = 1
        //Output: 4
        //Explanation: Replace the one ‘A’ in the middle with ‘B’ → "AABBBBA". The longest repeating substring is "BBBB".

        // {a : 3} // only count when current A is k next to it
        // {b : 3}
        public static int CharacterReplacement_og(string s, int k)
        {
            Dictionary<char, int> map = new Dictionary<char, int>();
            for(int i = 0; i < s.Length; i++)
            {
                if (!map.ContainsKey(s[i]))
                {
                    map[s[i]] = 1;
                }

                // only add when current A is k next to it
                var currentKey = s[i];
                // last added Index for same key
                map[s[i]]++;
            }

            return 0;
        }

        // AABABBA
        public static int CharacterReplacement(string s, int k)
        {
            Dictionary<char, int> counts = new Dictionary<char, int>();
            int left = 0, maxCount = 0, answer = 0;

            for (int right = 0; right < s.Length; right++)
            {
                char c = s[right]; // a
                counts[c] = counts.GetValueOrDefault(c, 0) + 1;
                maxCount = Math.Max(maxCount, counts[c]);

                // if we need more than k replacements, shrink window
                if ((right - left + 1) - maxCount > k)
                {
                    counts[s[left]]--;
                    left++;
                }

                answer = Math.Max(answer, right - left + 1);
            }

            return answer;
        }


        static void Main(string[] args)
        {
            Console.WriteLine(CharacterReplacement("AABABBA", 1));
   

        }
    }
}

