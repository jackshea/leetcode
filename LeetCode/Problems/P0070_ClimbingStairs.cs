namespace LeetCode.Problems
{
    /// 爬楼梯
    /// https://leetcode-cn.com/problems/climbing-stairs/description/
    /// 等价于求 斐波那契数列
    public class P0070_ClimbingStairs
    {
        public int ClimbStairs(int n)
        {
            if (n <= 3)
            {
                return n;
            }

            int a = 2;
            int b = 3;
            int c = 0;

            for (int i = 4; i <= n; i++)
            {
                c = a + b;
                a = b;
                b = c;
            }

            return c;
        }
    }
}