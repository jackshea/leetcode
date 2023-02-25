using LeetCode.Common;

namespace LeetCode.Problems.Medium;

/// 设计链表
/// https://leetcode-cn.com/problems/design-linked-list/
public class MyLinkedList
{
    private readonly ListNode root;
    private ListNode tailNode;

    /**
     * Initialize your data structure here.
     */
    public MyLinkedList()
    {
        root = new ListNode(-1);
        tailNode = root;
    }

    /**
     * Get the value of the index-th node in the linked list. If the index is invalid, return -1.
     */
    public int Get(int index)
    {
        var cur = root;
        for (var i = 0; i <= index; i++)
        {
            cur = cur.next;
            if (cur == null) return -1;
        }

        return cur.val;
    }

    /**
     * Add a node of value val before the first element of the linked list. After the insertion, the new node will be the first node of the linked list.
     */
    public void AddAtHead(int val)
    {
        var head = root.next;
        root.next = new ListNode(val);
        root.next.next = head;
        if (tailNode == root) tailNode = root.next;
    }

    /**
     * Append a node of value val to the last element of the linked list.
     */
    public void AddAtTail(int val)
    {
        if (tailNode == root)
        {
            tailNode = new ListNode(val);
            root.next = tailNode;
        }
        else
        {
            tailNode.next = new ListNode(val);
            tailNode = tailNode.next;
        }
    }

    /**
     * Add a node of value val before the index-th node in the linked list. If index equals to the length of linked list, the node will be appended to the end of linked list. If index is greater than the length, the node will not be inserted.
     */
    public void AddAtIndex(int index, int val)
    {
        var cur = root;
        for (var i = 0; i < index; i++)
        {
            cur = cur.next;
            if (cur == null) return;
        }

        var next = cur.next;
        cur.next = new ListNode(val);
        cur.next.next = next;
        if (next == null) tailNode = cur.next;
    }

    /**
     * Delete the index-th node in the linked list, if the index is valid.
     */
    public void DeleteAtIndex(int index)
    {
        if (index < 0) return;
        var cur = root;
        for (var i = 0; i < index; i++)
        {
            cur = cur.next;
            if (cur == null) return;
        }

        if (cur.next != null) cur.next = cur.next.next;

        if (cur.next == null) tailNode = cur;
    }
}