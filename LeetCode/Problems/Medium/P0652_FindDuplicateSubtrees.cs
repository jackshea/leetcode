using System.Collections.Generic;
using LeetCode.Common;

namespace LeetCode.Problems.Medium;

/// 寻找重复的子树
/// https://leetcode-cn.com/problems/find-duplicate-subtrees/
public class P0652_FindDuplicateSubtrees
{
    private readonly List<TreeNode> ans = new();
    private readonly Dictionary<string, int> counter = new();
    private readonly Dictionary<string, int> treeIds = new();
    private int idGenerator = 1;

    public IList<TreeNode> FindDuplicateSubtrees(TreeNode root)
    {
        GetId(root);
        return ans;
    }

    private int GetId(TreeNode node)
    {
        if (node == null) return 0;

        var uid = $"{node.val},{GetId(node.left)},{GetId(node.right)}";
        treeIds.TryGetValue(uid, out var id);
        if (id == 0)
        {
            id = idGenerator++;
            treeIds[uid] = id;
        }

        counter.TryGetValue(uid, out var cnt);
        cnt++;
        counter[uid] = cnt;
        if (cnt == 2) ans.Add(node);

        return id;
    }
}