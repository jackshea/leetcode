using System;
using System.Collections.Generic;

namespace LeetCode.Problems.Medium;

/// 最小体力消耗路径
/// https://leetcode-cn.com/problems/path-with-minimum-effort/
public class P1631_PathWithMinimumEffort
{
    private readonly int[][] direction = { new[] { 0, -1 }, new[] { -1, 0 }, new[] { 1, 0 }, new[] { 0, 1 } };

    public int MinimumEffortPath(int[][] heights)
    {
        var pq = new PriorityQueue<int[]>(16, (a, b) => -a[2].CompareTo(b[2]));
        var m = heights.Length;
        var n = heights[0].Length;
        var dist = new int[m * n];
        Array.Fill(dist, int.MaxValue);
        dist[0] = 0;
        pq.Push(new[] { 0, 0, 0 });
        var isVisited = new bool[m * n];
        while (pq.Count != 0)
        {
            var edge = pq.Pop();
            int x = edge[0], y = edge[1], d = edge[2];
            var idx = x * n + y;
            if (isVisited[idx]) continue;

            isVisited[idx] = true;
            if (x == m - 1 && y == n - 1) break;

            for (var i = 0; i < 4; i++)
            {
                var nx = x + direction[i][0];
                var ny = y + direction[i][1];
                if (nx >= 0 && nx < m && ny >= 0 && ny < n)
                {
                    var nIdx = nx * n + ny;
                    var cost = Math.Abs(heights[x][y] - heights[nx][ny]);
                    var maxCost = Math.Max(cost, d);
                    if (maxCost < dist[nIdx])
                    {
                        dist[nIdx] = maxCost;
                        pq.Push(new[] { nx, ny, maxCost });
                    }
                }
            }
        }

        return dist[m * n - 1];
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