using LeetCode.Common;

namespace LeetCode.Problems.Easy
{
    /// 剑指 Offer 27. 二叉树的镜像
    /// https://leetcode-cn.com/problems/er-cha-shu-de-jing-xiang-lcof/
    public class Offer27
    {
        public TreeNode MirrorTree(TreeNode root)
        {
            if (root == null)
            {
                return null;
            }

            TreeNode temp = root.left;
            root.left = MirrorTree(root.right);
            root.right = MirrorTree(temp);
            return root;
        }
    }
}