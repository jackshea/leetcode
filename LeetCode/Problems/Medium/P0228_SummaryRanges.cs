using System.Collections.Generic;

namespace LeetCode.Problems.Medium
{
    /// 汇总区间
    /// https://leetcode-cn.com/problems/summary-ranges/
    public class P0228_SummaryRanges
    {
        public IList<string> SummaryRanges(int[] nums)
        {
            IList<string> ans = new List<string>();
            if (nums.Length == 0)
            {
                return ans;
            }

            int start = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (i == nums.Length - 1 || nums[i] != nums[i + 1] - 1)
                {
                    if (start == i)
                    {
                        ans.Add(nums[start].ToString());
                    }
                    else
                    {
                        ans.Add($"{nums[start]}->{nums[i]}");
                    }

                    start = i + 1;
                }
            }

            return ans;
        }
    }
}