using LeetCode.Common;
using System.Collections.Generic;

namespace LeetCode.Problems.Hard
{
    /// 从先序遍历还原二叉树
    /// https://leetcode-cn.com/problems/recover-a-tree-from-preorder-traversal/
    public class P1028_RecoverATreeFromPreorderTraversal
    {
        public TreeNode RecoverFromPreorder(string S)
        {
            TreeNode root = null;
            int i = 0;
            Stack<int> depthStack = new Stack<int>();
            Stack<TreeNode> nodeStack = new Stack<TreeNode>();

            while (i < S.Length)
            {
                int depth = 0;
                while (S[i] == '-')
                {
                    depth++;
                    i++;
                }

                int v = 0;
                while (i < S.Length && char.IsDigit(S[i]))
                {
                    v = v * 10 + (S[i] - '0');
                    i++;
                }

                if (root == null)
                {
                    root = new TreeNode(v);
                    depthStack.Push(0);
                    nodeStack.Push(root);
                }
                else
                {
                    var cur = new TreeNode(v);
                    if (depthStack.Peek() == depth - 1)
                    {
                        nodeStack.Peek().left = cur;
                        nodeStack.Push(cur);
                        depthStack.Push(depth);
                    }
                    else
                    {
                        while (depthStack.Peek() >= depth)
                        {
                            depthStack.Pop();
                            nodeStack.Pop();
                        }

                        nodeStack.Peek().right = cur;
                        nodeStack.Push(cur);
                        depthStack.Push(depth);
                    }
                }
            }

            return root;
        }
    }
}