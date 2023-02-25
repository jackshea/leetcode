using System.Collections.Generic;

namespace LeetCode.Problems.Easy;

/// 自除数
/// https://leetcode-cn.com/problems/self-dividing-numbers/
public class P0728_SelfDividingNumbers
{
    public IList<int> SelfDividingNumbers(int left, int right)
    {
        var ans = new List<int>();
        for (var i = left; i <= right; i++)
            if (IsSelfDividingNumbers(i))
                ans.Add(i);

        return ans;
    }

    private bool IsSelfDividingNumbers(int num)
    {
        var d = num;
        while (d >= 10)
        {
            var mod = d % 10;

            if (mod == 0 || num % mod != 0) return false;

            d /= 10;
        }

        return num % d == 0;
    }
}