namespace LeetCode.Problems.Medium;

/// 跳跃游戏
/// https://leetcode-cn.com/problems/jump-game/
public class P0055_JumpGame
{
    public bool CanJump(int[] nums)
    {
        if (nums.Length <= 1) return true;

        var furthest = 0;
        for (var i = 0; i < nums.Length && i <= furthest; i++)
        {
            if (furthest < nums[i] + i) furthest = nums[i] + i;

            if (furthest >= nums.Length - 1) return true;
        }

        return false;
    }
}

/// DFS 会超时
public class P0055_JumpGame_1
{
    public bool CanJump(int[] nums)
    {
        return DFS(nums, 0, nums.Length - 1);
    }

    private bool DFS(int[] nums, int start, int end)
    {
        if (start == end) return true;

        if (start > end) return false;

        var n = nums[start];
        if (n == 0) return false;

        for (var i = n; i >= 1; i--)
            if (DFS(nums, start + i, end))
                return true;

        return false;
    }
}