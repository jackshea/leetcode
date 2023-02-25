using System.Collections.Generic;

namespace LeetCode.Problems.Medium;

/// 复制带随机指针的链表
/// https://leetcode-cn.com/problems/copy-list-with-random-pointer/
public class P0138_CopyListWithRandomPointer
{
    private readonly Dictionary<Node, Node> map = new();

    public Node CopyRandomList(Node head)
    {
        if (head == null) return head;


        if (map.ContainsKey(head)) return map[head];

        var node = new Node(head.val);
        map[head] = node;
        node.next = CopyRandomList(head.next);
        node.random = CopyRandomList(head.random);
        return node;
    }

    public class Node
    {
        public Node next;
        public Node random;
        public int val;

        public Node(int _val)
        {
            val = _val;
            next = null;
            random = null;
        }
    }
}