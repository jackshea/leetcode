namespace LeetCode.Problems
{
    /// 移除链表元素
    /// https://leetcode-cn.com/problems/remove-linked-list-elements/
    public class P0203_RemoveLinkedListElements
    {
        public ListNode RemoveElements(ListNode head, int val)
        {
            while (head != null && head.val == val)
            {
                head = head.next;
            }

            ListNode currentNode = head;

            while (currentNode != null)
            {
                if (currentNode.next != null && currentNode.next.val == val)
                {
                    currentNode.next = currentNode.next.next;
                }
                else
                {
                    currentNode = currentNode.next;
                }
            }

            return head;
        }
    }
}