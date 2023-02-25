namespace LeetCode.Problems.Medium;

/// 镜面反射
/// https://leetcode-cn.com/problems/mirror-reflection/
public class P0858_MirrorReflection
{
    public int MirrorReflection(int p, int q)
    {
        var g = gcd(p, q);
        p /= g;
        p %= 2;
        q /= g;
        q %= 2;
        if (p == 1 && q == 1) return 1;

        return p == 1 ? 0 : 2;
    }

    public int gcd(int a, int b)
    {
        if (b == 0) return a;

        return gcd(b, a % b);
    }
}