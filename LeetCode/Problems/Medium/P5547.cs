using System;
using System.Collections.Generic;

namespace LeetCode.Problems.Medium
{
    /// 等差子数组
    /// https://leetcode-cn.com/contest/weekly-contest-212/problems/arithmetic-subarrays/
    public class P5547
    {
        public IList<bool> CheckArithmeticSubarrays(int[] nums, int[] l, int[] r)
        {
            IList<bool> ans = new List<bool>(l.Length);
            for (int i = 0; i < l.Length; i++)
            {
                ans.Add(check(nums, l[i], r[i]));
            }

            return ans;
        }

        public bool check(int[] nums, int l, int r)
        {
            int n = r - l + 1;
            if (n <= 2)
            {
                return true;
            }
            int[] sort = new int[n];
            Array.Copy(nums, l, sort, 0, n);
            Array.Sort(sort);
            int d = sort[1] - sort[0];
            for (int i = 1; i < sort.Length; i++)
            {
                if (sort[i] - sort[i - 1] != d)
                {
                    return false;
                }
            }

            return true;
        }
    }
}