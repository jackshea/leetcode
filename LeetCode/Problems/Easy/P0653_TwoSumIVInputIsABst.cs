using System.Collections.Generic;

namespace LeetCode.Problems.Easy
{
    /// 两数之和 IV - 输入 BST
    /// https://leetcode-cn.com/problems/two-sum-iv-input-is-a-bst/
    public class P0653_TwoSumIVInputIsABst
    {
        private List<int> sorted = new List<int>();

        public bool FindTarget(TreeNode root, int k)
        {
            Traversal(root);
            int left = 0;
            int right = sorted.Count - 1;
            while (left < right)
            {
                var sum = sorted[left] + sorted[right];

                if (sum == k)
                {
                    return true;
                }
                else if (sum < k)
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }

            return false;
        }

        private void Traversal(TreeNode node)
        {
            if (node == null)
            {
                return;
            }

            Traversal(node.left);
            sorted.Add(node.val);
            Traversal(node.right);
        }
    }
}