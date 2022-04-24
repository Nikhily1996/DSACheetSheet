using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureProblem.Arrays_Part2
{
    class MergeOverlappingSubIntervals : ISolvable
    {
        public void Solve()
        {
            int[][] nums = CreateMatrix();


            int[][] data = Merge(nums);
            PrintMatrix(data);
        }

        public int[][] CreateMatrix()
        {
            int[][] nums = new int[4][];
            nums[0] = new int[2] { 1, 3 };
            nums[1] = new int[2] { 2, 6 };
            nums[2] = new int[2] { 8, 10 };
            nums[3] = new int[2] { 15, 18 };
            return nums;
        }
        private void PrintMatrix(int[][] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < nums[i].Length; j++)
                {
                    Console.Write(nums[i][j] + " ");
                }
            }
            Console.WriteLine();
            Console.WriteLine("---END---");
        }
        public int[][] Merge(int[][] intervals)
        {
            bool[] range = new bool[10001];
            List<int[]> rangeValues = new List<int[]>();
            for (int i = 0; i < intervals.Length; i++)
            {
                markRange(intervals[i][0], intervals[i][1], range);
            }
            for (int i = 1; i < 10001; i++)
            {
                if (range[i])
                {
                    int start = i;
                    while (range[i]) i++;
                    rangeValues.Add(new int[2] { start, i - 1 });
                }
            }
            return rangeValues.ToArray();

        }
        public void markRange(int start, int end, bool[] range)
        {
            for (int i = start; i <= end; i++)
            {
                range[i] = true;
            }
        }
    }
}
