using LeetCode.Common;

namespace LeetCode.Problems.Easy
{
    /// 路径总和 III
    /// https://leetcode-cn.com/problems/path-sum-iii/
    public class P0437_PathSumIII
    {
        public int PathSum(TreeNode root, int sum)
        {
            if (root == null)
            {
                return 0;
            }

            return OneSoucePathSum(root, sum) + PathSum(root.left, sum) + PathSum(root.right, sum);
        }

        private int OneSoucePathSum(TreeNode source, int sum)
        {
            if (source == null)
            {
                return 0;
            }

            sum -= source.val;

            return (sum == 0 ? 1 : 0) + OneSoucePathSum(source.left, sum) + OneSoucePathSum(source.right, sum);
        }
    }
}