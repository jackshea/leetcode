using System.Collections.Generic;
using LeetCode.Common;

namespace LeetCode.Problems.Medium
{
    /// 寻找重复的子树
    /// https://leetcode-cn.com/problems/find-duplicate-subtrees/
    public class P0652_FindDuplicateSubtrees
    {
        private int idGenerator = 1;
        private List<TreeNode> ans = new List<TreeNode>();
        private Dictionary<string, int> treeIds = new Dictionary<string, int>();
        private Dictionary<string, int> counter = new Dictionary<string, int>();
        public IList<TreeNode> FindDuplicateSubtrees(TreeNode root)
        {
            GetId(root);
            return ans;
        }

        private int GetId(TreeNode node)
        {
            if (node == null)
            {
                return 0;
            }

            string uid = $"{node.val},{GetId(node.left)},{GetId(node.right)}";
            treeIds.TryGetValue(uid, out var id);
            if (id == 0)
            {
                id = idGenerator++;
                treeIds[uid] = id;
            }

            counter.TryGetValue(uid, out var cnt);
            cnt++;
            counter[uid] = cnt;
            if (cnt == 2)
            {
                ans.Add(node);
            }

            return id;
        }
    }
}