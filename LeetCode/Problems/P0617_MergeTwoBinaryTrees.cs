namespace LeetCode.Problems
{
    /// 合并二叉树
    /// https://leetcode-cn.com/problems/merge-two-binary-trees/
    public class P0617_MergeTwoBinaryTrees
    {
        public TreeNode MergeTrees(TreeNode t1, TreeNode t2)
        {
            if (t1 == null && t2 == null)
            {
                return null;
            }

            var node = new TreeNode(0);
            if (t1 == null)
            {
                node.val = t2.val;
                node.left = MergeTrees(null, t2.left);
                node.right = MergeTrees(null, t2.right);
            }
            else if (t2 == null)
            {
                node.val = t1.val;
                node.left = MergeTrees(t1.left, null);
                node.right = MergeTrees(t1.right, null);
            }
            else
            {
                node.val = t1.val + t2.val;
                node.left = MergeTrees(t1.left, t2.left);
                node.right = MergeTrees(t1.right, t2.right);
            }

            return node;
        }
    }
}