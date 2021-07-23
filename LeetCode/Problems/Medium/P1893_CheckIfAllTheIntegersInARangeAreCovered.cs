namespace LeetCode.Problems.Medium
{
    /// 检查是否区域内所有整数都被覆盖
    /// https://leetcode-cn.com/problems/check-if-all-the-integers-in-a-range-are-covered/
    public class P1893_CheckIfAllTheIntegersInARangeAreCovered
    {
        public bool IsCovered(int[][] ranges, int left, int right)
        {
            int[] diff = new int[52];
            foreach (var range in ranges)
            {
                diff[range[0]]++;
                diff[range[1] + 1]--;
            }

            int sum = 0;
            for (int i = 1; i <= 50; i++)
            {
                sum += diff[i];
                if (i >= left && i <= right && sum <= 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}