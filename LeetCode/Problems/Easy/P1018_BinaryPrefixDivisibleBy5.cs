using System.Collections.Generic;

namespace LeetCode.Problems.Easy;

/// 可被 5 整除的二进制前缀
/// https://leetcode-cn.com/problems/binary-prefix-divisible-by-5/
public class P1018_BinaryPrefixDivisibleBy5
{
    public IList<bool> PrefixesDivBy5(int[] A)
    {
        IList<bool> ans = new List<bool>();
        var n = 0;
        foreach (var a in A)
        {
            n += a % 2;
            n %= 5;
            ans.Add(n == 0);
            n <<= 1;
        }

        return ans;
    }
}