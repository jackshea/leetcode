namespace LeetCode.Problems.Easy;

public class P1816_TruncateSentence
{
    /// 截断句子
    /// https://leetcode-cn.com/problems/truncate-sentence/
    public string TruncateSentence(string s, int k)
    {
        var i = 0;
        for (; i < s.Length; i++)
        {
            if (s[i] == ' ') k--;

            if (k <= 0) break;
        }

        return s.Substring(0, i);
    }
}