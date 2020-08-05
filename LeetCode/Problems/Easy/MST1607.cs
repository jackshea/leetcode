namespace LeetCode.Problems.Easy
{
    /// 面试题 16.07. 最大数值
    /// https://leetcode-cn.com/problems/maximum-lcci/
    public class MST1607
    {
        public int Maximum(int a, int b)
        {
            long x = (long)a - (long)b;
            int k = (int)(x >> 63);

            return (1 + k) * a - b * k;
        }
    }
}