using System;
using System.Collections.Generic;

namespace LeetCode.Problems.Medium
{
    /// 格雷编码
    /// https://leetcode-cn.com/problems/gray-code/
    public class P0089_GrayCode
    {
        public IList<int> GrayCode(int n)
        {
            var ans = new List<int>();
            ans.Add(0);
            int max = (int)Math.Pow(2, n);
            for (int i = 1; i <= max; i++)
            {
                ans.Add(i ^ (i / 2));
            }

            return ans;
        }
    }
}