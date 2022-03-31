using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureProblem.Arrays_Part1
{
    class SortColorsProblem : ISolvable
    {
        public void Solve()
        {
            int[] nums = new int[] { 2, 0, 2, 1, 1, 0 };
            SortColorsOptimizeDutchFlag(nums);
            PrintArray(nums);
            nums = new int[] { 2, 0, 2, 1, 1, 0 };
            SortColorsBruteForce(nums);
            PrintArray(nums);
            nums = new int[] { 2, 0, 2, 1, 1, 0 };
            SortColorsOptimize(nums);
            PrintArray(nums);
        }
        private void SortColorsBruteForce(int[] nums) {
            for (int i = 0; i < nums.Length; i++) {
                for (int j = 0 ; j < nums.Length - i-1; j++) {
                    if (nums[j] > nums[j + 1]) {
                        swap(j, j + 1, nums);
                    }
                }
            }
        }
        private void SortColorsOptimize(int[] nums)
        {
            int PartitionEnd = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0) {
                    swap(PartitionEnd, i, nums);
                    PartitionEnd++;
                }
            }
            for (int i = PartitionEnd; i < nums.Length; i++)
            {
                if (nums[i] == 1)
                {
                    swap(PartitionEnd, i, nums);
                    PartitionEnd++;
                }
            }
        }
        private void SortColorsOptimizeDutchFlag(int[] nums)
        {
            int low = 0;
            int mid = 0;
            int high = nums.Length - 1;
            while (mid <= high)
            {
                if (nums[mid] == 0)
                {
                    swap(mid, low, nums);
                    mid++;
                    low++;
                }
                else
                {
                    if (nums[mid] == 1)
                    {
                        mid++;
                    }
                    else
                    {
                        swap(mid, high, nums);
                        high--;
                    }
                }
            }
        }
        private void swap(int a, int b, int[] nums)
        {
            int temp = nums[a];
            nums[a] = nums[b];
            nums[b] = temp;
        }
        private void PrintArray(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write(nums[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
