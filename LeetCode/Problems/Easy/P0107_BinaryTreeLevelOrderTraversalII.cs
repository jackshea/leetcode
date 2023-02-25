using System.Collections.Generic;
using LeetCode.Common;

namespace LeetCode.Problems.Easy;

/// 二叉树的层次遍历
/// https://leetcode-cn.com/problems/binary-tree-level-order-traversal-ii/description/
public class P0107_BinaryTreeLevelOrderTraversalII
{
    private IList<IList<int>> nodes;

    public IList<IList<int>> LevelOrderBottom(TreeNode root)
    {
        nodes = new List<IList<int>>();
        Travel(root, 0);
        return nodes;
    }

    private void Travel(TreeNode node, int level)
    {
        if (node == null) return;

        if (nodes.Count <= level) nodes.Insert(0, new List<int>());
        Travel(node.left, level + 1);
        Travel(node.right, level + 1);
        nodes[nodes.Count - 1 - level].Add(node.val);
    }
}