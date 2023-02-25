using System.Collections.Generic;

namespace LeetCode.Problems.Medium;

/// 大餐计数
/// https://leetcode-cn.com/problems/count-good-meals/
public class P1711_CountGoodMeals
{
    public int CountPairs(int[] deliciousness)
    {
        var MOD = (int)1E9 + 7;
        var maxSum = 0;
        foreach (var d in deliciousness)
            if (d > maxSum)
                maxSum = d;

        maxSum <<= 1;
        var ans = 0;
        var dic = new Dictionary<int, int>();
        foreach (var d in deliciousness)
        {
            for (var i = 1; i <= maxSum; i <<= 1)
            {
                if (i - d < 0) continue;

                dic.TryGetValue(i - d, out var cnt);
                ans = (ans + cnt) % MOD;
            }

            dic.TryGetValue(d, out var count);
            dic[d] = count + 1;
        }

        return ans;
    }
}