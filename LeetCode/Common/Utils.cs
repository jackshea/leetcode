using System.Collections.Generic;
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
            bool isFirst = true;
            foreach (var element in list)
            {
                if (!isFirst)
                {
                    sb.Append(", ");
                }

                isFirst = false;
                sb.Append(element);
            }

            sb.Append("]");
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
                while (input[i] != ']')
                {
                    if (char.IsDigit(input[i]))
                    {
                        num = num * 10 + (input[i] - '0');
                    }
                    else if (input[i] == ',')
                    {
                        row.Add(num);
                        num = 0;
                    }

                    i++;
                }

                row.Add(num);
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
    }
}