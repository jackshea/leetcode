namespace LeetCode.Problems.Easy;

/// 魔术索引
/// https://leetcode-cn.com/problems/magic-index-lcci/
public class MST0803
{
    public int FindMagicIndex(int[] nums)
    {
        for (var i = 0; i < nums.Length; i++)
            if (nums[i] == i)
                return i;

        return -1;
    }
}