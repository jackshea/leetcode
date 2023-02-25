namespace LeetCode.Problems.Medium;

/// 提莫攻击
/// https://leetcode-cn.com/problems/teemo-attacking/
public class P0495_TeemoAttacking
{
    public int FindPoisonedDuration(int[] timeSeries, int duration)
    {
        if (duration == 0 || timeSeries.Length == 0) return 0;

        var ans = 0;
        var start = timeSeries[0];
        var end = timeSeries[0] + duration;
        for (var i = 1; i < timeSeries.Length; i++)
        {
            var t = timeSeries[i];
            if (t <= end)
            {
                end = t + duration;
            }
            else
            {
                ans += end - start;
                start = t;
                end = t + duration;
            }
        }

        ans += end - start;
        return ans;
    }
}