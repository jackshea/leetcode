using System;
using System.Collections.Generic;

namespace LeetCode.Problems.Easy;

/// 两个数组的交集 II
/// https://leetcode-cn.com/problems/intersection-of-two-arrays-ii/
public class P0350_IntersectionOfTwoArraysII
{
    public int[] Intersect(int[] nums1, int[] nums2)
    {
        Array.Sort(nums1);
        Array.Sort(nums2);
        var i = 0;
        var j = 0;
        var intersect = new List<int>();
        while (i < nums1.Length && j < nums2.Length)
            if (nums1[i] < nums2[j])
            {
                i++;
            }
            else if (nums1[i] > nums2[j])
            {
                j++;
            }
            else
            {
                intersect.Add(nums1[i]);
                i++;
                j++;
            }

        return intersect.ToArray();
    }
}