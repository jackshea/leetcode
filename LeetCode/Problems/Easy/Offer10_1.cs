namespace LeetCode.Problems.Easy
{
    /// 剑指 Offer 10- I.斐波那契数列
    /// https://leetcode-cn.com/problems/fei-bo-na-qi-shu-lie-lcof/
    public class Offer10_1
    {
        public int Fib(int n)
        {
            if (n <= 1)
            {
                return n;
            }

            int a = 0;
            int b = 1;
            int c = a + b;
            for (int i = 3; i <= n; i++)
            {
                a = b;
                b = c;
                c = (a + b) % 1000000007;
            }

            return c;
        }
    }
}