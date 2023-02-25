using System;

namespace LeetCode.Problems.Easy;

/// 统计好三元组
/// https://leetcode-cn.com/problems/count-good-triplets/
public class P1534_CountGoodTriplets
{
    public int CountGoodTriplets(int[] arr, int a, int b, int c)
    {
        var ans = 0;
        for (var i = 0; i < arr.Length; i++)
        for (var j = i + 1; j < arr.Length; j++)
        for (var k = j + 1; k < arr.Length; k++)
            if (Math.Abs(arr[i] - arr[j]) <= a && Math.Abs(arr[j] - arr[k]) <= b && Math.Abs(arr[i] - arr[k]) <= c)
                ans++;

        return ans;
    }
}