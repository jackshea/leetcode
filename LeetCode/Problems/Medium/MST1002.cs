using System.Collections.Generic;

namespace LeetCode.Problems.Medium;

/// 变位词组
/// https://leetcode-cn.com/problems/group-anagrams-lcci/
public class MST1002
{
    public IList<IList<string>> GroupAnagrams(string[] strs)
    {
        IList<IList<string>> ans = new List<IList<string>>();
        foreach (var str in strs)
        {
            var isExistKey = false;
            foreach (var list in ans)
                if (IsEqual(list[0], str))
                {
                    isExistKey = true;
                    list.Add(str);
                }

            if (!isExistKey) ans.Add(new List<string> { str });
        }

        return ans;
    }

    private int[] CharCounts(string s)
    {
        var ans = new int[26];
        foreach (var c in s) ans[c - 'a']++;
        return ans;
    }

    private bool IsEqual(string strA, string strB)
    {
        if (strA.Length != strB.Length) return false;

        var a = CharCounts(strA);
        var b = CharCounts(strB);
        for (var i = 0; i < a.Length; i++)
            if (a[i] != b[i])
                return false;

        return true;
    }
}