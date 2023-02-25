using LeetCode.Common;

namespace LeetCode.Problems.Easy;

/// 相同的树
/// https://leetcode-cn.com/problems/same-tree/description/
public class P0100_SameTree
{
    public bool IsSameTree(TreeNode p, TreeNode q)
    {
        if (p == null && q == null) return true;

        if (p == null || q == null) return false;

        if (p.val != q.val)
            return false;
        return IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);
    }
}