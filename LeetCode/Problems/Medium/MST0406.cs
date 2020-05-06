using LeetCode.Common;

namespace LeetCode.Problems.Medium
{
    /// 后继者
    /// https://leetcode-cn.com/problems/successor-lcci/
    public class MST0406
    {
        public TreeNode InorderSuccessor(TreeNode root, TreeNode p)
        {
            if (root == null)
            {
                return null;
            }

            var left = InorderSuccessor(root.left, p);
            if (left != null)
            {
                return left;
            }
            if (root.val > p.val)
            {
                return root;
            }

            return InorderSuccessor(root.right, p);
        }
    }
}