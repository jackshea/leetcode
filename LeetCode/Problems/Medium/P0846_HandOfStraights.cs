using System.Collections.Generic;

namespace LeetCode.Problems.Medium
{
    /// 一手顺子
    /// https://leetcode-cn.com/problems/hand-of-straights/
    public class P0846_HandOfStraights
    {
        public bool IsNStraightHand(int[] hand, int groupSize)
        {
            SortedList<int, int> dic = new SortedList<int, int>();
            foreach (var card in hand)
            {
                dic.TryGetValue(card, out var cnt);
                dic[card] = cnt + 1;
            }

            while (dic.Keys.Count >= groupSize)
            {
                var start = dic.Keys[0];
                for (int i = start; i < start + groupSize; i++)
                {
                    if (dic.TryGetValue(i, out var cnt))
                    {
                        if (cnt <= 1)
                        {
                            dic.Remove(i);
                        }
                        else
                        {
                            dic[i] = cnt - 1;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
            }

            return dic.Count == 0;
        }
    }
}