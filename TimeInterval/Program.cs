using System.Diagnostics;
using System.Xml.Linq;
namespace TimeInterval
{
    class TimeInterval
    {
        //You are given a list of meeting time intervals consisting of start and end times.
        //Determine if a person can attend all meetings.
        //In other words, determine if any two meetings in the list overlap.

        //Example Input:
        //[[0, 30], [5, 10], [15, 20]]
        //Expected Output: false
        //(because[0, 30] overlaps with[5, 10])

        //Another Input:
        //[[5, 8], [10, 15], [20, 25]]
        //Expected Output: true

        // [10, 15]  [14,20]
        public static bool GetTimeInterval(int[][] nums)
        {
            //Todo null checks
            for(int i = 0; i < nums.Length - 1; i++) // O(n^2)
            {
                for(int j = i + 1; j < nums.Length - 1; j++)
                {
                    int startA = nums[i][0]; // 10
                    int endA = nums[i][1]; // 15

                    int startB = nums[j][0]; // 14
                    int endB = nums[j][1]; //20

                    // overlapps
                    if (!(endA <= startB || endB <= startA))
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public static bool GetTimeIntervalOptimised(int[][] intervals)
        {
            // Step 1: Sort intervals by start time
            Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0])); // O(logN)

            // Step 2: Compare current start with previous end
            for (int i = 1; i < intervals.Length; i++) // O(n)
            {
                int endA = intervals[i][0];
                int startB = intervals[i - 1][1];

                if (endA < startB)
                {
                    return false; // overlap
                }
            }

            return true; //O(1)
        }


        static void Main(string[] args)
        {



        }
    }
}