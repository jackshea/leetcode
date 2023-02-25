namespace LeetCode.Problems.Easy;

/// 统计星号
/// https://leetcode.cn/problems/count-asterisks/
public class P2315_CountAsterisks
{
    public int CountAsterisks(string s)
    {
        var ans = 0;
        var external = true;
        foreach (var c in s)
        {
            if (c == '|') external = !external;

            if (external && c == '*') ans++;
        }

        return ans;
    }
}