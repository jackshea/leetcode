using LeetCode.Common;

namespace LeetCode.Problems.Easy
{
    /// 剑指 Offer 54. 二叉搜索树的第k大节点
    /// https://leetcode-cn.com/problems/er-cha-sou-suo-shu-de-di-kda-jie-dian-lcof/
    public class Offer54
    {
        private int ans = 0;
        private int count = 0;
        private bool isEnd = false;
        public int KthLargest(TreeNode root, int k)
        {
            DFS(root, k);
            return ans;
        }

        private void DFS(TreeNode root, int k)
        {
            if (root == null || isEnd)
            {
                return;
            }
            DFS(root.right, k);
            count++;
            if (count == k)
            {
                ans = root.val;
                isEnd = true;
            }
            DFS(root.left, k);
        }
    }
}