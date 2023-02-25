using System.Collections.Generic;

namespace LeetCode.Problems.Easy;

/// 键盘行
/// https://leetcode-cn.com/problems/keyboard-row/
public class P0500_KeyboardRow
{
    public string[] FindWords(string[] words)
    {
        string[] chars = { "qwertyuiop", "asdfghjkl", "zxcvbnm" };
        var charValue = new Dictionary<char, int>();
        for (var i = 0; i < chars.Length; i++)
        {
            var s = chars[i];
            foreach (var c in s)
            {
                charValue.Add(c, i + 1);
                charValue.Add(char.ToUpper(c), i + 1);
            }
        }

        var result = new List<string>();
        foreach (var word in words)
        {
            var isMatch = true;
            if (word.Length > 1)
                for (var i = 1; i < word.Length; i++)
                    if (charValue[word[i]] != charValue[word[0]])
                        isMatch = false;
            if (isMatch) result.Add(word);
        }

        return result.ToArray();
    }
}