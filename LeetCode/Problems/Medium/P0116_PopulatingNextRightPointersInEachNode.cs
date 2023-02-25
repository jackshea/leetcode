namespace LeetCode.Problems.Medium;

/// 填充每个节点的下一个右侧节点指针
/// https://leetcode-cn.com/problems/populating-next-right-pointers-in-each-node/
public class P0116_PopulatingNextRightPointersInEachNode
{
    public Node Connect(Node root)
    {
        if (root == null || root.left == null || root.right == null) return root;

        root.left.next = root.right;
        if (root.next != null) root.right.next = root.next.left;

        Connect(root.left);
        Connect(root.right);
        return root;
    }

    public class Node
    {
        public Node left;
        public Node next;
        public Node right;
        public int val;

        public Node()
        {
        }

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