using System.Collections.Generic;

namespace LeetCode.Problems
{
    /// N叉树的后序遍历
    /// https://leetcode-cn.com/problems/n-ary-tree-postorder-traversal/
    public class P0590_NAryTreePostorderTraversal
    {
        private List<int> result = new List<int>();

        public IList<int> Postorder(Node root)
        {
            if (root == null)
            {
                return result;
            }

            foreach (var node in root.children)
            {
                Postorder(node);
            }

            result.Add(root.val);
            return result;
        }

        public class Node
        {
            public int val;
            public IList<Node> children;

            public Node()
            {
            }

            public Node(int _val, IList<Node> _children)
            {
                val = _val;
                children = _children;
            }
        }
    }
}