using System.Collections.Generic;
using LeetCode.Common;

namespace LeetCode.Problems.Medium
{
    /// 不同的二叉搜索树 II
    /// https://leetcode-cn.com/problems/unique-binary-search-trees-ii/
    public class P0095_UniqueBinarySearchTreesII
    {
        public IList<TreeNode> GenerateTrees(int n)
        {
            if (n <= 0)
            {
                return new List<TreeNode>();
            }

            return GenerateTrees(1, n);
        }

        private IList<TreeNode> GenerateTrees(int min, int max)
        {
            List<TreeNode> ans = new List<TreeNode>();
            if (min > max)
            {
                ans.Add(null);
                return ans;
            }

            for (int i = min; i <= max; i++)
            {
                var subLeftTree = GenerateTrees(min, i - 1);
                var subRightTree = GenerateTrees(i + 1, max);
                foreach (var left in subLeftTree)
                {
                    foreach (var right in subRightTree)
                    {
                        var root = new TreeNode(i);
                        root.left = left;
                        root.right = right;
                        ans.Add(root);
                    }
                }
            }

            return ans;
        }
    }
}