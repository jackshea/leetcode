using System.Collections.Generic;
using LeetCode.Common;

namespace LeetCode.Problems.Medium
{
    /// 填充每个节点的下一个右侧节点指针 II
    /// https://leetcode-cn.com/problems/populating-next-right-pointers-in-each-node-ii/
    public class P0117_PopulatingNextRightPointersInEachNodeII
    {
        public Node Connect(Node root)
        {
            if (root == null)
            {
                return null;
            }

            Queue<Node> q = new Queue<Node>();
            q.Enqueue(root);
            while (q.Count > 0)
            {
                Node next = null;
                int count = q.Count;
                for (int i = 0; i < count; i++)
                {
                    var top = q.Dequeue();
                    top.next = next;
                    next = top;

                    if (top.right != null)
                    {
                        q.Enqueue(top.right);
                    }
                    if (top.left != null)
                    {
                        q.Enqueue(top.left);
                    }
                }
            }

            return root;
        }

        public class Node
        {
            public int val;
            public Node left;
            public Node right;
            public Node next;

            public Node() { }

            public Node(int _val)
            {
                val = _val;
            }

            public Node(int _val, Node _left, Node _right, Node _next)
            {
                val = _val;
                left = _left;
                right = _right;
                next = _next;
            }
        }
    }
}