namespace LeetCode.Problems.Easy;

/// 斐波那契数
/// https://leetcode-cn.com/problems/fibonacci-number/
public class P0509_FibonacciNumber
{
    public int Fib(int N)
    {
        var a = 0;
        var b = 1;
        var c = 0;

        if (N < 2) return N;

        for (var i = 2; i <= N; i++)
        {
            c = a + b;
            a = b;
            b = c;
        }

        return c;
    }
}