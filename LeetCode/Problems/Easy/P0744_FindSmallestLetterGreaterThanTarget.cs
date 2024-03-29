﻿namespace LeetCode.Problems.Easy;

/// 寻找比目标字母大的最小字母
/// https://leetcode-cn.com/problems/find-smallest-letter-greater-than-target/
public class P0744_FindSmallestLetterGreaterThanTarget
{
    public char NextGreatestLetter(char[] letters, char target)
    {
        if (target < letters[0] || target >= letters[letters.Length - 1]) return letters[0];

        var left = 0;
        var right = letters.Length;
        while (left < right)
        {
            var mid = (left + right) / 2;
            if (letters[mid] <= target)
                left = mid + 1;
            else
                right = mid;
        }

        return letters[left];
    }
}