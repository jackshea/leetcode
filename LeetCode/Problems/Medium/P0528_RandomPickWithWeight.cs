using System;
using System.Linq;

namespace LeetCode.Problems.Medium;

/// 按权重随机选择
/// https://leetcode-cn.com/problems/random-pick-with-weight/
public class Solution
{
    private readonly Random rand;
    private readonly int sum;
    private readonly int[] sumWeights;

    public Solution(int[] w)
    {
        var s = 0;
        sumWeights = new int[w.Length];
        for (var i = 0; i < w.Length; i++)
        {
            s += w[i];
            sumWeights[i] = s;
        }

        sum = w.Sum();
        rand = new Random();
    }

    public int PickIndex()
    {
        var selected = rand.Next(sum);
        int left = 0, right = sumWeights.Length - 1;
        while (left < right)
        {
            var mid = left + (right - left) / 2;
            if (sumWeights[mid] <= selected)
                left = mid + 1;
            else
                right = mid;
        }

        return left;
    }
}