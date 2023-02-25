namespace LeetCode.Problems.Easy;

/// 跳水板
/// https://leetcode-cn.com/problems/diving-board-lcci/
public class MST1611
{
    public int[] DivingBoard(int shorter, int longer, int k)
    {
        if (k <= 0) return new int[0];

        if (shorter == longer) return new[] { k * shorter };

        var ans = new int[k + 1];
        for (var i = 0; i <= k; i++) ans[i] = i * longer + (k - i) * shorter;

        return ans;
    }
}