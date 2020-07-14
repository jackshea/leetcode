using System;

namespace LeetCode.Problems.Easy
{
    /// 通过翻转子数组使两个数组相等
    /// https://leetcode-cn.com/problems/make-two-arrays-equal-by-reversing-sub-arrays/
    public class P1460_MakeTwoArraysEqualByReversingSubArrays
    {
        public bool CanBeEqual(int[] target, int[] arr)
        {
            Array.Sort(target);
            Array.Sort(arr);
            for (int i = 0; i < target.Length; i++)
            {
                if (target[i] != arr[i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}