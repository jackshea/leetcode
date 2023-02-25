namespace LeetCode.Problems.Hard;

/// 黑板异或游戏
/// https://leetcode-cn.com/problems/chalkboard-xor-game/
public class P0810_ChalkboardXorGame
{
    public bool XorGame(int[] nums)
    {
        if (nums.Length % 2 == 0) return true;

        var xor = 0;
        foreach (var num in nums) xor ^= num;

        return xor == 0;
    }
}