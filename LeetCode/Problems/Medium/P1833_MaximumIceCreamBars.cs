using System;

namespace LeetCode.Problems.Medium
{
    /// 雪糕的最大数量
    /// https://leetcode-cn.com/problems/maximum-ice-cream-bars/
    public class P1833_MaximumIceCreamBars
    {
        public int MaxIceCream(int[] costs, int coins)
        {
            Array.Sort(costs);
            int ans = 0;
            foreach (var cost in costs)
            {
                coins -= cost;
                if (coins >= 0)
                {
                    ans++;
                }
                else
                {
                    break;
                }
            }

            return ans;
        }
    }
}