using System.Collections.Generic;

namespace LeetCode.Problems.Easy
{
    /// LCP 11. 期望个数统计
    /// https://leetcode-cn.com/problems/qi-wang-ge-shu-tong-ji/
    public class LCP11
    {
        public int ExpectNumber(int[] scores)
        {
            var dic = new Dictionary<int, int>();
            foreach (var score in scores)
            {
                if (dic.ContainsKey(score))
                {
                    dic[score]++;
                }
                else
                {
                    dic[score] = 1;
                }
            }

            return dic.Count;
        }
    }
}