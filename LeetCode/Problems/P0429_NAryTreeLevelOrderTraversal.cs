using System.Collections.Generic;

namespace LeetCode.Problems
{
    /// N叉树的层序遍历
    /// https://leetcode-cn.com/problems/n-ary-tree-level-order-traversal/comments/
    public class P0429_NAryTreeLevelOrderTraversal
    {
        public IList<IList<int>> LevelOrder(Node root)
        {
            IList<IList<int>> result = new List<IList<int>>();
            if (root == null)
                return result;

            IList<Node> currentDeepNodes = new List<Node> { root };
            while (currentDeepNodes.Count > 0)
            {
                IList<int> rowResult = new List<int>();
                var nextDeepNodes = new List<Node>();
                foreach (var node in currentDeepNodes)
                {
                    rowResult.Add(node.val);
                    if (node.children != null && node.children.Count > 0)
                    {
                        nextDeepNodes.AddRange(node.children);
                    }
                }
                result.Add(rowResult);
                currentDeepNodes = nextDeepNodes;
            }

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