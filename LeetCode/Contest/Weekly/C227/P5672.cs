namespace LeetCode.Contest.Weekly.C227;

/// 检查数组是否经排序和轮转得到
/// https://leetcode-cn.com/contest/weekly-contest-227/problems/check-if-array-is-sorted-and-rotated/
public class P5672
{
    public bool Check(int[] nums)
    {
        var findMin = false;
        for (var i = 0; i < nums.Length - 1; i++)
            if (!findMin)
            {
                if (nums[i] > nums[i + 1]) findMin = true;
            }
            else
            {
                if (nums[i] > nums[i + 1] || nums[i] > nums[0]) return false;
            }

        return !findMin || nums[nums.Length - 1] <= nums[0];
    }
}