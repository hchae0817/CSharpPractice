using System.Xml.Linq;
using FrequentElement;
using System.Linq;

namespace FrequentElement
{
    class Program
    {
        //Problem:
        //Given an integer array nums and an integer k,
        //return the k most frequent elements.
        //You must solve it in O(n log k) time complexity.

        //Example
        //[1,3,2,1,2,3] output [1,2,3]
        //Input: nums = [1, 1, 1, 2, 2, 3], k = 2
        //Output: [1,2]
        static int[] GetResult_V02(int[] nums, int k)
        {
            // time complexity O(nlogk)
            if (nums == null || nums.Length == 0) return Array.Empty<int>();

            Dictionary<int, int> map = new Dictionary<int, int>();
            foreach (int i in nums)
            {
                if (!map.ContainsKey(i)) map[i] = 0;
                map[i]++;
            }

            var pq = new PriorityQueue<int, int>(); // value, priority = freq

            foreach (var entry in map)
            {
                pq.Enqueue(entry.Key, entry.Value);
                if (pq.Count > k) pq.Dequeue(); // maintain k size
            }

            // Extract from heap
            var result = new List<int>();
            while (pq.Count > 0)
            {
                result.Add(pq.Dequeue());
            }

            return result.Reverse().ToArray();
        }

        static int[] GetResult(int[] nums, int k)
        {
            // time complexity O(n)
            if (nums == null || nums.Length == 0) return Array.Empty<int>();

            Dictionary<int, int> map = new Dictionary<int, int>();
            foreach ( int i in nums )
            {
                if (!map.ContainsKey(i)) map[i] = 0;
                map[i]++;
            }

            var result = map.OrderByDescending(x => x.Value).Take(k).Select(x => x.Key).ToArray();
            return result;
        }

        static void Main(string[] args)
        {
            var nums = new int[] { 1, 1, 1, 2, 2, 3 };
            var k = 2;
            var result = GetResult_V02(nums, k);
            foreach(var i in result)
            {
                Console.WriteLine(i);
            }
        }
    }
}
