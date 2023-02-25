namespace LeetCode.Problems.Easy;

/// 判断句子是否为全字母句
/// https://leetcode-cn.com/problems/check-if-the-sentence-is-pangram/
public class P1832_CheckIfTheSentenceIsPangram
{
    public bool CheckIfPangram(string sentence)
    {
        var count = 0;
        var freq = new int[26];
        foreach (var c in sentence)
        {
            if (freq[c - 'a'] == 0)
            {
                count++;
                if (count >= 26) return true;
            }

            freq[c - 'a']++;
        }

        return false;
    }
}