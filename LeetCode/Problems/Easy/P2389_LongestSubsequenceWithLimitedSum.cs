using System;

namespace LeetCode.Problems.Easy;

/// 和有限的最长子序列
/// https://leetcode.cn/problems/longest-subsequence-with-limited-sum/
public class P2389_LongestSubsequenceWithLimitedSum
{
    public int[] AnswerQueries(int[] nums, int[] queries)
    {
        Array.Sort(nums);
        for (int i = 1; i < nums.Length; i++)
        {
            nums[i] += nums[i - 1];
        }

        int[] ans=new int[queries.Length];
        for (int i = 0; i < queries.Length; i++)
        {
            for (int j = 0; j < nums.Length; j++)
            {
                if (queries[i] < nums[j])
                {
                    ans[i] = j ;
                    goto end;
                }
            }

            ans[i] = nums.Length;
            end: ;
        }

        return ans;
    }
}