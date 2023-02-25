namespace LeetCode.Problems.Easy;

/// 交替位二进制数
/// https://leetcode-cn.com/problems/binary-number-with-alternating-bits/
public class P0693_BinaryNumberWithAlternatingBits
{
    public bool HasAlternatingBits(int n)
    {
        var m = n ^ (n >> 1);
        return (m & (m + 1)) == 0;
    }
}