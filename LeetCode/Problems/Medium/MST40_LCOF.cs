using System;

namespace LeetCode.Problems.Medium
{
    /// 面试题40. 最小的k个数
    /// https://leetcode-cn.com/problems/zui-xiao-de-kge-shu-lcof/
    public class MST40_LCOF
    {
        public int[] GetLeastNumbers(int[] arr, int k)
        {
            if (arr.Length <= k)
            {
                return arr;
            }

            Array.Sort(arr);
            int[] ans = new int[k];
            Array.Copy(arr, ans, k);
            return ans;
        }
    }

    /// 使用优先队列
    public class MST40_LCOF_1
    {
        public int[] GetLeastNumbers(int[] arr, int k)
        {
            if (arr.Length <= k)
            {
                return arr;
            }

            var pq = new MaxPQ<int>(k + 1);
            foreach (var v in arr)
            {
                pq.Insert(v);
                if (pq.Size > k)
                {
                    pq.DelMax();
                }
            }

            var ans = new int[k];
            for (int i = 0; i < ans.Length; i++)
            {
                ans[i] = pq.DelMax();
            }

            return ans;
        }
    }

    /// 优先队列，大根堆
    public class MaxPQ<T> where T : IComparable<T>
    {
        private T[] pq; // pq[0] 不使用


        public MaxPQ(int maxSize)
        {
            pq = new T[maxSize + 1];
        }

        public bool IsEmpty => Size == 0;

        public int Size { get; private set; }

        /// 插入
        public void Insert(T v)
        {
            pq[++Size] = v;
            Swim(Size);
        }

        /// 删除并返回最大值
        public T DelMax()
        {
            T max = pq[1];
            Swap(1, Size);
            pq[Size] = default(T);
            Size--;
            Sink(1);
            return max;
        }

        /// 返回最大值
        public T GetMax()
        {
            return pq[1];
        }

        /// 交换两个索引的值
        private void Swap(int i, int j)
        {
            T temp = pq[i];
            pq[i] = pq[j];
            pq[j] = temp;
        }

        /// 上浮，参数为索引
        private void Swim(int i)
        {
            while (i > 1 && pq[i].CompareTo(pq[i / 2]) > 0)
            {
                Swap(i, i / 2);
                i /= 2;
            }
        }

        /// 下沉，参数为索引
        private void Sink(int i)
        {
            while (2 * i <= Size)
            {
                int j = 2 * i;
                if (j < Size && pq[j].CompareTo(pq[j + 1]) < 0)
                {
                    j++;
                }

                if (pq[i].CompareTo(pq[j]) >= 0)
                {
                    break;
                }

                Swap(i, j);
                i = j;
            }
        }
    }

}