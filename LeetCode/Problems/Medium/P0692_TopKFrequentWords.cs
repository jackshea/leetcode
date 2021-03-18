using System;
using System.Collections.Generic;

namespace LeetCode.Problems.Medium
{
    /// 前K个高频单词
    /// https://leetcode-cn.com/problems/top-k-frequent-words/
    public class P0692_TopKFrequentWords
    {
        public IList<string> TopKFrequent(string[] words, int k)
        {
            Dictionary<string, int> freq = new Dictionary<string, int>();
            foreach (var word in words)
            {
                freq.TryGetValue(word, out var count);
                freq[word] = count + 1;
            }
            PriorityQueue<string> pq = new PriorityQueue<string>(k, Comparer<string>.Create((a, b) =>
            {
                if (freq[a] != freq[b])
                {
                    return -freq[a].CompareTo(freq[b]);
                }
                return String.Compare(a, b, StringComparison.Ordinal);
            }));
            foreach (var kvp in freq)
            {
                pq.Push(kvp.Key);
                if (pq.Count > k)
                {
                    pq.Pop();
                }
            }
            List<string> ans = new List<string>(k);
            for (int i = 0; i < k; i++)
            {
                ans.Add(pq.Pop());
            }
            ans.Reverse(0, k);
            return ans;
        }

        /// 优先队列。 队首默认是最大值。
        public class PriorityQueue<T>
        {
            private readonly IComparer<T> comparer;
            private T[] heap;

            public PriorityQueue() : this(null)
            {
            }

            public PriorityQueue(IComparer<T> comparer) : this(16, comparer)
            {
            }

            public PriorityQueue(int capacity, IComparer<T> comparer = null)
            {
                this.comparer = comparer ?? Comparer<T>.Default;
                heap = new T[capacity];
            }

            public PriorityQueue(int capacity, Comparison<T> comparison) : this(capacity, Comparer<T>.Create(comparison))
            {
            }

            public int Count { get; private set; }

            public void Push(T v)
            {
                if (Count >= heap.Length) Array.Resize(ref heap, Count * 2);
                heap[Count] = v;
                SiftUp(Count++);
            }

            public T Pop()
            {
                var v = Top();
                heap[0] = heap[--Count];
                if (Count > 0) SiftDown(0);
                return v;
            }

            public T Top()
            {
                if (Count > 0) return heap[0];
                throw new InvalidOperationException("优先队列为空");
            }

            private void SiftUp(int n)
            {
                var v = heap[n];
                for (var n2 = n / 2; n > 0 && comparer.Compare(v, heap[n2]) > 0; n = n2, n2 /= 2) heap[n] = heap[n2];
                heap[n] = v;
            }

            private void SiftDown(int n)
            {
                var v = heap[n];
                for (var n2 = n * 2; n2 < Count; n = n2, n2 *= 2)
                {
                    if (n2 + 1 < Count && comparer.Compare(heap[n2 + 1], heap[n2]) > 0) n2++;
                    if (comparer.Compare(v, heap[n2]) >= 0) break;
                    heap[n] = heap[n2];
                }

                heap[n] = v;
            }
        }
    }
}