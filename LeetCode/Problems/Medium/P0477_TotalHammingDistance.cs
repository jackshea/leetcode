namespace LeetCode.Problems.Medium;

/// 汉明距离总和
/// https://leetcode-cn.com/problems/total-hamming-distance/
public class P0477_TotalHammingDistance
{
    public int TotalHammingDistance(int[] nums)
    {
        var n = nums.Length;
        var bits = new int[31];
        for (var i = 0; i < nums.Length; i++)
        {
            var num = nums[i];
            var idx = 0;
            while (num != 0)
            {
                if (num % 2 != 0) bits[idx]++;

                num /= 2;
                idx++;
            }
        }

        var ans = 0;
        for (var i = 0; i < bits.Length; i++) ans += bits[i] * (n - bits[i]);

        return ans;
    }
}