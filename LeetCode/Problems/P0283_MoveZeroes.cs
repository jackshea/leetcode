namespace LeetCode.Problems
{
    /// 移动零
    /// https://leetcode-cn.com/problems/move-zeroes/
    public class P0283_MoveZeroes
    {
        public void MoveZeroes(int[] nums)
        {
            int firstZeroIndex = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    nums[firstZeroIndex++] = nums[i];
                }
            }

            for (int i = firstZeroIndex; i < nums.Length; i++)
            {
                nums[i] = 0;
            }
        }
    }
}