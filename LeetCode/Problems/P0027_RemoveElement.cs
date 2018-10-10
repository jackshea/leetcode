namespace LeetCode.Problems
{
    /// 移除元素
    /// https://leetcode-cn.com/problems/remove-element/description/
    public class P0027_RemoveElement
    {
        public int RemoveElement(int[] nums, int val)
        {
            if (nums == null || nums.Length == 0)
            {
                return 0;
            }

            int j = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[j] = nums[i];
                    j++;
                }
            }

            return j;
        }
    }
}