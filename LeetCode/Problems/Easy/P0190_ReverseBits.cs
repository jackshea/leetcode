namespace LeetCode.Problems.Easy;

/// 颠倒二进制位
/// https://leetcode-cn.com/problems/reverse-bits/
public class P0190_ReverseBits
{
    public uint reverseBits(uint n)
    {
        uint result = 0;
        var length = 32;
        for (var i = 0; i < length; i++)
        {
            result += n % 2;
            n = n >> 1;
            if (i < length - 1) result = result << 1;
        }

        return result;
    }
}