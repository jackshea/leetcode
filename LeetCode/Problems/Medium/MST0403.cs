using LeetCode.Common;
using System.Collections.Generic;

namespace LeetCode.Problems.Medium
{
    /// 特定深度节点链表
    /// https://leetcode-cn.com/problems/list-of-depth-lcci/
    public class MST0403
    {
        public ListNode[] ListOfDepth(TreeNode tree)
        {
            List<ListNode> ans = new List<ListNode>();
            Queue<TreeNode> q = new Queue<TreeNode>();
            q.Enqueue(tree);
            while (q.Count != 0)
            {
                int count = q.Count;
                ListNode row = new ListNode(-1);
                ListNode cur = row;
                for (int i = 0; i < count; i++)
                {
                    var top = q.Dequeue();
                    if (top.left != null)
                    {
                        q.Enqueue(top.left);
                    }

                    if (top.right != null)
                    {
                        q.Enqueue(top.right);
                    }

                    cur.next = new ListNode(top.val);
                    cur = cur.next;
                }
                ans.Add(row.next);
            }

            return ans.ToArray();
        }
    }
}