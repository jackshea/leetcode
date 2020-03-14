using LeetCode.Common;

namespace LeetCode.Problems.Easy
{
    /// 从根到叶的二进制数之和
    /// https://leetcode-cn.com/problems/sum-of-root-to-leaf-binary-numbers/
    public class P1022_SumOfRootToLeafBinaryNumbers
    {
        private int sum = 0;
        private const int mod = 1000000000 + 9;
        public int SumRootToLeaf(TreeNode root)
        {
            dfs(root, 0);
            return sum;
        }

        private void dfs(TreeNode root, int parent)
        {
            if (root == null)
            {
                return;
            }

            int v = (parent << 1) + root.val;
            v %= mod;

            if (root.left == null && root.right == null)
            {
                sum += v;
                sum %= mod;
            }

            dfs(root.left, v);
            dfs(root.right, v);
        }
    }
}