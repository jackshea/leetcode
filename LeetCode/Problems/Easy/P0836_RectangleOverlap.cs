namespace LeetCode.Problems.Easy
{
    /// 矩形重叠
    /// https://leetcode-cn.com/problems/rectangle-overlap/
    public class P0836_RectangleOverlap
    {
        public bool IsRectangleOverlap(int[] rec1, int[] rec2)
        {
            return !(rec1[0] >= rec2[2] || rec2[0] >= rec1[0] || rec1[1] >= rec2[3] || rec2[1] >= rec1[3]);
        }
    }
}