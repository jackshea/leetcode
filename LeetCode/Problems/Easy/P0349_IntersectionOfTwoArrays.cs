using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Problems.Easy
{
    /// 两个数组的交集
    /// https://leetcode-cn.com/problems/intersection-of-two-arrays/
    public class P0349_IntersectionOfTwoArrays
    {
        public int[] Intersection(int[] nums1, int[] nums2)
        {
            Array.Sort(nums1);
            Array.Sort(nums2);
            int i = 0;
            int j = 0;
            HashSet<int> intersect = new HashSet<int>();
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