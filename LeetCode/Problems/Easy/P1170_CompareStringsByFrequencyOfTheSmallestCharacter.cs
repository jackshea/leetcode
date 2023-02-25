namespace LeetCode.Problems.Easy;

/// 比较字符串最小字母出现频次
/// https://leetcode-cn.com/problems/compare-strings-by-frequency-of-the-smallest-character/
public class P1170_CompareStringsByFrequencyOfTheSmallestCharacter
{
    public int[] NumSmallerByFrequency(string[] queries, string[] words)
    {
        var fq = new int[queries.Length];
        for (var i = 0; i < queries.Length; i++) fq[i] = f(queries[i]);

        var fw = new int[words.Length];
        for (var i = 0; i < words.Length; i++) fw[i] = f(words[i]);

        var ans = new int[queries.Length];
        for (var i = 0; i < ans.Length; i++)
        {
            var count = 0;
            for (var j = 0; j < fw.Length; j++)
                if (fq[i] < fw[j])
                    count++;

            ans[i] = count;
        }

        return ans;
    }

    private int f(string word)
    {
        var count = new int[26];
        foreach (var c in word) count[c - 'a']++;

        for (var i = 0; i < 26; i++)
            if (count[i] != 0)
                return count[i];

        return 0;
    }
}