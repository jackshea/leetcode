namespace LeetCode.Problems.Easy;

/// LCP 06. 拿硬币
/// https://leetcode-cn.com/problems/na-ying-bi/
public class LCP06
{
    public int MinCount(int[] coins)
    {
        var ans = 0;
        foreach (var coin in coins) ans += coin % 2 + coin / 2;

        return ans;
    }
}