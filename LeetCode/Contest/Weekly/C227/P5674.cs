using System.Text;

namespace LeetCode.Contest.Weekly.C227;

/// 构造字典序最大的合并字符串
/// https://leetcode-cn.com/contest/weekly-contest-227/problems/largest-merge-of-two-strings/
public class P5674
{
    public string LargestMerge(string word1, string word2)
    {
        var sb = new StringBuilder(word1.Length + word2.Length);
        int idx1 = 0, idx2 = 0;
        while (idx1 < word1.Length && idx2 < word2.Length)
            if (CompareString(word1, idx1, word2, idx2) >= 0)
                sb.Append(word1[idx1++]);
            else
                sb.Append(word2[idx2++]);
        if (idx1 == word1.Length)
            sb.Append(word2.Substring(idx2));
        else
            sb.Append(word1.Substring(idx1));

        return sb.ToString();
    }

    public int CompareString(string word1, int idx1, string word2, int idx2)
    {
        if (idx1 == word1.Length && idx2 == word2.Length) return 0;
        if (idx1 >= word1.Length) return -1;
        if (idx2 >= word2.Length) return 1;

        if (word1[idx1] == word2[idx2])
            return CompareString(word1, idx1 + 1, word2, idx2 + 1);
        return word1[idx1].CompareTo(word2[idx2]);
    }
}