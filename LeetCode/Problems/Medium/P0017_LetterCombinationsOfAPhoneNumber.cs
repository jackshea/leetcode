using System.Collections.Generic;

namespace LeetCode.Problems.Medium;

/// 电话号码的字母组合
/// https://leetcode-cn.com/problems/letter-combinations-of-a-phone-number/
public class P0017_LetterCombinationsOfAPhoneNumber
{
    private readonly Dictionary<char, char[]> numToChar = new()
    {
        { '2', new[] { 'a', 'b', 'c' } },
        { '3', new[] { 'd', 'e', 'f' } },
        { '4', new[] { 'g', 'h', 'i' } },
        { '5', new[] { 'j', 'k', 'l' } },
        { '6', new[] { 'm', 'n', 'o' } },
        { '7', new[] { 'p', 'q', 'r', 's' } },
        { '8', new[] { 't', 'u', 'v' } },
        { '9', new[] { 'w', 'x', 'y', 'z' } }
    };

    public IList<string> LetterCombinations(string digits)
    {
        if (string.IsNullOrEmpty(digits)) return new List<string>();

        var tempAns = new List<char[]>();
        tempAns.Add(new char[digits.Length]);
        for (var i = 0; i < digits.Length; i++)
        {
            var d = digits[i];
            var chars = numToChar[d];
            var lastLen = tempAns.Count;
            for (var j = 1; j < chars.Length; j++)
            for (var k = 0; k < lastLen; k++)
            {
                var newChars = new char[digits.Length];
                for (var l = 0; l < digits.Length; l++) newChars[l] = tempAns[k][l];
                tempAns.Add(newChars);
            }

            for (var j = 0; j < chars.Length; j++)
            for (var k = 0; k < lastLen; k++)
                tempAns[j * lastLen + k][i] = chars[j];
        }

        var ans = new List<string>();
        foreach (var s in tempAns) ans.Add(new string(s));
        return ans;
    }
}