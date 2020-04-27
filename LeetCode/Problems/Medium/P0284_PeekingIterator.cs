using System.Collections.Generic;

namespace LeetCode.Problems.Medium
{
    /// 顶端迭代器
    /// https://leetcode-cn.com/problems/peeking-iterator/
    class PeekingIterator
    {
        private IEnumerator<int> iterator;
        private bool hasNext;

        // iterators refers to the first element of the array.
        public PeekingIterator(IEnumerator<int> iterator)
        {
            this.iterator = iterator;
            // initialize any member here.
        }

        // Returns the next element in the iteration without advancing the iterator.
        public int Peek()
        {
            return iterator.Current;
        }

        // Returns the next element in the iteration and advances the iterator.
        public int Next()
        {
            int ans = iterator.Current;
            hasNext = iterator.MoveNext();
            return ans;
        }

        // Returns false if the iterator is refering to the end of the array of true otherwise.
        public bool HasNext()
        {
            return hasNext;
        }
    }
}