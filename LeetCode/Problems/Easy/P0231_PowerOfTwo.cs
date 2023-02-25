namespace LeetCode.Problems.Easy;

/// 2的幂
/// https://leetcode-cn.com/problems/power-of-two/
public class P0231_PowerOfTwo
{
    public bool IsPowerOfTwo(int n)
    {
        while (n > 0)
        {
            if (n % 2 != 0) return n == 1;

            n = n >> 1;
        }

        return false;
    }
}