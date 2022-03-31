using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureProblem.Arrays_Part1
{
    class BestTimeBuyAndSellStock : ISolvable
    {
        public void Solve()
        {
            Console.WriteLine(MaxProfitBruteForce(new int[] { 7, 1, 5, 3, 6, 4 }));
            Console.WriteLine(MaxProfitOptimize(new int[] { 7, 1, 5, 3, 6, 4 }));
        }
        private int MaxProfitBruteForce(int[] prices)
        {
            int maxprofit = 0;
            for (int i = 0; i < prices.Length - 1; i++)
            {
                for (int j = i + 1; j < prices.Length; j++)
                {
                    int profit = prices[j] - prices[i];
                    if (profit > maxprofit)
                        maxprofit = profit;
                }
            }
            return maxprofit;
        }
        private int MaxProfitOptimize(int[] prices)
        {
            int leftStart = prices[0];
            int maxProfit = 0;
            for (int i = 0; i < prices.Length; i++)
            {
                if (prices[i] < leftStart)
                {
                    leftStart = prices[i];
                }
                else
                {
                    if (maxProfit < (prices[i] - leftStart))
                    {
                        maxProfit = prices[i] - leftStart;
                    }
                }

            }
            return maxProfit;
        }
    }
}
