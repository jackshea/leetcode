namespace LeetCode.Problems.Easy
{
    /// 到目标元素的最小距离
    /// https://leetcode-cn.com/problems/minimum-distance-to-the-target-element/
    public class P1848_MinimumDistanceToTheTargetElement
    {
        public int GetMinDistance(int[] nums, int target, int start)
        {
            if (nums[start] == target)
            {
                return 0;
            }

            int dist = 1;
            var n = nums.Length;
            while (start - dist >= 0 || start + dist < n)
            {
                if (start - dist >= 0 && nums[start - dist] == target)
                {
                    return dist;
                }

                if (start + dist < n && nums[start + dist] == target)
                {
                    return dist;
                }

                dist++;
            }

            return -1;
        }
    }
}