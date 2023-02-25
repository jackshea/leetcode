using System;
using System.Collections.Generic;
using LeetCode.Common;

namespace LeetCode.Problems.Easy;

/// 二叉搜索树中的众数
/// https://leetcode-cn.com/problems/find-mode-in-binary-search-tree/
public class P0501_FindModeInBinarySearchTree
{
    private readonly List<int> ans = new();
    private int currentTimes;
    private int maxTimes;
    private TreeNode pre;

    public int[] FindMode(TreeNode root)
    {
        Inorder(root);
        return ans.ToArray();
    }

    private void Inorder(TreeNode root)
    {
        if (root == null) return;
        Inorder(root.left);

        if (pre == null)
        {
            pre = root;
            currentTimes = 1;
            maxTimes = 1;
            ans.Add(pre.val);
        }
        else
        {
            if (pre.val == root.val)
            {
                currentTimes++;
            }
            else
            {
                currentTimes = 1;
                pre = root;
            }

            if (currentTimes == maxTimes)
            {
                ans.Add(root.val);
            }
            else if (currentTimes > maxTimes)
            {
                maxTimes = currentTimes;
                ans.Clear();
                ans.Add(root.val);
            }

            maxTimes = Math.Max(maxTimes, currentTimes);
        }

        Inorder(root.right);
    }
}