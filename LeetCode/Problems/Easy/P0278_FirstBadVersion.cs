﻿namespace LeetCode.Problems.Easy
{
    /// 第一个错误的版本
    /// https://leetcode-cn.com/problems/first-bad-version/
    public class P0278_FirstBadVersion : VersionControl
    {
        public int FirstBadVersion(int n)
        {
            int left = 1;
            int right = n;
            while (left < right)
            {
                int mid = left + (right - left) / 2;
                if (IsBadVersion(mid))
                {
                    right = mid;
                }
                else
                {
                    left = mid + 1;
                }
            }

            return left;
        }
    }

    public class VersionControl
    {
        public bool IsBadVersion(int version)
        {
            return true;
        }
    }
}