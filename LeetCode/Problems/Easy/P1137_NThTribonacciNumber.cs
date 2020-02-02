namespace LeetCode.Problems.Easy
{
    /// 第 N 个泰波那契数
    /// https://leetcode-cn.com/problems/n-th-tribonacci-number/
    public class P1137_NThTribonacciNumber
    {
        public int Tribonacci(int n)
        {
            if (n <= 0)
            {
                return 0;
            }

            int a = 0;
            int b = 1;
            int c = 1;
            for (int i = 3; i <= n; i++)
            {
                int sum = a + b + c;
                a = b;
                b = c;
                c = sum;
            }

            return c;
        }
    }
}