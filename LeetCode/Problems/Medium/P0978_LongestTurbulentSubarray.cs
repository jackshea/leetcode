using System;

namespace LeetCode.Problems.Medium
{
    /// 最长湍流子数组
    /// https://leetcode-cn.com/problems/longest-turbulent-subarray/
    public class P0978_LongestTurbulentSubarray
    {
        public int MaxTurbulenceSize(int[] arr)
        {
            if (arr.Length == 1)
            {
                return 1;
            }

            int left = 0, right = 0, ans = 0;
            while (right < arr.Length - 1)
            {
                if (left == right)
                {
                    if (arr[left] == arr[left + 1])
                    {
                        left++;
                    }

                    right++;
                }
                else
                {
                    if (Check(arr, right))
                    {
                        right++;
                    }
                    else
                    {
                        left = right;
                    }
                }
                ans = Math.Max(ans, right - left + 1);
            }

            return ans;
        }

        private bool Check(int[] array, int idx)
        {
            if (idx == 0 || idx >= array.Length - 1)
            {
                return false;
            }

            return array[idx - 1] < array[idx] && array[idx] > array[idx + 1]
                || array[idx - 1] > array[idx] && array[idx] < array[idx + 1];
        }
    }

    // DP解法
    public class P0978_LongestTurbulentSubarray1
    {
        public int MaxTurbulenceSize(int[] arr)
        {
            if (arr.Length < 2)
            {
                return arr.Length;
            }

            int ans = 1;
            int increase = 1, decrease = 1;
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i - 1] < arr[i])
                {
                    increase = decrease + 1;
                    decrease = 1;
                    ans = Math.Max(ans, increase);
                }
                else if (arr[i - 1] > arr[i])
                {
                    decrease = increase + 1;
                    increase = 1;
                    ans = Math.Max(ans, decrease);
                }
                else
                {
                    increase = 1;
                    decrease = 1;
                }
            }

            return ans;
        }
    }
}