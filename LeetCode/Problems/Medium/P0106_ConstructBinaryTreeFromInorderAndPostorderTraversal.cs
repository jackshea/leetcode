﻿using System.Collections.Generic;
using LeetCode.Common;

namespace LeetCode.Problems.Medium;

/// 从中序与后序遍历序列构造二叉树
/// https://leetcode-cn.com/problems/construct-binary-tree-from-inorder-and-postorder-traversal/
public class P0106_ConstructBinaryTreeFromInorderAndPostorderTraversal
{
    private readonly Dictionary<int, int> inorderVal2Index = new();
    private int postIndex;
    private int[] postorder;

    public TreeNode BuildTree(int[] inorder, int[] postorder)
    {
        this.postorder = postorder;
        postIndex = postorder.Length - 1;
        for (var i = 0; i < inorder.Length; i++) inorderVal2Index[inorder[i]] = i;

        return BuildTree(0, this.postorder.Length - 1);
    }

    private TreeNode BuildTree(int left, int right)
    {
        if (left > right) return null;

        var rootVal = postorder[postIndex--];
        var root = new TreeNode(rootVal);
        var mid = inorderVal2Index[rootVal];
        root.right = BuildTree(mid + 1, right);
        root.left = BuildTree(left, mid - 1);
        return root;
    }
}