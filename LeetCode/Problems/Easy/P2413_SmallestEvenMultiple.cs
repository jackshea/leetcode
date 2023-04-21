namespace LeetCode.Problems.Easy;

/// 最小偶倍数
/// https://leetcode.cn/problems/smallest-even-multiple/
public class P2413_SmallestEvenMultiple
{
    public int SmallestEvenMultiple(int n)
    {
        if (n % 2 == 0)
        {
            return n;
        }
        else
        {
            return 2 * n;
        }
    }
}