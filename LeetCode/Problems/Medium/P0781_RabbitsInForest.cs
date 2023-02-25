using System;
using System.Collections.Generic;

namespace LeetCode.Problems.Medium;

/// 森林中的兔子
/// https://leetcode-cn.com/problems/rabbits-in-forest/
public class P0781_RabbitsInForest
{
    public int NumRabbits(int[] answers)
    {
        if (answers.Length == 0) return 0;
        var freq = new Dictionary<int, int>();
        foreach (var answer in answers)
        {
            freq.TryGetValue(answer, out var count);
            freq[answer] = count + 1;
        }

        var ans = 0;
        foreach (var kvp in freq)
        {
            var groupCap = kvp.Key + 1;
            var groupCount = (int)Math.Ceiling(1.0 * kvp.Value / groupCap);
            ans += groupCap * groupCount;
        }

        return ans;
    }
}