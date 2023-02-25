namespace LeetCode.Problems.Medium;

/// H指数 II
/// https://leetcode-cn.com/problems/h-index-ii/
public class P0275_HIndexII
{
    public int HIndex(int[] citations)
    {
        int left = 0, right = citations.Length - 1;
        var len = citations.Length;
        var ans = 0;
        while (left <= right)
        {
            var mid = left + (right - left) / 2;
            var count = len - mid;
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