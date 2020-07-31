namespace LeetCode.Problems.Easy
{
    /// 剑指 Offer 57. 和为s的两个数字
    /// https://leetcode-cn.com/problems/he-wei-sde-liang-ge-shu-zi-lcof/
    public class Offer57
    {
        public int[] TwoSum(int[] nums, int target)
        {
            int left = 0, right = nums.Length - 1;
            while (left < right)
            {
                int sum = nums[left] + nums[right];
                if (sum == target)
                {
                    break;
                }
                else if (sum < target)
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }
            return new[] { nums[left], nums[right] };
        }
    }
}