using System;
using System.Collections.Generic;

namespace LeetCode.Problems.Easy
{
    /// 最小绝对差
    /// https://leetcode-cn.com/problems/minimum-absolute-difference/
    public class P1200_MinimumAbsoluteDifference
    {
        public IList<IList<int>> MinimumAbsDifference(int[] arr)
        {
            Array.Sort(arr);
            int minDiff = Int32.MaxValue;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int diff = arr[i + 1] - arr[i];
                if (diff < minDiff)
                {
                    minDiff = diff;
                }
            }

            IList<IList<int>> ans = new List<IList<int>>();
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int diff = arr[i + 1] - arr[i];
                if (diff == minDiff)
                {
                    ans.Add(new List<int>() { arr[i], arr[i + 1] });
                }
            }

            return ans;
        }
    }
}