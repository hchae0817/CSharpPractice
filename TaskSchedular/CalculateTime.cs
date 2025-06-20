using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskSchedular
{
    public class CalculateTime
    {
        public static int GetResult(string[] tasks, int unit)
        {
            //(e.g., ["A", "A", "A", "B", "B", "B"]) 

            // when getting first element, need to see un matched letter
            // A B
            // A B A // but this case A cant come before 2 unit
            // + dont have other other letter. put idle

            //(e.g., ["A", "A", "B", "B", "C", "C"]) 
            // (i = 0) A B 
            // (i = 1) A B C // C comes as  i - 1 + unit  > i + 1

            //(minTime) = (maxFreq - 1) * (n + 1) + numOfMaxFreqTasks
            //string A, int maxFreq
            Dictionary<string, int> freq = new Dictionary<string, int>();
           
            for(var i = 0; i <= tasks.Length - 1; i++)
            {
                var task = tasks[i];
                if (!freq.ContainsKey(task))
                {
                    freq[task] = 0;
                }
                freq[task]++;
            }

            int maxFreq = freq.Values.Max();
            int numMaxFreq = freq.Values.Count(v => v == maxFreq);
            var result = (maxFreq - 1) * (unit + 1) + numMaxFreq;
            return result;
        }

    }
}
