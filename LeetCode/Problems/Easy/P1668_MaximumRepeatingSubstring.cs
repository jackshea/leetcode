namespace LeetCode.Problems.Easy;

/// 最大重复子字符串
/// https://leetcode-cn.com/problems/maximum-repeating-substring/
public class P1668_MaximumRepeatingSubstring
{
    public int MaxRepeating(string sequence, string word)
    {
        var k = 0;
        var sub = word;
        while (sequence.Contains(sub))
        {
            sub += word;
            k++;
        }

        return k;
    }
}