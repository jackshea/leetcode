namespace LeetCode.Problems.Medium;

/// 扁平化多级双向链表
/// https://leetcode-cn.com/problems/flatten-a-multilevel-doubly-linked-list/
public class P0430_FlattenAMultilevelDoublyLinkedList
{
    private Node tail;

    public Node Flatten(Node head)
    {
        if (head == null) return head;

        var cur = head;
        while (cur != null)
        {
            tail = cur;
            if (cur.child != null)
            {
                var next = cur.next;
                var child = Flatten(cur.child);
                cur.next = child;
                child.prev = cur;
                tail.next = next;
                if (next != null) next.prev = tail;
            }

            cur.child = null;
            cur = cur.next;
        }

        return head;
    }

    public class Node
    {
        public Node child;
        public Node next;
        public Node prev;
        public int val;
    }
}