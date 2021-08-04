﻿using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Common
{
    public static class Utils
    {
        public static string ListToString<T>(this IEnumerable<T> list)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("[");
            foreach (var element in list)
            {
                sb.Append(element);
                sb.Append(",");
            }

            sb[sb.Length - 1] = ']';
            return sb.ToString();
        }

        /// 从数组构造链表
        public static ListNode BuildList(int[] nums)
        {
            if (nums == null || nums.Length == 0)
            {
                return null;
            }

            ListNode head = new ListNode(nums[0]);
            ListNode cur = head;
            for (int i = 1; i < nums.Length; i++)
            {
                cur.next = new ListNode(nums[i]);
                cur = cur.next;
            }

            return head;
        }

        public static int[] ListToArray(ListNode head)
        {
            ListNode cur = head;
            List<int> nums = new List<int>();
            while (cur != null)
            {
                nums.Add(cur.val);
                cur = cur.next;
            }

            return nums.ToArray();
        }

        public static ListNode ConnectList(ListNode listA, ListNode listB)
        {
            ListNode last = listA;
            while (last.next != null)
            {
                last = last.next;
            }

            last.next = listB;
            return listA;
        }

        /// 从输入字符串中读取int[][]
        public static int[][] Read2DArray(string input)
        {
            if (input.Length <= 2)
            {
                return new int[0][];
            }

            List<List<int>> ans = new List<List<int>>();
            for (int i = 1; i < input.Length - 1; i++)
            {
                List<int> row = new List<int>();
                int num = 0;
                int sign = 1;
                while (input[i] != ']')
                {
                    if (char.IsDigit(input[i]))
                    {
                        num = num * 10 + (input[i] - '0');
                    }
                    else if (input[i] == ',')
                    {
                        row.Add(num * sign);
                        sign = 1;
                        num = 0;
                    }
                    else if (input[i] == '-')
                    {
                        sign = -1;
                    }

                    i++;
                }

                row.Add(num * sign);
                ans.Add(row);

                while (i < input.Length - 1 && input[i] != ',')
                {
                    i++;
                }
            }

            int[][] res = new int[ans.Count][];
            for (int i = 0; i < res.Length; i++)
            {
                res[i] = ans[i].ToArray();
            }

            return res;
        }

        public static string Write2DArray<T>(IEnumerable<IEnumerable<T>> arrays)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append('[');
            foreach (var array in arrays)
            {
                sb.Append(array.ListToString() + ',');
            }

            sb[sb.Length - 1] = ']';
            return sb.ToString();
        }

        public static TreeNode BuildBinaryTree(int?[] values)
        {
            if (values == null || values.Length == 0 || values[0] == null)
            {
                return null;
            }

            var nodeArray = new List<TreeNode>(values.Length);
            for (int i = 0; i < values.Length; i++)
            {
                var v = values[i];
                if (v.HasValue)
                {
                    nodeArray.Add(new TreeNode(v.Value));
                }
                else
                {
                    nodeArray.Add(null);
                }
            }


            for (int i = 0; i < values.Length / 2; i++)
            {
                if (nodeArray[i] == null)
                {
                    continue;
                }

                int leftIndex = 2 * i + 1;
                if (leftIndex < values.Length)
                {
                    nodeArray[i].left = nodeArray[leftIndex];
                }

                int rightIndex = 2 * i + 2;
                if (rightIndex < values.Length)
                {
                    nodeArray[i].right = nodeArray[rightIndex];
                }
            }

            return nodeArray[0];
        }

        public static IEnumerable<int> Traversal(TreeNode node)
        {
            if (node == null)
            {
                yield break;
            }

            yield return node.val;
            foreach (var sub in Traversal(node.left))
            {
                yield return sub;
            }

            foreach (var sub in Traversal(node.right))
            {
                yield return sub;
            }
        }
    }
}