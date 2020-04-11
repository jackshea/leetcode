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

    // 递推方式
    public class P0044_WildcardMatching_1
    {
        public bool IsMatch(string s, string p)
        {
            if (s == p || p == "*")
            {
                return true;
            }

            if (s == "" || p == "")
            {
                return false;
            }

            bool[,] dp = new bool[s.Length + 1, p.Length + 1];

            // 基本情况
            for (int i = 0; i < s.Length + 1; i++)
            {
                dp[i, p.Length] = p[p.Length - 1] == '*';
            }

            for (int i = p.Length - 1; i >= 0; i--)
            {
                if (p[i] == '*')
                {
                    dp[s.Length, i] = true;
                }
                else
                {
                    break;
                }
            }

            dp[s.Length, p.Length] = true;

            // 状态转移。从下到上，从右到左，终点是 dp[0,0]
            for (int i = s.Length - 1; i >= 0; i--)
            {
                for (int j = p.Length - 1; j >= 0; j--)
                {
                    // 当前字符是否匹配
                    bool currentMatch = s[i] == p[j] || p[j] == '?' || p[j] == '*';

                    bool isMatch = false;
                    // 处理*的情况
                    if (p[j] == '*')
                    {
                        isMatch = dp[i, j + 1] || dp[i + 1, j];
                    }
                    else
                    {
                        isMatch = currentMatch && dp[i + 1, j + 1];
                    }

                    dp[i, j] = isMatch;
                }
            }

            return dp[0, 0];
        }
    }
}