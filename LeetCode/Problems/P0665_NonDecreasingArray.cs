namespace LeetCode.Problems
{
    /// 非递减数列
    /// https://leetcode-cn.com/problems/non-decreasing-array/
    public class P0665_NonDecreasingArray
    {
        public bool CheckPossibility(int[] nums)
        {
            if (nums.Length < 3)
            {
                return true;
            }

            int count = 0;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] > nums[i + 1])
                {
                    count++;
                    if (count > 1)
                    {
                        return false;
                    }
                    if (i > 0 && nums[i - 1] > nums[i + 1])
                    {
                        nums[i + 1] = nums[i];
                    }
                }
            }

            return true;
        }
    }
}