using System.Collections.Generic;

namespace LeetCode.Problems.Easy
{
    /// 路径总和 II
    /// https://leetcode-cn.com/problems/path-sum-ii/description/
    public class P0113_PathSumII
    {
        private IList<IList<int>> result = new List<IList<int>>();
        public IList<IList<int>> PathSum(TreeNode root, int sum)
        {
            Travel(root, sum, new List<int>());
            return result;
        }

        private void Travel(TreeNode node, int sum, IList<int> path)
        {
            if (node == null)
            {
                return;
            }

            if (node.left == null && node.right == null && node.val == sum)
            {
                var newPath = new List<int>(path);
                newPath.Add(sum);
                result.Add(newPath);
                return;
            }

            path.Add(node.val);
            Travel(node.left, sum - node.val, path);
            Travel(node.right, sum - node.val, path);
            path.RemoveAt(path.Count - 1);
        }
    }
}