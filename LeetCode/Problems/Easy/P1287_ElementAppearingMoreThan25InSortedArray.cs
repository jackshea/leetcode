using System;

namespace LeetCode.Problems
{
    /// 有序数组中出现次数超过25%的元素
    /// https://leetcode-cn.com/problems/element-appearing-more-than-25-in-sorted-array/
    public class P1287_ElementAppearingMoreThan25InSortedArray
    {
        public int FindSpecialInteger(int[] arr)
        {
            int step = arr.Length / 4;
            for (int i = 0; i < arr.Length - step; i++)
            {
                if (arr[i] == arr[i + step])
                {
                    return arr[i];
                }
            }

            return -1;
        }
    }
}