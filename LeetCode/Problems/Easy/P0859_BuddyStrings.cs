using System.Collections.Generic;

namespace LeetCode.Problems.Easy;

/// 亲密字符串
/// https://leetcode-cn.com/problems/buddy-strings/
public class P0859_BuddyStrings
{
    public bool BuddyStrings(string A, string B)
    {
        if (A.Length != B.Length) return false;

        int? diffIndex = null;
        var changed = false;

        for (var i = 0; i < A.Length; i++)
            if (A[i] != B[i])
            {
                if (changed) return false;

                if (diffIndex.HasValue)
                {
                    if (A[i] == B[diffIndex.Value] && A[diffIndex.Value] == B[i])
                        changed = true;
                    else
                        return false;
                }
                else
                {
                    diffIndex = i;
                }
            }

        // 字符串相等的情况,必须要有重复字符
        if (!changed)
        {
            var charSet = new HashSet<char>();
            foreach (var c in A)
            {
                if (charSet.Contains(c)) return true;

                charSet.Add(c);
            }
        }

        return changed;
    }
}