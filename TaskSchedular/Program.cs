using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Intrinsics.X86;
using System.Threading.Tasks;
using TaskSchedular;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TaskSchedular
{
    class Program
    {
        static void Main(string[] args)
        {

            //You are given a list of tasks represented by capital letters
            //(e.g., ["A", "A", "A", "B", "B", "B"]) and
            //a non - negative integer n representing the cooldown interval
            //between two identical tasks.

            //Your goal is to determine the minimum number of time units
            //the CPU will take to finish all tasks, where:

            //Each task takes 1 unit of time to execute.

            //The same task cannot be executed again within n units of time
            //(must wait n intervals before repeating).

            //Different tasks can fill the gap, and
            //If no other task is available to run,
            //the CPU must be idle.

            string[] tasks = new string[] { "A", "A", "A", "B", "B", "B" };
            int unit = 2;

            int result = CalculateTime.GetResult(tasks, unit);
            Console.WriteLine(result);
        }
    }
}
