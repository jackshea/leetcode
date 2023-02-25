using LeetCode.Common;

namespace LeetCode.Problems.Medium;

/// 求根到叶子节点数字之和
/// https://leetcode-cn.com/problems/sum-root-to-leaf-numbers/
public class P0129_SumRootToLeafNumbers
{
    private int ans;

    public int SumNumbers(TreeNode root)
    {
        Preorder(root);
        return ans;
    }

    private void Preorder(TreeNode root)
    {
        if (root == null) return;

        if ((root.left == null) & (root.right == null))
        {
            ans += root.val;
            return;
        }

        if (root.left != null)
        {
            root.left.val += root.val * 10;
            Preorder(root.left);
        }

        if (root.right != null)
        {
            root.right.val += root.val * 10;
            Preorder(root.right);
        }
    }
}