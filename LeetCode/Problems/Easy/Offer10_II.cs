namespace LeetCode.Problems.Easy;

/// 剑指 Offer 10- II. 青蛙跳台阶问题
/// https://leetcode-cn.com/problems/qing-wa-tiao-tai-jie-wen-ti-lcof/
public class Offer10_II
{
    public int NumWays(int n)
    {
        return Fib(n + 1);
    }

    public int Fib(int n)
    {
        if (n <= 1) return n;

        var a = 0;
        var b = 1;
        var c = a + b;
        for (var i = 3; i <= n; i++)
        {
            a = b;
            b = c;
            c = (a + b) % 1000000007;
        }

        return c;
    }
}