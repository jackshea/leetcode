using LeetCode.Common;

namespace LeetCode.Problems.Medium
{
    /// 检查子树
    /// https://leetcode-cn.com/problems/check-subtree-lcci/
    public class MST0410
    {
        public bool CheckSubTree(TreeNode t1, TreeNode t2)
        {
            if (t1 == null)
            {
                return t2 == null;
            }

            return IsSameTree(t1, t2) || CheckSubTree(t1.left, t2) || CheckSubTree(t1.right, t2);
        }

        private bool IsSameTree(TreeNode t1, TreeNode t2)
        {
            if (t1 == null && t2 == null)
            {
                return true;
            }

            return t1 != null && t2 != null && t1.val == t2.val
                   && IsSameTree(t1.left, t2.left) && IsSameTree(t1.right, t2.right);
        }
    }
}