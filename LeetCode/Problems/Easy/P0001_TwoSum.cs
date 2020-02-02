namespace LeetCode.Problems.Easy
{
    /// 两数之和
    /// https://leetcode-cn.com/problems/two-sum/description/
    public class P0001_TwoSum
    {
        public int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new[] { i, j };
                    }
                }
            }

            return null;
        }
    }
}