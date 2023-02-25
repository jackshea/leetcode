using System;

namespace LeetCode.Problems.Easy;

public class P5122
{
    public double TrimMean(int[] arr)
    {
        Array.Sort(arr);
        var topn = (int)(arr.Length * 0.05);
        var sum = 0;
        for (var i = topn; i < arr.Length - topn; i++) sum += arr[i];

        return sum * 1.0 / (arr.Length - 2 * topn);
    }
}