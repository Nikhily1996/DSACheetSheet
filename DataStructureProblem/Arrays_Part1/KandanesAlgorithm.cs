using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureProblem.Arrays_Part1
{
    class KandanesAlgorithm : ISolvable
    {
        public void Solve()
        {
            Console.WriteLine(maxSubArrayBruteForce(new int[] { -2, 1, -3, 4, -1, 2,1, -5, 4 }));
            Console.WriteLine(maxSubArrayKandanesAlgo(new int[] { -2, 1, -3, 4, -1, 2, 1,-5, 4 }));
        }
        private int maxSubArrayBruteForce(int[] nums)
        {
            int maxSum = 0;
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum = 0;
                for (int j = i; j < nums.Length; j++)
                {
                    sum += nums[j];
                    if (sum > maxSum)
                    {
                        maxSum = sum;
                    }

                }
            }
            return maxSum;
        }
        private int maxSubArrayKandanesAlgo(int[] nums)
        {
            int maxSum = Int32.MinValue;
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                sum = Math.Max(sum, nums[i]);
                maxSum = Math.Max(maxSum, sum);
            }
            return maxSum;
        }
    }
}
