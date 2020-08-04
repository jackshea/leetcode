using System;

namespace LeetCode.Problems.Easy
{
    /// 统计好三元组
    /// https://leetcode-cn.com/problems/count-good-triplets/
    public class P1534_CountGoodTriplets
    {
        public int CountGoodTriplets(int[] arr, int a, int b, int c)
        {
            int ans = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    for (int k = j + 1; k < arr.Length; k++)
                    {
                        if (Math.Abs(arr[i] - arr[j]) <= a && Math.Abs(arr[j] - arr[k]) <= b && Math.Abs(arr[i] - arr[k]) <= c)
                        {
                            ans++;
                        }
                    }
                }
            }

            return ans;
        }
    }
}