namespace LeetCode.Problems.Medium;

/// 键值映射
/// https://leetcode-cn.com/problems/map-sum-pairs/
public class MapSum
{
    private readonly TrieNode root;

    /**
     * Initialize your data structure here.
     */
    public MapSum()
    {
        root = new TrieNode();
    }

    public void Insert(string key, int val)
    {
        var cur = root;
        for (var i = 0; i < key.Length; i++)
        {
            var c = key[i];
            var nextI = c - 'a';
            if (cur.Nexts[nextI] == null) cur.Nexts[nextI] = new TrieNode();

            cur = cur.Nexts[nextI];
        }

        cur.Value = val;
    }

    public int Sum(string prefix)
    {
        var cur = root;
        for (var i = 0; i < prefix.Length; i++)
        {
            var c = prefix[i];
            var nextI = c - 'a';
            if (cur.Nexts[nextI] == null) return 0;

            cur = cur.Nexts[nextI];
        }

        return Sum(cur);
    }

    public int Sum(TrieNode root)
    {
        if (root == null) return 0;

        var sum = root.Value;
        for (var i = 0; i < root.Nexts.Length; i++) sum += Sum(root.Nexts[i]);

        return sum;
    }

    public class TrieNode
    {
        public TrieNode()
        {
            Nexts = new TrieNode[26];
        }

        public int Value { get; set; }

        public TrieNode[] Nexts { get; }
    }
}