using LeetCode.Common;

namespace LeetCode.Problems.Easy;

/// 二叉搜索树的范围和
/// https://leetcode-cn.com/problems/range-sum-of-bst/
public class P0938_RangeSumOfBst
{
    public int RangeSumBST(TreeNode root, int L, int R)
    {
        if (root == null) return 0;

        if (root.val < L)
            return RangeSumBST(root.right, L, R);
        if (root.val > R) return RangeSumBST(root.left, L, R);

        return root.val + RangeSumBST(root.left, L, R) + RangeSumBST(root.right, L, R);
    }
}