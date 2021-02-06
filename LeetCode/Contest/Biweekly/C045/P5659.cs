namespace LeetCode.Contest.Biweekly.C045
{
    /// 删除字符串两端相同字符后的最短长度
    /// https://leetcode-cn.com/contest/biweekly-contest-45/problems/minimum-length-of-string-after-deleting-similar-ends/
    public class P5659
    {
        public int MinimumLength(string s)
        {
            if (s.Length == 1)
            {
                return 1;
            }
            int left = 0, right = s.Length - 1;
            while (left < right && s[left] == s[right])
            {
                while (left < right && s[left] == s[left + 1])
                {
                    left++;
                }

                if (left == right)
                {
                    return 0;
                }

                left++;

                while (left < right && s[right] == s[right - 1])
                {
                    right--;
                }

                right--;
            }

            return right - left + 1;
        }
    }
}