namespace LeetCode.Problems.Easy
{
    /// 对称二叉树
    /// https://leetcode-cn.com/problems/symmetric-tree/description/
    public class P0101_SymmetricTree
    {
        public bool IsSymmetric(TreeNode root)
        {
            if (root == null)
            {
                return true;
            }

            return check(root.left, root.right);
        }

        private bool check(TreeNode tn1, TreeNode tn2)
        {
            if (tn1 == null && tn2 == null)
            {
                return true;
            }

            if (tn1 == null || tn2 == null)
            {
                return false;
            }

            if (tn1.val != tn2.val)
            {
                return false;
            }

            return check(tn1.left, tn2.right) && check(tn1.right, tn2.left);
        }
    }
}