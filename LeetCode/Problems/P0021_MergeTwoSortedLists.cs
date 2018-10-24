namespace LeetCode.Problems
{
    /// 合并两个有序链表
    /// https://leetcode-cn.com/problems/merge-two-sorted-lists/description/
    public class P0021_MergeTwoSortedLists
    {
        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            ListNode currentNode = null;
            ListNode mergeListHeadNode = null;

            if (l1 == null)
            {
                return l2;
            }

            if (l2 == null)
            {
                return l1;
            }

            while (true)
            {
                if (l1.val <= l2.val)
                {
                    if (currentNode == null)
                    {
                        currentNode = l1;
                        mergeListHeadNode = currentNode;
                    }
                    else
                    {
                        currentNode.next = l1;
                        currentNode = currentNode.next;
                    }

                    l1 = l1.next;

                    if (l1 == null)
                    {
                        currentNode.next = l2;
                        break;
                    }
                }
                else
                {
                    if (currentNode == null)
                    {
                        currentNode = l2;
                        mergeListHeadNode = currentNode;
                    }
                    else
                    {
                        currentNode.next = l2;
                        currentNode = currentNode.next;
                    }

                    l2 = l2.next;

                    if (l2 == null)
                    {
                        currentNode.next = l1;
                        break;
                    }
                }
            }

            return mergeListHeadNode;
        }

    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }
}