using System;

namespace LeetCode.Problems.Medium
{
    /// 排序数组
    /// https://leetcode-cn.com/problems/sort-an-array/
    public class P0912_SortAnArray
    {
        public int[] SortArray(int[] nums)
        {
            Shuffle(nums);
            QuickSort(nums, 0, nums.Length - 1);
            return nums;
        }

        /// 快速排序
        public void QuickSort(int[] nums, int start, int end)
        {
            if (start >= end)
            {
                return;
            }

            var p = Partition(nums, start, end);
            QuickSort(nums, start, p - 1);
            QuickSort(nums, p + 1, end);
        }

        /// 拆分
        private int Partition(int[] nums, int start, int end)
        {
            int p = nums[start];
            while (start < end)
            {
                while (nums[end] >= p && start < end)
                {
                    end--;
                }

                nums[start] = nums[end];

                while (nums[start] <= p && start < end)
                {
                    start++;
                }

                nums[end] = nums[start];
            }

            nums[start] = p;
            return start;
        }

        /// 洗牌。随机化
        private void Shuffle(int[] nums)
        {
            var random = new Random((int)DateTime.Now.Ticks);
            for (int i = nums.Length - 1; i >= 1; i--)
            {
                var willEx = random.Next(i + 1);
                Swap(nums, i, willEx);
            }
        }

        private void Swap(int[] nums, int i, int j)
        {
            int temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }

        /// 插入排序
        private void InsertionSort(int[] nums, int start, int end)
        {
            for (int i = start + 1; i <= end; i++)
            {
                int n = nums[i];
                int j = i - 1;
                while (j >= start && nums[j] > n)
                {
                    nums[j + 1] = nums[j];
                    j--;
                }

                nums[j + 1] = n;
            }
        }
    }
}