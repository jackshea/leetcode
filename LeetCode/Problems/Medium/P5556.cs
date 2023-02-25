using System;
using System.Collections.Generic;

namespace LeetCode.Problems.Medium;

/// 可以到达的最远建筑
/// https://leetcode-cn.com/problems/furthest-building-you-can-reach/
public class P5556
{
    public int FurthestBuilding(int[] heights, int bricks, int ladders)
    {
        var ans = 1;
        var pq = new PriorityQueue<int>();
        for (; ans < heights.Length; ans++)
        {
            var diff = heights[ans] - heights[ans - 1];
            if (diff <= 0) continue;

            if (bricks < diff)
            {
                if (ladders > 0)
                {
                    var top = pq.Count > 0 ? pq.Top() : -1;
                    if (top > diff) bricks += pq.Pop() - diff;

                    ladders--;
                }
                else
                {
                    break;
                }
            }
            else
            {
                bricks -= diff;
                pq.Push(diff);
            }
        }

        return ans - 1;
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