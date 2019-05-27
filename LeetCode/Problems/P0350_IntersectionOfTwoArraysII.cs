﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Problems
{
    /// 两个数组的交集 II
    /// https://leetcode-cn.com/problems/intersection-of-two-arrays-ii/
    public class P0350_IntersectionOfTwoArraysII
    {
        public int[] Intersect(int[] nums1, int[] nums2)
        {
            Array.Sort(nums1);
            Array.Sort(nums2);
            int i = 0;
            int j = 0;
            List<int> intersect = new List<int>();
            while (i < nums1.Length && j < nums2.Length)
            {
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
            }

            return intersect.ToArray();
        }
    }
}