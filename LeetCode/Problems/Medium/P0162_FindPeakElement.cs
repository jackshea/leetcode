namespace LeetCode.Problems.Medium
{
    /// 寻找峰值
    /// https://leetcode-cn.com/problems/find-peak-element/
    public class P0162_FindPeakElement
    {
        public int FindPeakElement(int[] nums)
        {
            int left = 0;
            int right = nums.Length - 1;
            while (left < right)
            {
                int mid = left + (right - left) / 2;
                if (nums[mid] < nums[mid + 1])
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid;
                }
            }

            return left;
        }
    }
}