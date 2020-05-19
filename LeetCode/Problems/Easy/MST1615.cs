using System.Collections.Generic;

namespace LeetCode.Problems.Easy
{
    /// 珠玑妙算
    /// https://leetcode-cn.com/problems/master-mind-lcci/
    public class MST1615
    {
        public int[] MasterMind(string solution, string guess)
        {
            int hit = 0, pseudoHit = 0;
            Dictionary<char, int> dic = new Dictionary<char, int>();

            for (int i = 0; i < solution.Length; i++)
            {
                if (solution[i] == guess[i])
                {
                    hit++;
                }

                dic.TryGetValue(solution[i], out var count);
                dic[solution[i]] = count + 1;
            }

            foreach (var g in guess)
            {
                if (dic.TryGetValue(g, out var count))
                {
                    if (count > 0)
                    {
                        pseudoHit++;
                        dic[g] = count - 1;
                    }
                }
            }

            return new[] { hit, pseudoHit - hit };
        }
    }
}