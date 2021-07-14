﻿using System;

namespace LeetCode.Problems.Medium
{
    /// 绝对差值和
    /// https://leetcode-cn.com/problems/minimum-absolute-sum-difference/
    public class P1818_MinimumAbsoluteSumDifference
    {
        public int MinAbsoluteSumDiff(int[] nums1, int[] nums2)
        {
            const int MOD = 1000000007;
            int n = nums1.Length;
            int[] sort = new int[n];
            Array.Copy(nums1, sort, n);
            Array.Sort(sort);
            int sum = 0, maxDelta = 0;
            for (int i = 0; i < n; i++)
            {
                int diff = Math.Abs(nums1[i] - nums2[i]);
                sum += diff;
                var idx = Array.BinarySearch(sort, nums2[i]);
                if (idx < 0)
                {
                    idx = ~idx;
                }

                if (idx < n)
                {
                    maxDelta = Math.Max(maxDelta, diff - (sort[idx] - nums2[i]));
                }
                if (idx > 0)
                {
                    maxDelta = Math.Max(maxDelta, diff - (nums2[i] - sort[idx - 1]));
                }
            }

            return (sum - maxDelta) % MOD;
        }
    }
}