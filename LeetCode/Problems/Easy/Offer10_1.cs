namespace LeetCode.Problems.Easy;

/// 剑指 Offer 10- I.斐波那契数列
/// https://leetcode-cn.com/problems/fei-bo-na-qi-shu-lie-lcof/
public class Offer10_1
{
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