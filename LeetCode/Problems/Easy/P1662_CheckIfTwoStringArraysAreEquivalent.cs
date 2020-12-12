namespace LeetCode.Problems.Easy
{
    /// 检查两个字符串数组是否相等
    /// https://leetcode-cn.com/problems/check-if-two-string-arrays-are-equivalent/
    public class P1662_CheckIfTwoStringArraysAreEquivalent
    {
        public bool ArrayStringsAreEqual(string[] word1, string[] word2)
        {
            int w2 = 0, c2 = 0;
            for (int i = 0; i < word1.Length; i++)
            {
                foreach (var c in word1[i])
                {
                    if (w2 >= word2.Length)
                    {
                        return false;
                    }
                    if (c != word2[w2][c2])
                    {
                        return false;
                    }

                    c2++;
                    if (c2 >= word2[w2].Length)
                    {
                        w2++;
                        c2 = 0;
                    }
                }
            }

            return w2 == word2.Length;
        }
    }
}