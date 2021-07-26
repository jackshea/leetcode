using System.Collections.Generic;

namespace LeetCode.Problems.Hard
{
    /// 得到子序列的最少操作次数
    /// https://leetcode-cn.com/problems/minimum-operations-to-make-a-subsequence/
    public class P1713_MinimumOperationsToMakeASubsequence
    {
        public int MinOperations(int[] target, int[] arr)
        {
            int n = target.Length;
            Dictionary<int, int> pos = new Dictionary<int, int>();
            for (int i = 0; i < n; i++)
            {
                pos[target[i]] = i;
            }
            List<int> d = new List<int>();
            foreach (var v in arr)
            {
                if (pos.TryGetValue(v, out var idx))
                {
                    int it = BinarySearch(d, idx);
                    if (it != d.Count)
                    {
                        d[it] = idx;
                    }
                    else
                    {
                        d.Add(idx);
                    }
                }
            }

            return n - d.Count;
        }

        public int BinarySearch(IList<int> d, int target)
        {
            int size = d.Count;
            if (size == 0 || d[size - 1] < target)
            {
                return size;
            }
            int low = 0, high = size - 1;
            while (low < high)
            {
                int mid = (high - low) / 2 + low;
                if (d[mid] < target)
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid;
                }
            }
            return low;
        }
    }
}