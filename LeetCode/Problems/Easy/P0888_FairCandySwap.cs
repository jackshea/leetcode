using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Problems.Easy;

/// 公平的糖果交换
/// https://leetcode-cn.com/problems/fair-candy-swap/
public class P0888_FairCandySwap
{
    public int[] FairCandySwap(int[] A, int[] B)
    {
        var sumA = A.Sum();
        var sumB = B.Sum();
        var needSwap = (sumA - sumB) / 2;
        var setB = new HashSet<int>();
        foreach (var b in B) setB.Add(b);
        foreach (var a in A)
            if (setB.Contains(a - needSwap))
                return new[] { a, a - needSwap };

        return null;
    }
}