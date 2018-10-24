using System.Collections.Generic;
using LeetCode.Problems;

namespace LeetCode.Tools
{
    public static class ConvertArrayToBinaryTree
    {
        public static TreeNode Build(int?[] values)
        {
            if (values == null || values.Length == 0 || values[0] == null)
            {
                return null;
            }

            TreeNode root = new TreeNode(values[0].Value);

            List<TreeNode> nodeList = new List<TreeNode>(values.Length);
            nodeList.Add(root);

            for (int i = 1; i < values.Length; i++)
            {
                if (!values[i].HasValue)
                {
                    nodeList.Add(null);
                    continue;
                }

                var node = new TreeNode(values[i].Value);
                var parentNode = nodeList[(i - 1) / 2];
                if (i % 2 == 1)
                {
                    parentNode.left = node;
                }
                else
                {
                    parentNode.right = node;
                }

                nodeList.Add(node);
            }

            return root;
        }
    }
}