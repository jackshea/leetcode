using System.Text;

namespace LeetCode.Problems.Medium
{
    /// 最优除法
    /// https://leetcode-cn.com/problems/optimal-division/
    public class P0553_OptimalDivision
    {
        public string OptimalDivision(int[] nums)
        {
            if (nums.Length == 1)
            {
                return nums[0].ToString();
            }

            if (nums.Length == 2)
            {
                return $"{nums[0]}/{nums[1]}";
            }

            StringBuilder sb = new StringBuilder();
            for (int i = 2; i < nums.Length; i++)
            {
                sb.Append("/" + nums[i]);
            }

            return $"{nums[0]}/({nums[1]}{sb})";
        }
    }
}