using System;

namespace LeetCode.Problems
{
    /// 最后一块石头的重量
    /// https://leetcode-cn.com/problems/last-stone-weight/
    public class P1046_LastStoneWeight
    {
        public int LastStoneWeight(int[] stones)
        {
            Array.Sort(stones, (a, b) => -a.CompareTo(b));
            int ans = stones[0];
            for (int i = 1; i < stones.Length; i++)
            {
                ans = stones[i - 1] - stones[i];
                if (ans == 0)
                {
                    if (i < stones.Length - 1)
                    {
                        ans = stones[i + 1];
                    }

                    i++;
                }
                else
                {
                    stones[i] = ans;
                    for (int j = i + 1; j < stones.Length; j++)
                    {
                        if (stones[j] > ans)
                        {
                            stones[j - 1] = stones[j];
                            stones[j] = ans;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }

            return ans;
        }
    }
}