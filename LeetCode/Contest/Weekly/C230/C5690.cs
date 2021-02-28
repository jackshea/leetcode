using System;

namespace LeetCode.Contest.Weekly.C230
{
    /// 最接近目标价格的甜点成本
    /// https://leetcode-cn.com/contest/weekly-contest-230/problems/closest-dessert-cost/
    public class C5690
    {
        private int closet = 100000;
        public int ClosestCost(int[] baseCosts, int[] toppingCosts, int target)
        {
            for (int i = 0; i < baseCosts.Length; i++)
            {
                DFS(toppingCosts, 0, 0, baseCosts[i], target);
            }

            return closet;
        }

        private void DFS(int[] toppingCosts, int toppingIdx, int toppingCount, int sum, int target)
        {
            if (closet == target)
            {
                return;
            }

            if (Math.Abs(closet - target) == Math.Abs(sum - target))
            {
                closet = Math.Min(closet, sum);
            }
            else if (Math.Abs(closet - target) > Math.Abs(sum - target))
            {
                closet = sum;
            }

            if (toppingIdx >= toppingCosts.Length || sum >= target)
            {
                return;
            }

            DFS(toppingCosts, toppingIdx + 1, 0, sum, target);

            sum += toppingCosts[toppingIdx];
            if (toppingCount == 1)
            {
                DFS(toppingCosts, toppingIdx + 1, 0, sum, target);
            }
            else
            {
                DFS(toppingCosts, toppingIdx, 1, sum, target);
            }
        }
    }
}