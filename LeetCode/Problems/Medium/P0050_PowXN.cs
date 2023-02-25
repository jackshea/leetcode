namespace LeetCode.Problems.Medium;

/// Pow(x, n)
/// https://leetcode-cn.com/problems/powx-n/
public class P0050_PowXN
{
    public double MyPow(double x, int n)
    {
        return MyPowImpl(x, n);
    }

    private double MyPowImpl(double x, long ln)
    {
        if (ln == 1) return x;

        if (ln == 0) return 1;

        if (ln < 0) return 1.0 / MyPowImpl(x, -ln);

        var ans = MyPowImpl(x, ln / 2);
        ans *= ans;

        if (ln % 2 != 0) ans *= x;

        return ans;
    }
}