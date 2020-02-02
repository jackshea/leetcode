namespace LeetCode.Problems.Easy
{
    /// 设计哈希集合
    /// https://leetcode-cn.com/problems/design-hashset/
    public class MyHashSet
    {
        private LinkNode[] container;
        private const int MAX_LENGTH = 10001;

        /** Initialize your data structure here. */
        public MyHashSet()
        {
            container = new LinkNode[MAX_LENGTH];
        }

        public void Add(int key)
        {
            int hashKey = key % MAX_LENGTH;
            var node = container[hashKey];
            var newNode = new LinkNode(key);
            if (node == null)
            {
                container[hashKey] = newNode;
                return;
            }

            if (node.Val == key)
            {
                return;
            }

            while (node.Next != null)
            {
                if (node.Val == key)
                {
                    return;
                }

                node = node.Next;
            }

            node.Next = newNode;
            newNode.Pre = node;
        }

        public void Remove(int key)
        {
            int hashKey = key % MAX_LENGTH;
            var node = container[hashKey];

            if (node != null && node.Val == key)
            {
                container[hashKey] = node.Next;
                if (node.Next != null)
                {
                    node.Next.Pre = null;
                }
            }

            while (node != null)
            {
                if (node.Val == key)
                {
                    if (node.Pre != null)
                    {
                        node.Pre.Next = node.Next;

                    }

                    if (node.Next != null)
                    {
                        node.Next.Pre = node.Pre;
                    }

                    return;
                }

                node = node.Next;
            }

        }

        /** Returns true if this set contains the specified element */
        public bool Contains(int key)
        {
            int hashKey = key % MAX_LENGTH;
            var node = container[hashKey];

            while (node != null)
            {
                if (node.Val == key)
                {
                    return true;
                }

                node = node.Next;
            }

            return false;
        }
    }

    public class LinkNode
    {
        public LinkNode Pre;
        public LinkNode Next;
        public int Val;

        public LinkNode(int val)
        {
            Val = val;
        }
    }

}