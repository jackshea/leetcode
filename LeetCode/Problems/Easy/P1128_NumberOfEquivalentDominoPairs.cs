using System.Collections.Generic;

namespace LeetCode.Problems.Easy;

/// 等价多米诺骨牌对的数量
/// https://leetcode-cn.com/problems/number-of-equivalent-domino-pairs/
public class P1128_NumberOfEquivalentDominoPairs
{
    public int NumEquivDominoPairs(int[][] dominoes)
    {
        var dic = new Dictionary<int, int>();
        var key = 0;
        var ans = 0;
        foreach (var domino in dominoes)
        {
            var a = domino[0];
            var b = domino[1];
            key = a < b ? a * 10 + b : b * 10 + a;
            if (dic.ContainsKey(key))
                dic[key]++;
            else
                dic[key] = 1;
        }

        foreach (var count in dic.Values)
            if (count >= 2)
                ans += count * (count - 1) / 2;

        return ans;
    }
}