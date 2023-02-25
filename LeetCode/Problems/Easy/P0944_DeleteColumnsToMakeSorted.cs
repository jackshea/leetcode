﻿namespace LeetCode.Problems.Easy;

/// 删列造序
/// https://leetcode-cn.com/problems/delete-columns-to-make-sorted/
public class P0944_DeleteColumnsToMakeSorted
{
    public int MinDeletionSize(string[] A)
    {
        var ans = 0;
        for (var i = 0; i < A[0].Length; i++)
        for (var j = 0; j < A.Length - 1; j++)
            if (A[j][i] > A[j + 1][i])
            {
                ans++;
                break;
            }

        return ans;
    }
}