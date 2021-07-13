using System;
using System.Collections.Generic;

namespace LeetCode.Problems.Hard
{
    /// 天际线问题
    /// https://leetcode-cn.com/problems/the-skyline-problem/
    public class P0218_TheSkylineProblem
    {
        public IList<IList<int>> GetSkyline(int[][] buildings)
        {
            List<int> boundaries = new List<int>();
            foreach (var building in buildings)
            {
                boundaries.Add(building[0]);
                boundaries.Add(building[1]);
            }
            boundaries.Sort();
            PriorityQueue<int[]> pq = new PriorityQueue<int[]>(buildings.Length, (a, b) => b[1].CompareTo(a[1]));
            IList<IList<int>> ret = new List<IList<int>>();
            int n = buildings.Length, idx = 0;
            foreach (int boundary in boundaries)
            {
                while (idx < n && buildings[idx][0] <= boundary)
                {
                    pq.Push(new int[] { buildings[idx][1], buildings[idx][2] });
                    idx++;
                }
                while (pq.Count != 0 && pq.Top()[0] <= boundary)
                {
                    pq.Pop();
                }

                int maxn = pq.Count == 0 ? 0 : pq.Top()[1];
                if (ret.Count == 0 || maxn != ret[ret.Count - 1][1])
                {
                    ret.Add(new List<int> { boundary, maxn });
                }
            }
            return ret;
        }

        /// 优先队列。 队首默认是最小值。
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
                for (var n2 = n / 2; n > 0 && comparer.Compare(v, heap[n2]) < 0; n = n2, n2 /= 2) heap[n] = heap[n2];
                heap[n] = v;
            }

            private void SiftDown(int n)
            {
                var v = heap[n];
                for (var n2 = n * 2; n2 < Count; n = n2, n2 *= 2)
                {
                    if (n2 + 1 < Count && comparer.Compare(heap[n2 + 1], heap[n2]) < 0) n2++;
                    if (comparer.Compare(v, heap[n2]) <= 0) break;
                    heap[n] = heap[n2];
                }

                heap[n] = v;
            }
        }
    }
}