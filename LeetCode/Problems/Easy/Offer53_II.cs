using System.Linq;

namespace LeetCode.Problems.Easy;

/// 剑指 Offer 53 - II. 0～n-1中缺失的数字
/// https://leetcode-cn.com/problems/que-shi-de-shu-zi-lcof/
public class Offer53_II
{
    public int MissingNumber(int[] nums)
    {
        int left = 0, right = nums.Length - 1;
        while (left <= right)
        {
            var mid = left + (right - left) / 2;
            if (nums[mid] == mid)
                left = mid + 1;
            else
                right = mid - 1;
        }

        return left;
    }

    public int MissingNumber_1(int[] nums)
    {
        var sum = nums.Sum();
        var n = nums.Length + 1;
        var expectSum = (n - 1) * n / 2;
        return expectSum - sum;
    }
}