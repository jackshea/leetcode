using System;

namespace LeetCode.Problems.Medium
{
    /// 面试题40. 最小的k个数
    /// https://leetcode-cn.com/problems/zui-xiao-de-kge-shu-lcof/
    public class MST40_LCOF
    {
        public int[] GetLeastNumbers(int[] arr, int k)
        {
            if (arr.Length <= k)
            {
                return arr;
            }

            Array.Sort(arr);
            int[] ans = new int[k];
            Array.Copy(arr, ans, k);
            return ans;
        }
    }
}