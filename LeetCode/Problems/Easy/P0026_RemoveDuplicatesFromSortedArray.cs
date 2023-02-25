namespace LeetCode.Problems.Easy;

/// 删除排序数组中的重复项
/// https://leetcode-cn.com/problems/remove-duplicates-from-sorted-array/description/
public class P0026_RemoveDuplicatesFromSortedArray
{
    public int RemoveDuplicates(int[] nums)
    {
        if (nums == null || nums.Length == 0) return 0;

        var j = 0;
        for (var i = 1; i < nums.Length; i++)
            if (nums[j] != nums[i])
                nums[++j] = nums[i];

        return j + 1;
    }
}