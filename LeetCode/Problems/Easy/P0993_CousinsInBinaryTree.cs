namespace LeetCode.Problems.Easy
{
    /// 二叉树的堂兄弟节点
    /// https://leetcode-cn.com/problems/cousins-in-binary-tree/
    public class P0993_CousinsInBinaryTree
    {
        private int xParent, xDepth;
        private int yParent, yDepth;
        public bool IsCousins(TreeNode root, int x, int y)
        {
            dfs(root.left, 1, root.val, x, y);
            dfs(root.right, 1, root.val, x, y);
            return xDepth == yDepth && xParent != yParent;
        }

        private void dfs(TreeNode root, int depth, int parent, int x, int y)
        {
            if (root == null)
            {
                return;
            }

            if (root.val == x)
            {
                xParent = parent;
                xDepth = depth;
                return;
            }
            if (root.val == y)
            {
                yParent = parent;
                yDepth = depth;
                return;
            }

            dfs(root.left, 1 + depth, root.val, x, y);
            dfs(root.right, 1 + depth, root.val, x, y);
        }
    }
}