namespace MergedInterval
{
    class Program
    {
        //Given an array of intervals[[start1, end1], [start2, end2], ...],
        //merge all overlapping intervals and return the resulting array.

        //Example:
        //Input: [[1,3], [2,6], [8,10], [15,18]]
        //Output: [[1,6], [8,10], [15,18]]

        static int[][] GetResult_01(int[][] input)
        {
            if (input == null || input.Length == 0) return new int[0][];
            List<List<int>> result = new List<List<int>>();

            var sortedInput = input.OrderBy(x => x.First()).ToList();
            // sort the array in order // nlogn

            int prevStart = sortedInput[0][0];
            int prevEnd = sortedInput[0][1];

            for (int index = 1; index < sortedInput.Count; index++)
            {
                int[] pair = sortedInput[index];

                if (pair[0] <= prevEnd) 
                {
                    prevEnd = Math.Max(prevEnd, pair[1]);
                }
                else 
                {
                    result.Add(new List<int> { prevStart, prevEnd });
                    prevStart = pair[0];
                    prevEnd = pair[1];
                }
            }

            result.Add(new List<int> { prevStart, prevEnd });

            int[][] resultArray = result.Select(inner => inner.ToArray()).ToArray();

            return resultArray;
        }
        static void Main(string[] args)
        {
            int[][] input = new int[][]
            {
                new int[] {1, 3},
                new int[] {8, 10},
                new int[] {2, 6},
                new int[] {15, 18}
            };
            int[][] output = GetResult_01(input);

            foreach(int[] x in output)
            {
                foreach( int y in x)
                {
                    Console.Write(y + " ");
                }
                Console.Write("next ");
            }
        }
    }
}