using System.Collections.Generic;

namespace LeetCode.Problems
{
    /// 下一个更大元素 I
    /// https://leetcode-cn.com/problems/next-greater-element-i/
    public class P0496_NextGreaterElementI
    {
        public int[] NextGreaterElement(int[] nums1, int[] nums2)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            Stack<int> stack = new Stack<int>();
            foreach (var num in nums2)
            {
                while (stack.Count != 0 && stack.Peek() < num)
                {
                    dic.Add(stack.Pop(), num);
                }
                stack.Push(num);
            }

            int[] result = new int[nums1.Length];
            for (int i = 0; i < nums1.Length; i++)
            {
                if (dic.ContainsKey(nums1[i]))
                {
                    result[i] = dic[nums1[i]];
                }
                else
                {
                    result[i] = -1;
                }
            }

            return result;
        }
    }
}