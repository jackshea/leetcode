namespace LeetCode.Problems.Hard;

/// 正则表达式匹配
/// https://leetcode-cn.com/problems/regular-expression-matching/
public class P0010_RegularExpressionMatching
{
    private bool?[,] memo;
    private string p;
    private string s;

    public bool IsMatch(string s, string p)
    {
        this.s = s;
        this.p = p;
        memo = new bool?[s.Length + 1, p.Length + 1];
        return IsMatch(0, 0);
    }

    private bool IsMatch(int si, int pi)
    {
        if (pi == p.Length) return si == s.Length;

        if (memo[si, pi].HasValue) return memo[si, pi].Value;

        var firstMatch = si < s.Length && (s[si] == p[pi] || p[pi] == '.');

        // 处理*的情况
        if (pi + 1 < p.Length && p[pi + 1] == '*')
            memo[si, pi] = IsMatch(si, pi + 2) // 不匹配
                           || (firstMatch && IsMatch(si + 1, pi)); // 匹配
        else
            memo[si, pi] = firstMatch && IsMatch(si + 1, pi + 1);

        return memo[si, pi].Value;
    }
}