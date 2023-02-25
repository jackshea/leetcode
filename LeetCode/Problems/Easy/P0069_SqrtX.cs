namespace LeetCode.Problems.Easy;

/// x 的平方根
/// https://leetcode-cn.com/problems/sqrtx/description/
public class P0069_SqrtX
{
    public int MySqrt(int x)
    {
        if (x <= 1) return x;
        int lo = 1, hi = x;
        while (lo < hi)
        {
            var mid = lo + (hi - lo + 1) / 2;
            if (mid <= x / mid)
                lo = mid;
            else
                hi = mid - 1;
        }

        return lo;
    }
}