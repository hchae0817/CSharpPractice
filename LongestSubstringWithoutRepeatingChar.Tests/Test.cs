

namespace LongestSubstringWithoutRepeatingChar.Tests
{
    public class Test
    {
        [Theory]
        [InlineData("", 0)]
        [InlineData("a", 1)]
        [InlineData("abcabcbb", 3)] // "abc"
        [InlineData("bbbbb", 1)]    // "b"
        [InlineData("pwwkew", 3)]   // "wke"
        [InlineData("abba", 2)]     // "ab" or "ba"
        [InlineData("abcddefgh", 5)] // "defgh"
        [InlineData(" ", 1)]
        [InlineData("dvdf", 3)]     // "vdf"
        [InlineData("anviaj", 5)]   // "nviaj"
        public void TestLengthOfLongestSubstring(string input, int expected)
        {
            int result = LSC.LengthOfLongestSubstring(input);
            Assert.Equal(expected, result);
        }
    }
}