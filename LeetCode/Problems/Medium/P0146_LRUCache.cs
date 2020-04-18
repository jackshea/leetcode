using System.Collections.Generic;

namespace LeetCode.Problems.Medium
{
    /// LRU缓存机制
    /// https://leetcode-cn.com/problems/lru-cache/
    public class LRUCache
    {
        private LinkedList<CacheNode> cache;
        private Dictionary<int, CacheNode> map;
        private int capacity;


        public LRUCache(int capacity)
        {
            this.capacity = capacity;
            cache = new LinkedList<CacheNode>();
            map = new Dictionary<int, CacheNode>();
        }

        public int Get(int key)
        {
            if (!map.ContainsKey(key))
            {
                return -1;
            }
            Put(key, map[key].Value);
            return map[key].Value;
        }

        public void Put(int key, int value)
        {
            CacheNode node = null;
            if (map.ContainsKey(key))
            {
                node = map[key];
                node.Value = value;
                cache.Remove(node);
            }
            else
            {
                node = new CacheNode(key, value);
            }

            cache.AddLast(node);
            map[key] = node;
            if (cache.Count > capacity)
            {
                map.Remove(cache.First.Value.Key);
                cache.RemoveFirst();
            }
        }

        public class CacheNode
        {
            public int Key;
            public int Value;

            public CacheNode(int key, int value)
            {
                Key = key;
                Value = value;
            }
        }
    }
}