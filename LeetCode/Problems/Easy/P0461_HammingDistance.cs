namespace LeetCode.Problems.Easy;

/// 汉明距离
/// https://leetcode-cn.com/problems/hamming-distance/
public class P0461_HammingDistance
{
    public int HammingDistance(int x, int y)
    {
        return HammingWeight(x ^ y);
    }

    /// 位1的数量
    public int HammingWeight(int n)
    {
        var count = 0;
        while (n != 0)
        {
            if (n % 2 == 1) count++;

            n = n >> 1;
        }

        return count;
    }
}