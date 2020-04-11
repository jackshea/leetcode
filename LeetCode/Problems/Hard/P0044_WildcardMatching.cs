namespace LeetCode.Problems.Hard
{
    /// 通配符匹配
    /// https://leetcode-cn.com/problems/wildcard-matching/
    public class P0044_WildcardMatching
    {
        private string s;
        private string p;
        private bool?[,] memo;

        public bool IsMatch(string s, string p)
        {
            this.s = s;
            this.p = p;
            memo = new bool?[s.Length + 2, p.Length + 2];
            return IsMatch(0, 0);
        }

        private bool IsMatch(int si, int pi)
        {
            if (pi == p.Length)
            {
                return si == s.Length;
            }

            if (memo[si, pi].HasValue)
            {
                return memo[si, pi].Value;
            }

            var firstMatch = si < s.Length && (s[si] == p[pi] || p[pi] == '?' || p[pi] == '*');

            // 处理*的情况
            if (pi < p.Length && p[pi] == '*')
            {
                memo[si, pi] = IsMatch(si, pi + 1) // 跳过*
                               || firstMatch && IsMatch(si + 1, pi); // 匹配*
            }
            else
            {
                memo[si, pi] = firstMatch && IsMatch(si + 1, pi + 1);
            }

            return memo[si, pi].Value;
        }
    }
}