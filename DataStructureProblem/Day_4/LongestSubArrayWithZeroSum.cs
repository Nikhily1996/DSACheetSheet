using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureProblem.Day_4
{
    class LongestSubArrayWithZeroSum : ISolvable
    {
        public void Solve()
        {
            FindLongestSubArraySum(new int[] { 9, -3, 3, -1, 6, -5 });
        }
        private void FindLongestSubArraySum(int[] nums) {
            int LongestSubArray = 0;
            int Sum = 0;
            Dictionary<int, int> PrefixSumValues = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++) {
                Sum += nums[i];
                if (Sum == 0)
                {//since this is the longest array so far starting from 0 index
                    LongestSubArray = i + 1;
                }
                else {
                    if (PrefixSumValues.ContainsKey(Sum))
                    { //sum is already there so there is subarray with 0 sum
                        // we are not updating index beacuse we want maximum length
                        LongestSubArray = Math.Max(LongestSubArray, (i + 1) - PrefixSumValues[Sum]);
                    }
                    else {
                        PrefixSumValues.Add(Sum,i+1);
                    }
                }
            }
            Console.WriteLine("LongestSubArray sum is "+LongestSubArray);
        }
    }
}
