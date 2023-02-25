namespace LeetCode.Problems.Easy;

/// 所有奇数长度子数组的和
/// https://leetcode-cn.com/problems/sum-of-all-odd-length-subarrays/
public class P1588_SumOfAllOddLengthSubarrays
{
    public int SumOddLengthSubarrays(int[] arr)
    {
        var ans = 0;
        for (var i = 0; i < arr.Length; i++)
        {
            var left = i + 1;
            var right = arr.Length - i;
            var leftEven = (left + 1) / 2;
            var rightEven = (right + 1) / 2;
            var leftOdd = left / 2;
            var rightOdd = right / 2;
            ans += (leftEven * rightEven + leftOdd * rightOdd) * arr[i];
        }

        return ans;
    }
}