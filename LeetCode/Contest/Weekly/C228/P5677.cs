namespace LeetCode.Contest.Weekly.C228
{
    /// 统计同构子字符串的数目
    /// https://leetcode-cn.com/contest/weekly-contest-228/problems/count-number-of-homogenous-substrings/
    public class P5677
    {
        public int CountHomogenous(string s)
        {
            int count = 1;
            int sum = 1;

            for (int i = 1; i < s.Length; i++)
            {
                if (s[i] == s[i - 1])
                {
                    count++;
                }
                else
                {
                    count = 1;
                }

                sum += count;
                sum %= 1000_000_007;
            }

            return sum;
        }
    }
}