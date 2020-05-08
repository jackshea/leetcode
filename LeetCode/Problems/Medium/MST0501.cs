namespace LeetCode.Problems.Medium
{
    /// 插入
    /// https://leetcode-cn.com/problems/insert-into-bits-lcci/
    public class MST0501
    {
        public int InsertBits(int N, int M, int i, int j)
        {
            var mask = ((1 << (j - i + 1)) - 1) << i;
            return (N & ~mask) | (M << i);
        }
    }
}