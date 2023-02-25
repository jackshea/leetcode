namespace LeetCode.Problems.Easy;

/// 在区间范围内统计奇数数目
/// https://leetcode-cn.com/problems/count-odd-numbers-in-an-interval-range/
public class P5456_CountOddNumbersInAnIntervalRange
{
    public int CountOdds(int low, int high)
    {
        var ans = 0;
        var diff = high - low + 1;
        ans = diff / 2;
        if (diff % 2 != 0 && high % 2 != 0) ans++;

        return ans;
    }
}