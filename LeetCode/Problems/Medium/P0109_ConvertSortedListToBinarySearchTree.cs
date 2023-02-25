using LeetCode.Common;

namespace LeetCode.Problems.Medium;

/// 有序链表转换二叉搜索树
/// https://leetcode-cn.com/problems/convert-sorted-list-to-binary-search-tree/
public class P0109_ConvertSortedListToBinarySearchTree
{
    private ListNode head;

    public TreeNode SortedListToBST(ListNode head)
    {
        this.head = head;
        var size = 0;
        var cur = head;
        while (cur != null)
        {
            cur = cur.next;
            size++;
        }

        return BuildBST(0, size - 1);
    }

    private TreeNode BuildBST(int left, int right)
    {
        if (left > right) return null;

        var mid = left + (right - left) / 2;
        var subLeftTree = BuildBST(left, mid - 1);
        var root = new TreeNode(head.val);
        root.left = subLeftTree;
        head = head.next;
        root.right = BuildBST(mid + 1, right);
        return root;
    }
}