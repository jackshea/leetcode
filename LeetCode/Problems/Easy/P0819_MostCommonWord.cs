using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Problems.Easy;

/// 最常见的单词
/// https://leetcode-cn.com/problems/most-common-word/
public class P0819_MostCommonWord
{
    private HashSet<string> _bannedSet;
    private StringBuilder _getWord;
    private HashSet<char> _punctuations;
    private Dictionary<string, int> _words;

    public string MostCommonWord(string paragraph, string[] banned)
    {
        _bannedSet = new HashSet<string>();
        foreach (var b in banned) _bannedSet.Add(b);

        _words = new Dictionary<string, int>();
        _getWord = new StringBuilder();
        _punctuations = new HashSet<char>("!?',;. ");

        for (var i = 0; i < paragraph.Length; i++)
        {
            var c = paragraph[i];
            if (_punctuations.Contains(c))
            {
                if (_getWord.Length == 0) continue;

                AddWord();

                _getWord.Clear();
            }
            else
            {
                _getWord.Append(char.ToLower(c));
                if (i == paragraph.Length - 1) AddWord();
            }
        }

        return _words.First(p => p.Value == _words.Values.Max()).Key;
    }

    private void AddWord()
    {
        var word = _getWord.ToString();
        if (!_bannedSet.Contains(word))
        {
            if (_words.ContainsKey(word))
                _words[word]++;
            else
                _words[word] = 1;
        }
    }
}