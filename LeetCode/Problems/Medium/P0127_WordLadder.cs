﻿using System.Collections.Generic;

namespace LeetCode.Problems.Medium;

/// 单词接龙
/// https://leetcode-cn.com/problems/word-ladder/
public class P0127_WordLadder
{
    public int LadderLength(string beginWord, string endWord, IList<string> wordList)
    {
        var wordSet = new HashSet<string>();
        foreach (var word in wordList) wordSet.Add(word);

        if (!wordSet.Contains(endWord)) return 0;

        var beginSet = new HashSet<string> { beginWord };
        var endSet = new HashSet<string> { endWord };
        var step = 0;
        while (beginSet.Count > 0)
        {
            step++;
            var curSet = new HashSet<string>();
            foreach (var bg in beginSet)
            {
                wordSet.Remove(bg);
                if (endSet.Contains(bg)) return step;
            }

            foreach (var bg in beginSet)
            foreach (var word in wordSet)
                if (IsNext(bg, word))
                    curSet.Add(word);

            if (curSet.Count < endSet.Count)
            {
                beginSet = curSet;
            }
            else
            {
                beginSet = endSet;
                endSet = curSet;
            }
        }

        return 0;
    }

    private bool IsNext(string start, string next)
    {
        var diff = 0;
        for (var i = 0; i < start.Length; i++)
            if (start[i] != next[i])
                diff++;

        return diff == 1;
    }
}