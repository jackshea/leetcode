using LeetCode.Common;

namespace LeetCode.Problems.Easy;

/// 计算布尔二叉树的值
/// https://leetcode.cn/problems/evaluate-boolean-binary-tree/
public class P2331_EvaluateBooleanBinaryTree
{
    public bool EvaluateTree(TreeNode root)
    {
        if (root == null) return false;

        switch (root.val)
        {
            case 0:
                return false;
            case 1:
                return true;
            case 2:
                return EvaluateTree(root.left) || EvaluateTree(root.right);
            case 3:
                return EvaluateTree(root.left) && EvaluateTree(root.right);
        }

        return false;
    }
}