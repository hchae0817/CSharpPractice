using System;
using LongestSubstringWithoutRepeatingChar;

namespace LongestSubstringWithoutRepeatingChar
{
    class Program
    {
        static void Main(string[] args)
        {
            // Given a string s,
            // find the length of the longest substring without repeating characters.
            string s = "pwwkew"; 
            int result = LSC.LengthOfLongestSubstring(s); //"abc"

            Console.WriteLine("Length of LIS: " + result);
            Console.ReadKey();
        }
    }
}
