using System;
using System.Collections.Generic;

namespace LeetCode.Problems
{
    /// 数组的相对排序
    /// https://leetcode-cn.com/problems/relative-sort-array/
    public class P1122_RelativeSortArray
    {
        public int[] RelativeSortArray(int[] arr1, int[] arr2)
        {
            var order = new Dictionary<int, int>();
            for (var i = 0; i < arr2.Length; i++)
            {
                order[arr2[i]] = i;
            }

            Array.Sort(arr1, (a, b) =>
            {
                int aOrder = arr2.Length;
                int bOrder = arr2.Length;
                if (!order.TryGetValue(a, out aOrder))
                {
                    aOrder = arr2.Length + 1 + a.CompareTo(b);
                }
                if (!order.TryGetValue(b, out bOrder))
                {
                    bOrder = arr2.Length + 1 - a.CompareTo(b);
                }
                return aOrder.CompareTo(bOrder);
            });

            return arr1;
        }
    }
}