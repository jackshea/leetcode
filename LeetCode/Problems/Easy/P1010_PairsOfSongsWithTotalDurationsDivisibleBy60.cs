namespace LeetCode.Problems.Easy;

/// 总持续时间可被 60 整除的歌曲
/// https://leetcode-cn.com/problems/pairs-of-songs-with-total-durations-divisible-by-60/
public class P1010_PairsOfSongsWithTotalDurationsDivisibleBy60
{
    public int NumPairsDivisibleBy60(int[] time)
    {
        var ans = 0;
        var pool = new int[60];
        for (var i = 0; i < time.Length; i++)
        {
            var n = time[i] % 60;
            if (n == 0)
                ans += pool[n];
            else
                ans += pool[60 - n];

            pool[n]++;
        }

        return ans;
    }
}