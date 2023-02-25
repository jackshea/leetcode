using System;

namespace LeetCode.Problems.Easy;

/// 判断能否形成等差数列
/// https://leetcode-cn.com/problems/can-make-arithmetic-progression-from-sequence/
public class P1502_CanMakeArithmeticProgressionFromSequence
{
    public bool CanMakeArithmeticProgression(int[] arr)
    {
        Array.Sort(arr);
        var d = arr[1] - arr[0];
        for (var i = 2; i < arr.Length; i++)
            if (arr[i] - arr[i - 1] != d)
                return false;

        return true;
    }
}