using LeetCode.Common;

namespace LeetCode.Problems.Easy
{
    /// 面试题 17.12. BiNode
    /// https://leetcode-cn.com/problems/binode-lcci/
    public class MST1712
    {
        public TreeNode ConvertBiNode(TreeNode root)
        {
            if (root == null)
            {
                return null;
            }

            TreeNode left = ConvertBiNode(root.left);
            if (left == null)
            {
                left = root;
            }
            else
            {
                TreeNode cur = left;
                while (cur.right != null)
                {
                    cur = cur.right;
                }

                cur.right = root;
            }

            root.left = null;
            root.right = ConvertBiNode(root.right);
            return left;
        }
    }
}