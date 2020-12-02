using System;

namespace LeetCode.Problems.Hard
{
    /// 拼接最大数
    /// https://leetcode-cn.com/problems/create-maximum-number/
    public class P0321_CreateMaximumNumber
    {
        public int[] MaxNumber(int[] nums1, int[] nums2, int k)
        {
            int m = nums1.Length, n = nums2.Length;
            int[] res = new int[k];
            for (int i = Math.Max(0, k - n); i <= k && i <= m; i++)
            {
                int[] arr = merge(maxArr(nums1, i), maxArr(nums2, k - i), k);
                if (gt(arr, 0, res, 0)) res = arr;
            }
            return res;
        }

        private int[] maxArr(int[] nums, int k)
        {
            int n = nums.Length;
            int[] res = new int[k];
            for (int i = 0, j = 0; i < n; i++)
            {
                while (n - i + j > k && j > 0 && nums[i] > res[j - 1]) j--;
                if (j < k) res[j++] = nums[i];
            }
            return res;
        }

        private int[] merge(int[] nums1, int[] nums2, int k)
        {
            int[] res = new int[k];
            for (int i = 0, j = 0, r = 0; r < k; r++)
                res[r] = gt(nums1, i, nums2, j) ? nums1[i++] : nums2[j++];
            return res;
        }

        private bool gt(int[] nums1, int i, int[] nums2, int j)
        {
            while (i < nums1.Length && j < nums2.Length && nums1[i] == nums2[j])
            {
                i++;
                j++;
            }
            return j == nums2.Length || (i < nums1.Length && nums1[i] > nums2[j]);
        }
    }
}