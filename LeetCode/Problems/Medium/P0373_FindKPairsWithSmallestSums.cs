using System.Collections.Generic;

namespace LeetCode.Problems.Medium
{
    /// 查找和最小的K对数字
    /// https://leetcode-cn.com/problems/find-k-pairs-with-smallest-sums/
    public class P0373_FindKPairsWithSmallestSums
    {
        public IList<IList<int>> KSmallestPairs(int[] nums1, int[] nums2, int k)
        {
            IList<IList<int>> ans = new List<IList<int>>();
            if (k > nums1.Length * nums2.Length)
            {
                k = nums1.Length * nums2.Length;
            }

            if (nums1.Length == 0 || nums2.Length == 0)
            {
                return ans;
            }

            int[] index = new int[nums1.Length];

            for (int i = 0; i < k; i++)
            {
                int min = int.MaxValue;
                int minIndex = 0;
                for (int j = 0; j < nums1.Length; j++)
                {
                    if (index[j] >= nums2.Length)
                    {
                        continue;
                    }
                    int sum = nums1[j] + nums2[index[j]];
                    if (sum < min)
                    {
                        min = sum;
                        minIndex = j;
                    }
                }
                ans.Add(new List<int> { nums1[minIndex], nums2[index[minIndex]] });
                index[minIndex]++;
            }

            return ans;
        }
    }
}