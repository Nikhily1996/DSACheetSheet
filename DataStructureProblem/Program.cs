using DataStructureProblem.Arrays_Part1;
using DataStructureProblem.Arrays_Part2;
using DataStructureProblem.Day_4;
using System;

namespace DataStructureProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            ISolvable problem = new LongestSubArrayWithZeroSum();
            problem.Solve();
        }
    }
}
