namespace LeetCode.Problems.Easy;

/// 有效的回旋镖
/// https://leetcode-cn.com/problems/valid-boomerang/
public class P1037_ValidBoomerang
{
    public bool IsBoomerang(int[][] points)
    {
        var x1 = points[1][0] - points[0][0];
        var x2 = points[2][0] - points[0][0];

        var y1 = points[1][1] - points[0][1];
        var y2 = points[2][1] - points[0][1];

        return x1 * y2 != x2 * y1;
    }
}