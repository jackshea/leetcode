namespace LeetCode.Problems.Easy
{
    /// 有效的回旋镖
    /// https://leetcode-cn.com/problems/valid-boomerang/
    public class P1037_ValidBoomerang
    {
        public bool IsBoomerang(int[][] points)
        {
            int x1 = points[1][0] - points[0][0];
            int x2 = points[2][0] - points[0][0];

            int y1 = points[1][1] - points[0][1];
            int y2 = points[2][1] - points[0][1];

            return x1 * y2 != x2 * y1;
        }
    }
}