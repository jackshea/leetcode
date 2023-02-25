using System.Collections.Generic;
using LeetCode.Common;

namespace LeetCode.Problems.Medium;

/// 二叉搜索树中第K小的元素
/// https://leetcode-cn.com/problems/kth-smallest-element-in-a-bst/
public class P0230_KthSmallestElementInABst
{
    public int KthSmallest(TreeNode root, int k)
    {
        var node = root;
        var stack = new Stack<TreeNode>();
        stack.Push(node);
        while (stack.Count != 0)
        {
            while (node.left != null)
            {
                stack.Push(node.left);
                node = node.left;
            }

            while (stack.Count != 0)
            {
                var top = stack.Pop();
                if (k-- == 1) return top.val;
                if (top.right != null)
                {
                    stack.Push(top.right);
                    node = top.right;
                    break;
                }
            }
        }

        return -1;
    }
}