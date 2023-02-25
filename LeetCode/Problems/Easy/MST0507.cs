namespace LeetCode.Problems.Easy;

/// 配对交换
/// https://leetcode-cn.com/problems/exchange-lcci/
public class MST0507
{
    public int ExchangeBits(int num)
    {
        return (int)((uint)((num & 0x55555555) << 1) | ((num & 0xaaaaaaaa) >> 1));
    }
}