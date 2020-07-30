namespace LeetCode.Problems.Easy
{
    /// 剑指 Offer 53 - I. 在排序数组中查找数字 I
    /// https://leetcode-cn.com/problems/zai-pai-xu-shu-zu-zhong-cha-zhao-shu-zi-lcof/
    public class Offer53_I
    {
        public int Search(int[] nums, int target)
        {
            int ans = 0;
            int left = 0, right = nums.Length - 1;
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (nums[mid] == target)
                {
                    right = mid - 1;
                }
                else if (nums[mid] < target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            if (left >= nums.Length || nums[left] != target)
            {
                return 0;
            }

            for (int i = left; i < nums.Length; i++)
            {
                if (nums[i] == target)
                {
                    ans++;
                }
                else
                {
                    break;
                }
            }

            return ans;
        }
    }
}