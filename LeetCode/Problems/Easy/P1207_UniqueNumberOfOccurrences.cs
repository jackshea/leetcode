using System.Collections.Generic;

namespace LeetCode.Problems.Easy
{
    /// 独一无二的出现次数
    /// https://leetcode-cn.com/problems/unique-number-of-occurrences/
    public class P1207_UniqueNumberOfOccurrences
    {
        public bool UniqueOccurrences(int[] arr)
        {
            var numberOfOccurrences = new Dictionary<int, int>();
            foreach (var n in arr)
            {
                if (numberOfOccurrences.ContainsKey(n))
                {
                    numberOfOccurrences[n]++;
                }
                else
                {
                    numberOfOccurrences[n] = 1;
                }
            }

            var exist = new HashSet<int>();
            foreach (var v in numberOfOccurrences.Values)
            {
                if (exist.Contains(v))
                {
                    return false;
                }

                exist.Add(v);
            }

            return true;
        }
    }
}