using System;
using System.Collections.Generic;

namespace LeetCode.Problems.Medium;

/// 最接近原点的 K 个点
/// https://leetcode-cn.com/problems/k-closest-points-to-origin/
public class P0973_KClosestPointsToOrigin
{
    public int[][] KClosest(int[][] points, int K)
    {
        var pq = new PriorityQueue<PointDist>(K + 1);
        foreach (var point in points)
        {
            pq.Push(new PointDist
            {
                Point = point,
                DistSqr = point[0] * point[0] + point[1] * point[1]
            });

            if (pq.Count > K) pq.Pop();
        }

        var ans = new int[K][];
        for (var i = 0; i < K; i++) ans[i] = pq.Pop().Point;

        return ans;
    }

    public class PointDist : IComparable<PointDist>
    {
        public int DistSqr;
        public int[] Point;

        public int CompareTo(PointDist other)
        {
            return DistSqr.CompareTo(other.DistSqr);
        }
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