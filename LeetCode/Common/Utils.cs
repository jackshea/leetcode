using System.Collections.Generic;
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
    }
}