namespace LeetCode.Problems.Medium
{
    /// 环绕字符串中唯一的子字符串
    /// https://leetcode-cn.com/problems/unique-substrings-in-wraparound-string/
    public class P0467_UniqueSubstringsInWraparoundString
    {
        public int FindSubstringInWraproundString(string p)
        {
            if (string.IsNullOrEmpty(p))
            {
                return 0;
            }
            int[] end = new int[26]; // 以某字母结尾的子串数
            int len = 1;
            int ans = 1;
            end[p[0] - 'a'] = 1;

            for (int i = 1; i < p.Length; i++)
            {
                if (IsNext(p[i - 1], p[i]))
                {
                    len++;
                }
                else
                {
                    len = 1;
                }

                var index = p[i] - 'a';
                if (len > end[index])
                {
                    ans += len - end[index];
                    end[index] = len;
                }
            }

            return ans;
        }

        public bool IsNext(char a, char b)
        {
            if (a == 'z')
            {
                return b == 'a';
            }

            return b == a + 1;
        }
    }
}