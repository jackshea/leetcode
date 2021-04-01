namespace LeetCode.Problems.Medium
{
    /// 笨阶乘
    /// https://leetcode-cn.com/problems/clumsy-factorial/
    public class P1006_ClumsyFactorial
    {
        public int Clumsy(int N)
        {
            int ans = 0;
            if (N == 1)
            {
                return 1;
            }
            else if (N == 2)
            {
                return 2;
            }
            else if (N == 3)
            {
                return 6;
            }

            if (N >= 3)
            {
                ans = N * (N - 1) / (N - 2);
            }

            int n = (N - 3) % 4;
            if (n == 0)
            {
                ans -= 2;
            }
            else
            {
                ans++;
            }

            if (N >= 8 && n == 1)
            {
                ans--;
            }

            return ans;
        }
    }
}