namespace LeetCode.Problems.Easy;

/// 第 N 个泰波那契数
/// https://leetcode-cn.com/problems/n-th-tribonacci-number/
public class P1137_NThTribonacciNumber
{
    public int Tribonacci(int n)
    {
        if (n <= 0) return 0;

        var a = 0;
        var b = 1;
        var c = 1;
        for (var i = 3; i <= n; i++)
        {
            var sum = a + b + c;
            a = b;
            b = c;
            c = sum;
        }

        return c;
    }
}