using System;
using System.Collections.Generic;

namespace LeetCode.Problems.Medium
{
    /// 找到 K 个最接近的元素
    /// https://leetcode-cn.com/problems/find-k-closest-elements/
    public class P0658_FindKClosestElements
    {
        public IList<int> FindClosestElements(int[] arr, int k, int x)
        {
            int left = 0, right = arr.Length - 1;
            while (right - left >= k)
            {
                if (Math.Abs(arr[left] - x) > Math.Abs(arr[right] - x))
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }

            IList<int> ans = new List<int>();
            for (int i = left; i <= right; i++)
            {
                ans.Add(arr[i]);
            }

            return ans;
        }
    }
}