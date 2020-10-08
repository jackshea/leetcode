namespace LeetCode.Problems.Easy
{
    /// 所有奇数长度子数组的和
    /// https://leetcode-cn.com/problems/sum-of-all-odd-length-subarrays/
    public class P1588_SumOfAllOddLengthSubarrays
    {
        public int SumOddLengthSubarrays(int[] arr)
        {
            int ans = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                int left = i + 1;
                int right = arr.Length - i;
                int leftEven = (left + 1) / 2;
                int rightEven = (right + 1) / 2;
                int leftOdd = left / 2;
                int rightOdd = right / 2;
                ans += (leftEven * rightEven + leftOdd * rightOdd) * arr[i];
            }
            return ans;
        }
    }
}