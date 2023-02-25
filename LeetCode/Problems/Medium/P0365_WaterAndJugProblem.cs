namespace LeetCode.Problems.Medium;

/// 水壶问题
/// https://leetcode-cn.com/problems/water-and-jug-problem/
public class P0365_WaterAndJugProblem
{
    public bool CanMeasureWater(int x, int y, int z)
    {
        if (x + y < z) return false;
        var gcd = GCD(x, y);
        if (gcd == 0) return z == 0 || x + y == z;
        return z % gcd == 0;
    }

    private int GCD(int a, int b)
    {
        return b == 0 ? a : GCD(b, a % b);
    }
}