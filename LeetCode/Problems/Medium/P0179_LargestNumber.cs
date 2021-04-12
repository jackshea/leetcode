using System;
using System.Linq;
using System.Text;

namespace LeetCode.Problems.Medium
{
    /// 最大数
    /// https://leetcode-cn.com/problems/largest-number/
    public class P0179_LargestNumber
    {
        public string LargestNumber(int[] nums)
        {
            var list = nums.Select(p => p.ToString()).ToList();
            list.Sort((a, b) => -String.Compare(a + b, b + a, StringComparison.Ordinal));
            if (list[0] == "0")
            {
                return "0";
            }
            StringBuilder ans = new StringBuilder();
            foreach (var item in list)
            {
                ans.Append(item);
            }

            return ans.ToString();
        }
    }
}