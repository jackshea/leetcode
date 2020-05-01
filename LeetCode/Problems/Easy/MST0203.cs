using LeetCode.Common;

namespace LeetCode.Problems.Easy
{
    /// 删除中间节点
    /// https://leetcode-cn.com/problems/delete-middle-node-lcci/
    public class MST0203
    {
        public void DeleteNode(ListNode node)
        {
            node.val = node.next.val;
            node.next = node.next.next;
        }
    }
}