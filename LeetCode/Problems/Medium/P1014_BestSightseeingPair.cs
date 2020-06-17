namespace LeetCode.Problems.Medium
{
    /// 最佳观光组合
    /// https://leetcode-cn.com/problems/best-sightseeing-pair/
    public class P1014_BestSightseeingPair
    {
        public int MaxScoreSightseeingPair(int[] A)
        {
            int left = 0;
            int ans = int.MinValue;
            for (int i = 1; i < A.Length; i++)
            {
                var v = A[left] + left + A[i] - i;
                if (ans < v)
                {
                    ans = v;
                }
                if (A[i] + i > left + A[left])
                {
                    left = i;
                }
            }

            return ans;
        }
    }
}