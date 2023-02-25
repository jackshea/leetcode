namespace LeetCode.Problems.Easy;

/// 爬楼梯
/// https://leetcode-cn.com/problems/climbing-stairs/description/
/// 等价于求 斐波那契数列
public class P0070_ClimbingStairs
{
    public int ClimbStairs(int n)
    {
        if (n <= 3) return n;

        var a = 2;
        var b = 3;
        var c = 0;

        for (var i = 4; i <= n; i++)
        {
            c = a + b;
            a = b;
            b = c;
        }

        return c;
    }
}