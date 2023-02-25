using LeetCode.Common;

namespace LeetCode.Problems.Easy;

/// 最小高度树
/// https://leetcode-cn.com/problems/minimum-height-tree-lcci/
public class MST0402
{
    public TreeNode SortedArrayToBST(int[] nums)
    {
        return Build(nums, 0, nums.Length - 1);
    }

    private TreeNode Build(int[] nums, int left, int right)
    {
        if (left > right) return null;

        if (left == right) return new TreeNode(nums[left]);

        var mid = left + (right - left) / 2;
        var root = new TreeNode(nums[mid]);
        root.left = Build(nums, left, mid - 1);
        root.right = Build(nums, mid + 1, right);
        return root;
    }
}