namespace LeetCode.Problems.Easy
{
    /// 找到小镇的法官
    /// https://leetcode-cn.com/problems/find-the-town-judge/
    public class P0997_FindTheTownJudge
    {
        public int FindJudge(int N, int[][] trust)
        {
            var beTrusted = new int[N + 1];
            var trustOther = new bool[N + 1];
            foreach (var t in trust)
            {
                trustOther[t[0]] = true;
                beTrusted[t[1]]++;
            }

            int ans = -1;
            for (int i = 1; i <= N; i++)
            {
                if (beTrusted[i] == N - 1)
                {
                    ans = i;
                }
            }

            if (ans > 0 && !trustOther[ans])
            {
                return ans;
            }

            return -1;
        }
    }
}