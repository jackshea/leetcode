using System.Collections.Generic;

namespace LeetCode.Problems.Easy
{
    /// 叶子相似的树
    /// https://leetcode-cn.com/problems/leaf-similar-trees/
    public class P0872_LeafSimilarTrees
    {
        public bool LeafSimilar(TreeNode root1, TreeNode root2)
        {
            var leafs1 = leafs(root1);
            var leafs2 = leafs(root2);

            if (leafs1.Count != leafs2.Count)
            {
                return false;
            }

            for (int i = 0; i < leafs1.Count; i++)
            {
                if (leafs1[i].val != leafs2[i].val)
                {
                    return false;
                }
            }

            return true;
        }

        private List<TreeNode> leafs(TreeNode root)
        {
            if (root == null)
            {
                return null;
            }

            List<TreeNode> result = new List<TreeNode>();

            if (root.left == null && root.right == null)
            {
                result.Add(root);
                return result;
            }

            if (root.left != null)
            {
                result.AddRange(leafs(root.left));
            }

            if (root.right != null)
            {
                result.AddRange(leafs(root.right));
            }

            return result;
        }
    }
}