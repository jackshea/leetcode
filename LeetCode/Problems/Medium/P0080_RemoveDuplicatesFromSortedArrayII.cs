namespace LeetCode.Problems.Medium;

/// 删除排序数组中的重复项 II
/// https://leetcode-cn.com/problems/remove-duplicates-from-sorted-array-ii/
public class P0080_RemoveDuplicatesFromSortedArrayII
{
    public int RemoveDuplicates(int[] nums)
    {
        if (nums == null) return 0;

        if (nums.Length <= 2) return nums.Length;

        var a = 2;
        for (var i = 2; i < nums.Length; i++)
            if (nums[i] != nums[a - 2])
                nums[a++] = nums[i];

        return a;
    }
}