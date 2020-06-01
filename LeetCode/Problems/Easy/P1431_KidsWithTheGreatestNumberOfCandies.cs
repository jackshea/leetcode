using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Problems.Easy
{
    /// 拥有最多糖果的孩子
    /// https://leetcode-cn.com/problems/kids-with-the-greatest-number-of-candies/
    public class P1431_KidsWithTheGreatestNumberOfCandies
    {
        public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
        {
            IList<bool> ans = new List<bool>(candies.Length);
            int max = candies.Max();
            for (int i = 0; i < candies.Length; i++)
            {
                ans.Add(candies[i] + extraCandies >= max);
            }

            return ans;
        }
    }
}