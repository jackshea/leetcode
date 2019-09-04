namespace LeetCode.Problems
{
    /// 删除链表中的节点
    /// https://leetcode-cn.com/problems/delete-node-in-a-linked-list/
    public class P0237_DeleteNodeInALinkedList
    {
        public void DeleteNode(ListNode node)
        {
            node.val = node.next.val;
            node.next = node.next.next;
        }
    }
}