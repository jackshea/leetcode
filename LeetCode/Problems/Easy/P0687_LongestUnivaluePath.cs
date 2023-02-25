using System;
using LeetCode.Common;

namespace LeetCode.Problems.Easy;

/// 最长同值路径
/// https://leetcode-cn.com/problems/longest-univalue-path/
public class P0687_LongestUnivaluePath
{
    private int ans;

    public int LongestUnivaluePath(TreeNode root)
    {
        Length(root);
        return ans;
    }

    private int Length(TreeNode tn)
    {
        if (tn == null) return 0;

        var left = Length(tn.left);
        var right = Length(tn.right);
        if (tn.left != null && tn.left.val == tn.val)
            left++;
        else
            left = 0;

        if (tn.right != null && tn.right.val == tn.val)
            right++;
        else
            right = 0;

        ans = Math.Max(ans, right + left);
        return Math.Max(left, right);
    }
}