namespace LeetCode.Problems.Easy
{
    /// 替换隐藏数字得到的最晚时间
    /// https://leetcode-cn.com/problems/latest-time-by-replacing-hidden-digits/
    public class P1736_LatestTimeByReplacingHiddenDigits
    {
        public string MaximumTime(string time)
        {
            var timeChars = time.ToCharArray();
            if (timeChars[0] == '?')
            {
                timeChars[0] = timeChars[1] > '3' && timeChars[1] != '?' ? '1' : '2';
            }

            if (timeChars[1] == '?')
            {
                timeChars[1] = timeChars[0] > '1' && timeChars[0] != '?' ? '3' : '9';
            }

            if (timeChars[3] == '?')
            {
                timeChars[3] = '5';
            }

            if (timeChars[4] == '?')
            {
                timeChars[4] = '9';
            }

            return new string(timeChars);
        }
    }
}