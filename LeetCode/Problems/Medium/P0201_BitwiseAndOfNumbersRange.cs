namespace LeetCode.Problems.Medium;

/// 数字范围按位与
/// https://leetcode-cn.com/problems/bitwise-and-of-numbers-range/
public class P0201_BitwiseAndOfNumbersRange
{
    public int RangeBitwiseAnd(int m, int n)
    {
        var i = 0;
        while (m != n)
        {
            m >>= 1;
            n >>= 1;
            i++;
        }

        return m << i;
    }
}