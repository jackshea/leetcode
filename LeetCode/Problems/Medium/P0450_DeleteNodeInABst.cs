using LeetCode.Common;

namespace LeetCode.Problems.Medium
{
    /// 删除二叉搜索树中的节点
    /// https://leetcode-cn.com/problems/delete-node-in-a-bst/
    public class P0450_DeleteNodeInABst
    {
        public TreeNode DeleteNode(TreeNode root, int key)
        {
            if (root == null)
            {
                return root;
            }

            if (root.val == key)
            {
                if (root.left == null)
                {
                    return root.right;
                }

                if (root.right == null)
                {
                    return root.left;
                }

                TreeNode cur = root.left;
                TreeNode pre = null;
                while (cur.right != null)
                {
                    pre = cur;
                    cur = cur.right;
                }

                if (pre != null)
                {
                    pre.right = cur.left;
                    cur.left = root.left;
                    cur.right = root.right;
                }
                else
                {
                    cur.right = root.right;
                }

                return cur;
            }

            if (key < root.val)
            {
                root.left = DeleteNode(root.left, key);
            }
            else
            {
                root.right = DeleteNode(root.right, key);
            }

            return root;
        }
    }
}