﻿namespace LeetCode.Problems.Easy;

/// 重复叠加字符串匹配
/// https://leetcode-cn.com/problems/repeated-string-match/
public class P0686_RepeatedStringMatch
{
    public int RepeatedStringMatch(string A, string B)
    {
        for (var i = 0; i < A.Length; i++)
        {
            if (A[i] != B[0])
                continue;

            var aIndex = i + 1;
            var result = 1;
            var isMatch = true;
            for (var j = 1; j < B.Length; j++)
            {
                if (aIndex >= A.Length)
                {
                    aIndex -= A.Length;
                    result++;
                }

                if (B[j] != A[aIndex])
                {
                    isMatch = false;
                    break;
                }

                aIndex++;
            }

            if (isMatch) return result;
        }

        return -1;
    }
}