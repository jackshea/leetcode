using System;

namespace LeetCode.Problems.Easy
{
    /// 特殊数组的特征值
    /// https://leetcode-cn.com/problems/special-array-with-x-elements-greater-than-or-equal-x/
    public class P1608_SpecialArrayWithXElementsGreaterThanOrEqualX
    {
        public int SpecialArray(int[] nums)
        {
            Array.Sort(nums);
            if (nums[0] >= nums.Length)
            {
                return nums.Length;
            }

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[nums.Length - i] >= i && nums[nums.Length - i - 1] < i)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}