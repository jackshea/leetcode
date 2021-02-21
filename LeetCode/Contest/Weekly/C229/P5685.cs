namespace LeetCode.Contest.Weekly.C229
{
    /// 交替合并字符串
    /// https://leetcode-cn.com/contest/weekly-contest-229/problems/merge-strings-alternately/
    public class P5685
    {
        public string MergeAlternately(string word1, string word2)
        {
            char[] ans = new char[word1.Length + word2.Length];
            int ansi = 0, w1 = 0, w2 = 0;
            while (ansi < ans.Length)
            {
                if (w1 < word1.Length)
                {
                    ans[ansi++] = word1[w1++];
                }

                if (w2 < word2.Length)
                {
                    ans[ansi++] = word2[w2++];
                }
            }
            return new string(ans);
        }
    }
}