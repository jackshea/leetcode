using System;
using System.Linq;

namespace LeetCode.Problems.Medium;

/// 交换和
/// https://leetcode-cn.com/problems/sum-swap-lcci/
public class MST1621
{
    public int[] FindSwapValues(int[] array1, int[] array2)
    {
        var sum1 = array1.Sum();
        var sum2 = array2.Sum();
        var diff = sum1 - sum2;
        if (diff % 2 != 0) return new int[0];
        Array.Sort(array1);
        Array.Sort(array2);
        int i1 = 0, i2 = 0;
        while (i1 < array1.Length && i2 < array2.Length)
        {
            var d = (array1[i1] - array2[i2]) * 2;
            if (d == diff) return new[] { array1[i1], array2[i2] };
            if (d < diff)
                i1++;
            else
                i2++;
        }

        return new int[0];
    }
}