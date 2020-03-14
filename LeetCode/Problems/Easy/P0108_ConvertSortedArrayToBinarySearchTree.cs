using LeetCode.Common;

namespace LeetCode.Problems.Easy
{
    /// 将有序数组转换为二叉搜索树
    /// https://leetcode-cn.com/problems/convert-sorted-array-to-binary-search-tree/description/
    public class P0108_ConvertSortedArrayToBinarySearchTree
    {
        public TreeNode SortedArrayToBST(int[] nums)
        {
            return toBST(nums, 0, nums.Length - 1);
        }

        private TreeNode toBST(int[] nums, int left, int right)
        {
            if (right < left)
            {
                return null;
            }

            int mid = (left + right) / 2;
            var node = new TreeNode(nums[mid]);
            node.left = toBST(nums, left, mid - 1);
            node.right = toBST(nums, mid + 1, right);
            return node;
        }
    }
}