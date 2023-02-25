using LeetCode.Common;

namespace LeetCode.Problems.Medium;

/// 二叉树展开为链表
/// https://leetcode-cn.com/problems/flatten-binary-tree-to-linked-list/
public class P0114_FlattenBinaryTreeToLinkedList
{
    public void Flatten(TreeNode root)
    {
        while (root != null)
            if (root.left != null)
            {
                var pre = root.left;
                while (pre.right != null) pre = pre.right;

                pre.right = root.right;
                root.right = root.left;
                root.left = null;
            }
            else
            {
                root = root.right;
            }
    }
}