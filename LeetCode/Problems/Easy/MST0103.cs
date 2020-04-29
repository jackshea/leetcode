namespace LeetCode.Problems.Easy
{
    /// 面试题 01.03. URL化
    /// https://leetcode-cn.com/problems/string-to-url-lcci/
    public class MST0103
    {
        public string ReplaceSpaces(string S, int length)
        {
            char[] ans = new char[S.Length];
            int i = 0;
            for (var index = 0; index < length; index++)
            {
                char c = S[index];
                if (c == ' ')
                {
                    ans[i++] = '%';
                    ans[i++] = '2';
                    ans[i++] = '0';
                }
                else
                {
                    ans[i++] = c;
                }
            }

            return new string(ans, 0, i);
        }
    }
}