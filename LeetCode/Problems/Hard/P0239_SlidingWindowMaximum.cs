using System.Collections.Generic;

namespace LeetCode.Problems.Hard
{
    /// 滑动窗口最大值
    /// https://leetcode-cn.com/problems/sliding-window-maximum/
    public class P0239_SlidingWindowMaximum
    {
        public int[] MaxSlidingWindow(int[] nums, int k)
        {
            LinkedList<int> deque = new LinkedList<int>();
            for (int i = 0; i < k; i++)
            {
                while (deque.Count > 0 && nums[deque.Last.Value] <= nums[i])
                {
                    deque.RemoveLast();
                }
                deque.AddLast(i);
            }
            int[] ans = new int[nums.Length - k + 1];
            ans[0] = nums[deque.First.Value];
            for (int i = k; i < nums.Length; i++)
            {
                while (deque.Count > 0 && nums[deque.Last.Value] <= nums[i])
                {
                    deque.RemoveLast();
                }
                deque.AddLast(i);
                while (deque.First.Value <= i - k)
                {
                    deque.RemoveFirst();
                }
                ans[i - k + 1] = nums[deque.First.Value];
            }
            return ans;
        }
    }
}