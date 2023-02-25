using System;
using System.Text;

namespace LeetCode.Problems.Medium;

/// 回文素数
/// https://leetcode-cn.com/problems/prime-palindrome/
public class P0866_PrimePalindrome
{
    public int PrimePalindrome(int n)
    {
        for (var L = 1; L <= 5; ++L)
        {
            for (var root = (int)Math.Pow(10, L - 1); root < (int)Math.Pow(10, L); ++root)
            {
                var sb = new StringBuilder(root.ToString());
                for (var k = L - 2; k >= 0; --k)
                    sb.Append(sb[k]);
                var x = int.Parse(sb.ToString());
                if (x >= n && IsPrime(x))
                    return x;
            }

            for (var root = (int)Math.Pow(10, L - 1); root < (int)Math.Pow(10, L); ++root)
            {
                var sb = new StringBuilder(root.ToString());
                for (var k = L - 1; k >= 0; --k)
                    sb.Append(sb[k]);
                var x = int.Parse(sb.ToString());
                if (x >= n && IsPrime(x))
                    return x;
            }
        }

        return -1;
    }

    public bool IsPrime(int n)
    {
        if (n == 2)
            return true;

        if (n < 2 || n % 2 == 0) return false;

        var r = (int)Math.Sqrt(n);
        for (var d = 3; d <= r; d += 2)
            if (n % d == 0)
                return false;
        return true;
    }
}