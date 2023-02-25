using System;

namespace LeetCode.Problems.Hard;

/// 与数组中元素的最大异或值
/// https://leetcode-cn.com/problems/maximum-xor-with-an-element-from-array/
public class P1707_MaximumXorWithAnElementFromArray
{
    public int[] MaximizeXor(int[] nums, int[][] queries)
    {
        var trie = new Trie();
        foreach (var val in nums) trie.Insert(val);
        var numQ = queries.Length;
        var ans = new int[numQ];
        for (var i = 0; i < numQ; ++i) ans[i] = trie.GetMaxXorWithLimit(queries[i][0], queries[i][1]);
        return ans;
    }
}

internal class Trie
{
    private const int L = 30;
    private readonly Trie[] children = new Trie[2];
    private int min = int.MaxValue;

    public void Insert(int val)
    {
        var node = this;
        node.min = Math.Min(node.min, val);
        for (var i = L - 1; i >= 0; --i)
        {
            var bit = (val >> i) & 1;
            if (node.children[bit] == null) node.children[bit] = new Trie();
            node = node.children[bit];
            node.min = Math.Min(node.min, val);
        }
    }

    public int GetMaxXorWithLimit(int val, int limit)
    {
        var node = this;
        if (node.min > limit) return -1;
        var ans = 0;
        for (var i = L - 1; i >= 0; --i)
        {
            var bit = (val >> i) & 1;
            if (node.children[bit ^ 1] != null && node.children[bit ^ 1].min <= limit)
            {
                ans |= 1 << i;
                bit ^= 1;
            }

            node = node.children[bit];
        }

        return ans;
    }
}