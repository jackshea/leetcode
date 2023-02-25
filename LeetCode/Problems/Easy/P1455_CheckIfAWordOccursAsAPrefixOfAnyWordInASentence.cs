namespace LeetCode.Problems.Easy;

/// 检查单词是否为句中其他单词的前缀
/// https://leetcode-cn.com/problems/check-if-a-word-occurs-as-a-prefix-of-any-word-in-a-sentence/
public class P1455_CheckIfAWordOccursAsAPrefixOfAnyWordInASentence
{
    public int IsPrefixOfWord(string sentence, string searchWord)
    {
        var ans = -1;
        var words = sentence.Split(new[] { ' ' });
        for (var i = 0; i < words.Length; i++)
            if (words[i].StartsWith(searchWord))
            {
                ans = i + 1;
                break;
            }

        return ans;
    }
}