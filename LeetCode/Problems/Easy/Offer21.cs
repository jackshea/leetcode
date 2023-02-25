namespace LeetCode.Problems.Easy;

/// 剑指 Offer 21. 调整数组顺序使奇数位于偶数前面
/// https://leetcode-cn.com/problems/diao-zheng-shu-zu-shun-xu-shi-qi-shu-wei-yu-ou-shu-qian-mian-lcof/
public class Offer21
{
    public int[] Exchange(int[] nums)
    {
        int left = 0, right = nums.Length - 1;
        while (left < right)
        {
            while (left < right && nums[left] % 2 != 0) left++;

            while (left < right && nums[right] % 2 == 0) right--;

            if (left < right)
            {
                var temp = nums[left];
                nums[left] = nums[right];
                nums[right] = temp;
            }
        }

        return nums;
    }
}