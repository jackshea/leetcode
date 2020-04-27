namespace LeetCode.Problems.Medium
{
    /// H指数 II
    /// https://leetcode-cn.com/problems/h-index-ii/
    public class P0275_HIndexII
    {
        public int HIndex(int[] citations)
        {
            int left = 0, right = citations.Length - 1;
            int len = citations.Length;
            int ans = 0;
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                int count = len - mid;
                if (citations[mid] < count)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                    ans = count;
                }
            }

            return ans;
        }
    }
}