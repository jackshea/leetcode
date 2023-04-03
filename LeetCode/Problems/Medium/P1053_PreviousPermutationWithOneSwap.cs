using System;

namespace LeetCode.Problems.Medium;

/// 交换一次的先前排列
/// https://leetcode.cn/problems/previous-permutation-with-one-swap/
public class P1053_PreviousPermutationWithOneSwap
{
    public int[] PrevPermOpt1(int[] arr)
    {
        int a = 0, b = 0;
        for (var i = arr.Length - 2; i >= 0; i--)
        {
            if (arr[i] > arr[i + 1])
            {
                a = i;
                break;
            }
        }

        for (int i = a + 1; i < arr.Length; i++)
        {
            if (arr[i] < arr[a] && (b == 0 || arr[i] > arr[b]))
            {
                b = i;
            }
        }

        if (b != 0)
        {
            (arr[a], arr[b]) = (arr[b], arr[a]);
        }
        return arr;
    }
}