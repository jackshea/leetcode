namespace LeetCode.Problems.Easy
{
    /// 路径总和
    /// https://leetcode-cn.com/problems/path-sum/description/
    public class P0112_PathSum
    {
        public bool HasPathSum(TreeNode root, int sum)
        {
            if (root == null)
            {
                return false;
            }

            if (root.left == null && root.right == null && root.val == sum)
            {
                return true;
            }

            return HasPathSum(root.left, sum - root.val) || HasPathSum(root.right, sum - root.val);
        }
    }
}