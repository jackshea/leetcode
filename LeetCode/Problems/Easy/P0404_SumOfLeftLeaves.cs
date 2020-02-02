namespace LeetCode.Problems.Easy
{
    /// 左叶子之和
    /// https://leetcode-cn.com/problems/sum-of-left-leaves/
    public class P0404_SumOfLeftLeaves
    {
        public int SumOfLeftLeaves(TreeNode root)
        {
            return TravelSum(root, false);
        }

        private bool IsLeaf(TreeNode node)
        {
            return node != null && node.left == null && node.right == null;
        }

        private int TravelSum(TreeNode node, bool isLeftSubTree)
        {
            if (node == null)
            {
                return 0;
            }

            if (IsLeaf(node) && isLeftSubTree)
            {
                return node.val;
            }

            return TravelSum(node.left, true) + TravelSum(node.right, false);
        }
    }
}