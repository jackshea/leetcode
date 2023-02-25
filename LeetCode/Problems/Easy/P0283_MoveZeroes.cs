namespace LeetCode.Problems.Easy;

/// 移动零
/// https://leetcode-cn.com/problems/move-zeroes/
public class P0283_MoveZeroes
{
    public void MoveZeroes(int[] nums)
    {
        var firstZeroIndex = 0;
        for (var i = 0; i < nums.Length; i++)
            if (nums[i] != 0)
                nums[firstZeroIndex++] = nums[i];

        for (var i = firstZeroIndex; i < nums.Length; i++) nums[i] = 0;
    }
}