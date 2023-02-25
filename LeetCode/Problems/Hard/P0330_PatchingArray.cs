namespace LeetCode.Problems.Hard;

/// 按要求补齐数组
/// https://leetcode-cn.com/problems/patching-array/
public class P0330_PatchingArray
{
    public int MinPatches(int[] nums, int n)
    {
        long max = 1;
        var ans = 0;
        var index = 0;
        while (max <= n)
            if (index < nums.Length && nums[index] <= max)
            {
                max += nums[index];
                index++;
            }
            else
            {
                max *= 2;
                ans++;
            }

        return ans;
    }
}