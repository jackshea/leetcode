namespace LeetCode.Problems
{
    /// 递增顺序查找树
    /// https://leetcode-cn.com/problems/increasing-order-search-tree/
    public class P0897_IncreasingOrderSearchTree
    {
        private TreeNode head;
        private TreeNode current;
        public TreeNode IncreasingBST(TreeNode root)
        {
            Traversal(root);
            return head;
        }

        public void Traversal(TreeNode node)
        {
            if (node == null)
            {
                return;
            }

            Traversal(node.left);

            if (head == null)
            {
                head = new TreeNode(node.val);
                current = head;
            }
            else
            {
                current.right = new TreeNode(node.val);
                current = current.right;
            }

            Traversal(node.right);
        }
    }
}