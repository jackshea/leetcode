using LeetCode.Common;

namespace LeetCode.Problems.Medium;

/// 求和路径
/// https://leetcode-cn.com/problems/paths-with-sum-lcci/
public class MST0412
{
    public int PathSum(TreeNode root, int sum)
    {
        if (root == null) return 0;

        return PathSumHelper(root, sum) + PathSum(root.left, sum) + PathSum(root.right, sum);
    }

    private int PathSumHelper(TreeNode root, int sum)
    {
        if (root == null) return 0;

        sum -= root.val;
        return (sum == 0 ? 1 : 0) + PathSumHelper(root.left, sum)
                                  + PathSumHelper(root.right, sum);
    }
}