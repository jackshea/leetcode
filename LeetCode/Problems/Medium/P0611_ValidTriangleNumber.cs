using System;

namespace LeetCode.Problems.Medium
{
    /// 有效三角形的个数
    /// https://leetcode-cn.com/problems/valid-triangle-number/
    public class P0611_ValidTriangleNumber
    {
        public int TriangleNumber(int[] nums)
        {
            Array.Sort(nums);
            int ans = 0;
            for (int i = 0; i < nums.Length - 2; i++)
            {
                if (nums[i] == 0)
                {
                    continue;
                }

                int k = i + 2;
                for (int j = i + 1; j < nums.Length - 1; j++)
                {
                    while (k < nums.Length && nums[i] + nums[j] > nums[k])
                    {
                        k++;
                    }

                    ans += k - j - 1;
                }
            }

            return ans;
        }
    }
}