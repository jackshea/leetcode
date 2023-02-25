namespace LeetCode.Problems.Easy;

/// 第 k 个缺失的正整数
/// https://leetcode-cn.com/problems/kth-missing-positive-number/
public class P1539_KthMissingPositiveNumber
{
    public int FindKthPositive(int[] arr, int k)
    {
        if (arr[0] > k) return k;

        int left = 0, right = arr.Length;
        while (left < right)
        {
            var mid = left + (right - left) / 2;
            var v = int.MaxValue;
            if (mid < arr.Length) v = arr[mid];

            if (v - mid - 1 >= k)
                right = mid;
            else
                left = mid + 1;
        }

        return k + left;
    }
}