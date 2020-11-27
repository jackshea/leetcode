using LeetCode.Common;

namespace LeetCode.Problems.Easy
{
    /// 找树左下角的值
    /// https://leetcode-cn.com/problems/find-bottom-left-tree-value/
    public class P0513_FindBottomLeftTreeValue
    {
        private int leftValue;
        private int maxDepth = -1;
        public int FindBottomLeftValue(TreeNode root)
        {
            DFS(root, 0);
            return leftValue;
        }

        private void DFS(TreeNode root, int depth)
        {
            if (root == null)
            {
                return;
            }

            if (maxDepth < depth)
            {
                leftValue = root.val;
                maxDepth = depth;
            }
            DFS(root.left, depth + 1);
            DFS(root.right, depth + 1);
        }
    }
}