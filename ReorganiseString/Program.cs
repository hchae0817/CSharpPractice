namespace ReorganiseString
{
    class Program
    {
        static string GetResult(string input)
        {
            var map = new Dictionary<char, int>();
            for(int i = 0; i <= input.Length - 1; i++)
            {
                char s = input[i];
                if (!map.ContainsKey(s))
                {
                    map[s] = 0;
                }
                map[s]++;
            }
            // {a,2} {b,1}

            var pq = new PriorityQueue<char, int>();

            foreach(var pair in map)
            {
                pq.Enqueue(pair.Key, -pair.Value); // to get the max out
            }

            string result = "";
            char prevChar = '\0';
            int prevFreq = 0;
            while (pq.Count > 0)
            {
                char curr = pq.Dequeue();
                int freq = map[curr];

                result += curr;

                if (prevFreq > 0)
                    pq.Enqueue(prevChar, -prevFreq);

                map[curr] = freq - 1;
                prevChar = curr;
                prevFreq = freq - 1;
            }

            return result.Length == input.Length ? result : "";
        }

        static void Main(string[] args)
        {
            // Given a string s, rearrange the characters so that no two adjacent characters are the same.
            // Return any valid rearrangement. If not possible, return an empty string "".

            //  Input: s = "aab"
            //  Output: "aba"

            //  Input: s = "aaab"
            //  Output: ""

            string s = "aab";

            string result = GetResult(s);
     
            Console.WriteLine(result);
            Console.WriteLine(GetResult("aab"));    // aba
            Console.WriteLine(GetResult("aaab"));   // ""
            Console.WriteLine(GetResult("aaabbc")); // possible

        }
    }
}
