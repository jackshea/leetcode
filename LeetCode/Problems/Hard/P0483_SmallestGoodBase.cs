using System;

namespace LeetCode.Problems.Hard
{
    /// 最小好进制
    /// https://leetcode-cn.com/problems/smallest-good-base/
    public class P0483_SmallestGoodBase
    {
        public string SmallestGoodBase(string n)
        {
            long nVal = long.Parse(n);
            int mMax = (int)Math.Floor(Math.Log(nVal) / Math.Log(2));
            for (int m = mMax; m > 1; m--)
            {
                int k = (int)Math.Pow(nVal, 1.0 / m);
                long mul = 1, sum = 1;
                for (int i = 0; i < m; i++)
                {
                    mul *= k;
                    sum += mul;
                }
                if (sum == nVal)
                {
                    return k.ToString();
                }
            }
            return (nVal - 1).ToString();
        }
    }
}