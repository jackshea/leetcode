using System;
using System.Collections.Generic;

namespace LeetCode.Problems.Medium;

/// 优势洗牌
/// https://leetcode-cn.com/problems/advantage-shuffle/
public class P0870_AdvantageShuffle
{
    public int[] AdvantageCount(int[] nums1, int[] nums2)
    {
        var sortedA = (int[])nums1.Clone();
        Array.Sort(sortedA);
        var sortedB = (int[])nums2.Clone();
        Array.Sort(sortedB);

        var assigned = new Dictionary<int, LinkedList<int>>();
        foreach (var b in nums2)
            assigned[b] = new LinkedList<int>();

        var remaining = new LinkedList<int>();

        var j = 0;
        foreach (var a in sortedA)
            if (a > sortedB[j])
                assigned[sortedB[j++]].AddLast(a);
            else
                remaining.AddLast(a);

        var ans = new int[nums2.Length];
        for (var i = 0; i < nums2.Length; ++i)
            if (assigned[nums2[i]].Count > 0)
            {
                ans[i] = assigned[nums2[i]].First.Value;
                assigned[nums2[i]].RemoveFirst();
            }
            else
            {
                ans[i] = remaining.First.Value;
                remaining.RemoveFirst();
            }

        return ans;
    }
}