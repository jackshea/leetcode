namespace LeetCode.Problems.Medium;

/// 绘制直线
/// https://leetcode-cn.com/problems/draw-line-lcci/
public class MST0508
{
    public int[] DrawLine(int length, int w, int x1, int x2, int y)
    {
        var ans = new int[length];
        for (var i = x1; i <= x2; i++) ans[i / 32 + y * w / 32] |= 1 << (31 - i % 32);
        return ans;
    }
}