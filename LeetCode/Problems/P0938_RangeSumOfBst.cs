namespace LeetCode.Problems
{
    /// 二叉搜索树的范围和
    /// https://leetcode-cn.com/problems/range-sum-of-bst/
    public class P0938_RangeSumOfBst
    {
        public int RangeSumBST(TreeNode root, int L, int R)
        {
            if (root == null)
            {
                return 0;
            }

            int sum = 0;
            if (root.val >= L && root.val <= R)
            {
                sum += root.val + RangeSumBST(root.left, L, R) + RangeSumBST(root.right, L, R);
            }
            else if (root.val < L)
            {
                sum += RangeSumBST(root.right, L, R);
            }
            else if (root.val > R)
            {
                sum += RangeSumBST(root.left, L, R);
            }

            return sum;
        }
    }
}