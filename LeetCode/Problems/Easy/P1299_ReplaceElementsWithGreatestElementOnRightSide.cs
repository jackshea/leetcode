using System;

namespace LeetCode.Problems
{
    /// 将每个元素替换为右侧最大元素
    /// https://leetcode-cn.com/problems/replace-elements-with-greatest-element-on-right-side/
    public class P1299_ReplaceElementsWithGreatestElementOnRightSide
    {
        public int[] ReplaceElements(int[] arr)
        {
            int max = arr[arr.Length - 1];
            for (int i = arr.Length - 2; i >= 0; i--)
            {
                if (arr[i] < max)
                {
                    arr[i] = max;
                }
                else
                {
                    int temp = arr[i];
                    arr[i] = max;
                    max = temp;
                }
            }
            arr[arr.Length - 1] = -1;
            return arr;
        }
    }
}