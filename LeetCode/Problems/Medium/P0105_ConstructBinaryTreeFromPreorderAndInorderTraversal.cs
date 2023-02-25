using System.Collections.Generic;
using LeetCode.Common;

namespace LeetCode.Problems.Medium;

/// 从前序与中序遍历序列构造二叉树
/// https://leetcode-cn.com/problems/construct-binary-tree-from-preorder-and-inorder-traversal/
public class P0105_ConstructBinaryTreeFromPreorderAndInorderTraversal
{
    private readonly Dictionary<int, int> inorderVal2Index = new();
    private int preIndex;
    private int[] preorder;

    public TreeNode BuildTree(int[] preorder, int[] inorder)
    {
        this.preorder = preorder;
        for (var i = 0; i < inorder.Length; i++) inorderVal2Index[inorder[i]] = i;

        return BuildTree(0, preorder.Length - 1);
    }

    private TreeNode BuildTree(int left, int right)
    {
        if (left > right) return null;

        var rootVal = preorder[preIndex++];
        var root = new TreeNode(rootVal);
        var mid = inorderVal2Index[rootVal];
        root.left = BuildTree(left, mid - 1);
        root.right = BuildTree(mid + 1, right);
        return root;
    }
}