using System.Collections.Generic;

namespace LeetCode.Problems.Easy
{
    /// 找出数组中的幸运数
    /// https://leetcode-cn.com/problems/find-lucky-integer-in-an-array/
    public class P1394_FindLuckyIntegerInAnArray
    {
        public int FindLucky(int[] arr)
        {
            int luckyNum = -1;
            Dictionary<int, int> dic = new Dictionary<int, int>();
            foreach (var a in arr)
            {
                if (dic.ContainsKey(a))
                {
                    dic[a]++;
                }
                else
                {
                    dic[a] = 1;
                }
            }

            foreach (var kvp in dic)
            {
                if (kvp.Key == kvp.Value && kvp.Value > luckyNum)
                {
                    luckyNum = kvp.Key;
                }
            }

            return luckyNum;
        }
    }
}