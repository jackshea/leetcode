using System;

namespace LeetCode.Problems.Medium
{
    public class P0016_3SumClosest
    {
        public int ThreeSumClosest(int[] nums, int target)
        {
            int minDiff = Int32.MaxValue;
            int ans = 0;
            Array.Sort(nums);
            for (int i = 0; i < nums.Length; i++)
            {
                int left = i + 1;
                int right = nums.Length - 1;
                while (left < right)
                {
                    int sum = nums[i] + nums[left] + nums[right];
                    if (sum > target)
                    {
                        right--;
                    }
                    else if (sum < target)
                    {
                        left++;
                    }
                    else
                    {
                        return sum;
                    }

                    int diff = Math.Abs(sum - target);
                    if (diff < minDiff)
                    {
                        minDiff = diff;
                        ans = sum;
                    }
                }
            }

            return ans;
        }
    }
}