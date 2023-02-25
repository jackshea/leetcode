using System.Collections.Generic;

namespace LeetCode.Problems.Easy;

/// 特殊等价字符串组
/// https://leetcode-cn.com/problems/groups-of-special-equivalent-strings/
public class P0893_GroupsOfSpecialEquivalentStrings
{
    public int NumSpecialEquivGroups(string[] A)
    {
        var countsArray = new List<int[]>();
        foreach (var s in A)
        {
            var counts = Counts(s);
            var exist = false;
            foreach (var ca in countsArray)
                if (IsSame(counts, ca))
                    exist = true;

            if (!exist) countsArray.Add(counts);
        }

        return countsArray.Count;
    }

    public int[] Counts(string s)
    {
        var counts = new int[26 * 2];
        for (var i = 0; i < s.Length; i++)
        {
            var c = s[i];
            counts[c - 'a' + 26 * (i % 2)]++;
        }

        return counts;
    }

    public bool IsSame(int[] a, int[] b)
    {
        if (a.Length != b.Length) return false;

        for (var i = 0; i < a.Length; i++)
            if (a[i] != b[i])
                return false;

        return true;
    }
}