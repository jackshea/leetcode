namespace LeetCode.Problems.Easy;

/// 找到最高海拔
/// https://leetcode-cn.com/problems/find-the-highest-altitude/
public class P1732_FindTheHighestAltitude
{
    public int LargestAltitude(int[] gain)
    {
        var ans = 0;
        var curr = 0;
        foreach (var g in gain)
        {
            curr += g;
            if (ans < curr) ans = curr;
        }

        return ans;
    }
}