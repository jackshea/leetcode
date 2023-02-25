using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems.Medium;

/// 第k个排列
/// https://leetcode-cn.com/problems/permutation-sequence/
public class P0060_PermutationSequence
{
    public string GetPermutation(int n, int k)
    {
        var sb = new StringBuilder();
        var factorial = new int[10];
        factorial[0] = 1;
        for (var i = 1; i < 10; i++) factorial[i] = i * factorial[i - 1];

        var num = new List<int>();
        for (var i = 1; i <= 9; i++) num.Add(i);

        k--;
        for (var i = n - 1; i >= 0; i--)
        {
            var index = k / factorial[i];
            k -= index * factorial[i];
            sb.Append(num[index]);
            num.RemoveAt(index);
        }

        return sb.ToString();
    }
}