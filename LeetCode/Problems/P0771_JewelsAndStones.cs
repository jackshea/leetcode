using System.Collections.Generic;

namespace LeetCode.Problems
{
    /// 宝石与石头
    /// https://leetcode-cn.com/problems/jewels-and-stones/
    public class P0771_JewelsAndStones
    {
        public int NumJewelsInStones(string J, string S)
        {
            HashSet<char> jewelType = new HashSet<char>();
            foreach (var type in J)
            {
                jewelType.Add(type);
            }

            int count = 0;
            foreach (var stone in S)
            {
                if (jewelType.Contains(stone))
                {
                    count++;
                }
            }

            return count;
        }
    }
}