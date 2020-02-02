namespace LeetCode.Problems.Easy
{
    /// 另一个树的子树
    /// https://leetcode-cn.com/problems/subtree-of-another-tree/
    public class P0572_SubtreeOfAnotherTree
    {
        public bool IsSubtree(TreeNode s, TreeNode t)
        {
            if (s == null)
            {
                return t == null;
            }

            return IsSameTree(s, t) || IsSubtree(s.left, t) || IsSubtree(s.right, t);
        }

        private bool IsSameTree(TreeNode s, TreeNode t)
        {
            if (s == null && t == null)
            {
                return true;
            }

            return s != null && t != null && s.val == t.val && IsSameTree(s.left, t.left) && IsSameTree(s.right, t.right);
        }
    }
}