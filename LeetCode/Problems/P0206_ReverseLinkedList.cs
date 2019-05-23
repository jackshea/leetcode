namespace LeetCode.Problems
{
    public class P0206_ReverseLinkedList
    {
        /// 反转链表
        /// https://leetcode-cn.com/problems/reverse-linked-list/submissions/
        public ListNode ReverseList(ListNode head)
        {
            ListNode curNode = head;
            ListNode preNode = null;
            while (curNode != null)
            {
                var postNode = curNode.next;
                curNode.next = preNode;
                preNode = curNode;
                curNode = postNode;
            }

            return preNode;
        }
    }
}