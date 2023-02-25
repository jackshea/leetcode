using System.Collections.Generic;

namespace LeetCode.Problems.Medium;

/// 二叉树寻路
/// https://leetcode-cn.com/problems/path-in-zigzag-labelled-binary-tree/
public class P1104_PathInZigzagLabelledBinaryTree
{
    public IList<int> PathInZigZagTree(int label)
    {
        IList<int> ans = new List<int>();
        var labelLen = BitLength(label);
        while (label > 1)
        {
            ans.Add(label);
            label >>= 1;
            labelLen--;
            label = label ^ ((1 << (labelLen - 1)) - 1);
        }

        ans.Add(1);
        Reverse(ans, 0, ans.Count - 1);
        return ans;
    }

    private int BitLength(int n)
    {
        var ans = 1;
        while (n > 1)
        {
            n >>= 1;
            ans++;
        }

        return ans;
    }

    private void Reverse(IList<int> list, int start, int end)
    {
        while (start < end)
        {
            var temp = list[start];
            list[start] = list[end];
            list[end] = temp;
            start++;
            end--;
        }
    }
}