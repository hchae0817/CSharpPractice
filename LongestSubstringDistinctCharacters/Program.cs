using System;
using System.Diagnostics;

namespace LongestSubstringDistinctCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            // Time taken: 30

            // Given a string s,
            // return the length of the longest substring
            // that contains at most two distinct characters.

            //Input: s = "ccaabbb"
            //Output: 5  // "aabbb" has length 5 with two distinct characters: a and b

            string s = "eceba";
            //Output: 3  // "ece" has length 3 with two distinct characters: e and c

            int result = DistinctCharacters.GetResult(s);
            Console.WriteLine(result);

            // Time 
            // O(n)
            
        }
    }
}
