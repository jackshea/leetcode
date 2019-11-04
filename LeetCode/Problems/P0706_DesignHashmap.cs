namespace LeetCode.Problems
{
    /// https://leetcode-cn.com/problems/design-hashmap/
    /// 设计哈希映射
    public class MyHashMap
    {
        private KeyValueNode[] container;
        private const int MAX_LENGTH = 10001;

        /** Initialize your data structure here. */
        public MyHashMap()
        {
            container = new KeyValueNode[MAX_LENGTH];
        }

        /** value will always be non-negative. */
        public void Put(int key, int value)
        {
            int hashKey = key % MAX_LENGTH;
            var keyValueNode = container[hashKey];
            var newNode = new KeyValueNode(key, value);
            if (keyValueNode == null)
            {
                container[hashKey] = newNode;
                return;
            }

            if (keyValueNode.Key == key)
            {
                keyValueNode.Value = value;
                return;
            }

            while (keyValueNode.Next != null)
            {
                if (keyValueNode.Key == key)
                {
                    keyValueNode.Value = value;
                    return;
                }

                keyValueNode = keyValueNode.Next;
            }

            keyValueNode.Next = newNode;
            newNode.Pre = keyValueNode;
        }

        /** Returns the value to which the specified key is mapped, or -1 if this map contains no mapping for the key */
        public int Get(int key)
        {
            int hashKey = key % MAX_LENGTH;
            var keyValueNode = container[hashKey];
            if (keyValueNode == null)
            {
                return -1;
            }

            while (keyValueNode != null)
            {
                if (keyValueNode.Key == key)
                {
                    return keyValueNode.Value;
                }

                keyValueNode = keyValueNode.Next;
            }

            return -1;
        }

        /** Removes the mapping of the specified value key if this map contains a mapping for the key */
        public void Remove(int key)
        {
            int hashKey = key % MAX_LENGTH;
            var keyValueNode = container[hashKey];
            if (keyValueNode != null && keyValueNode.Key == key)
            {
                container[hashKey] = keyValueNode.Next;
                if (keyValueNode.Next != null)
                {
                    keyValueNode.Next.Pre = null;
                }
            }

            while (keyValueNode != null)
            {
                if (keyValueNode.Key == key)
                {
                    if (keyValueNode.Next != null)
                    {
                        keyValueNode.Next.Pre = keyValueNode.Pre;
                    }

                    if (keyValueNode.Pre != null)
                    {
                        keyValueNode.Pre.Next = keyValueNode.Next;
                    }

                    return;
                }

                keyValueNode = keyValueNode.Next;
            }
        }
    }

    public class KeyValueNode
    {
        public int Key;
        public int Value;
        public KeyValueNode Pre;
        public KeyValueNode Next;

        public KeyValueNode(int key, int value)
        {
            Key = key;
            Value = value;
        }
    }
}