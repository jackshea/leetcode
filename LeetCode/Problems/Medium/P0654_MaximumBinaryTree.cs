using LeetCode.Common;

namespace LeetCode.Problems.Medium;

/// 最大二叉树
/// https://leetcode-cn.com/problems/maximum-binary-tree/
public class P0654_MaximumBinaryTree
{
    public TreeNode ConstructMaximumBinaryTree(int[] nums)
    {
        return ConstructMaximumBinaryTree(nums, 0, nums.Length - 1);
    }

    public TreeNode ConstructMaximumBinaryTree(int[] nums, int i, int j)
    {
        if (i > j) return null;

        if (i == j) return new TreeNode(nums[i]);

        int max = int.MinValue, maxIdx = i;
        for (var k = i; k <= j; k++)
            if (nums[k] > max)
            {
                max = nums[k];
                maxIdx = k;
            }

        var root = new TreeNode(max);
        root.left = ConstructMaximumBinaryTree(nums, i, maxIdx - 1);
        root.right = ConstructMaximumBinaryTree(nums, maxIdx + 1, j);
        return root;
    }
}