using System;

namespace LeetCode.Problems.Easy
{
    /// 获取生成数组中的最大值
    /// https://leetcode-cn.com/problems/get-maximum-in-generated-array/
    public class P1646_GetMaximumInGeneratedArray
    {
        public int GetMaximumGenerated(int n)
        {
            if (n <= 1)
            {
                return n;
            }

            int[] genArray = new int[n + 1];
            genArray[1] = 1;
            int ans = 1;
            for (int i = 2; i < genArray.Length; i++)
            {
                if (i % 2 == 0)
                {
                    genArray[i] = genArray[i / 2];
                }
                else
                {
                    genArray[i] = genArray[i / 2] + genArray[i / 2 + 1] ;
                }

                ans = Math.Max(ans, genArray[i]);
            }

            return ans;
        }
    }
}