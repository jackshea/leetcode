using System;

namespace LeetCode.Problems
{
    public class P0783_MinimumDistanceBetweenBstNodes
    {
        private int minDist = Int32.MaxValue;
        private TreeNode preNode;

        public int MinDiffInBST(TreeNode root)
        {
            Traveral(root);
            return minDist;
        }

        private void Traveral(TreeNode node)
        {
            if (node == null)
            {
                return;
            }

            Traveral(node.left);
            if (preNode != null)
            {
                minDist = Math.Min(minDist, node.val - preNode.val);
            }

            preNode = node;
            Traveral(node.right);
        }
    }
}