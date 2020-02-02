namespace LeetCode.Problems.Easy
{
    /// 斐波那契数
    /// https://leetcode-cn.com/problems/fibonacci-number/
    public class P0509_FibonacciNumber
    {
        public int Fib(int N)
        {
            int a = 0;
            int b = 1;
            int c = 0;

            if (N < 2)
            {
                return N;
            }

            for (int i = 2; i <= N; i++)
            {
                c = a + b;
                a = b;
                b = c;
            }

            return c;
        }
    }
}