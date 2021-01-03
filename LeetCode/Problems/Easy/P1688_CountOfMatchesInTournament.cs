namespace LeetCode.Problems.Easy
{
    /// 比赛中的配对次数
    /// https://leetcode-cn.com/problems/count-of-matches-in-tournament/
    public class P1688_CountOfMatchesInTournament
    {
        public int NumberOfMatches(int n)
        {
            int cnt = 0;
            while (n > 1)
            {
                if (n % 2 == 0)
                {
                    n /= 2;
                    cnt += n;
                }
                else
                {
                    cnt += n / 2;
                    n = n / 2 + 1;
                }
            }

            return cnt;
        }
    }
}