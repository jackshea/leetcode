using System;
using System.Collections.Generic;

namespace LeetCode.Problems.Hard
{
    /// 水位上升的泳池中游泳
    /// https://leetcode-cn.com/problems/swim-in-rising-water/
    public class P0778_SwimInRisingWater
    {
        private int[][] direction = { new[] { -1, 0 }, new[] { 1, 0 }, new[] { 0, -1 }, new[] { 0, 1 } };
        public int SwimInWater(int[][] grid)
        {
            int n = grid.Length;
            int[] dist = new int[n * n];
            Array.Fill(dist, int.MaxValue);
            dist[0] = grid[0][0];
            PriorityQueue<int[]> pq = new PriorityQueue<int[]>(16,
                (a, b) => -grid[a[0]][a[1]].CompareTo(grid[b[0]][b[1]]));
            pq.Push(new[] { 0, 0 });
            bool[] isVisited = new bool[n * n];
            while (pq.Count > 0)
            {
                var top = pq.Pop();
                int x = top[0];
                int y = top[1];
                if (x == n - 1 && y == n - 1)
                {
                    break;
                }
                int idx = x * n + y;
                if (isVisited[idx])
                {
                    continue;
                }

                isVisited[idx] = true;
                int d = dist[idx];
                for (int i = 0; i < 4; i++)
                {
                    int nx = x + direction[i][0];
                    int ny = y + direction[i][1];
                    if (nx >= 0 && nx < n && ny >= 0 && ny < n)
                    {
                        int nIdx = nx * n + ny;
                        var nd = dist[nIdx];
                        int max = Math.Max(d, grid[nx][ny]);
                        if (max < nd)
                        {
                            dist[nIdx] = max;
                            pq.Push(new[] { nx, ny });
                        }
                    }
                }
            }

            return dist[n * n - 1];
        }

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