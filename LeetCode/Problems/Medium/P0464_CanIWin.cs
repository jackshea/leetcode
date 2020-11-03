using System.Collections.Generic;

namespace LeetCode.Problems.Medium
{
    /// 我能赢吗
    /// https://leetcode-cn.com/problems/can-i-win/
    public class P0464_CanIWin
    {
        private Dictionary<int, bool> cache = new Dictionary<int, bool>();
        private bool[] state;
        public bool CanIWin(int maxChoosableInteger, int desiredTotal)
        {
            if (maxChoosableInteger >= desiredTotal)
            {
                return true;
            }

            int sum = (1 + maxChoosableInteger) * maxChoosableInteger / 2;
            if (sum < desiredTotal)
            {
                return false;
            }

            state = new bool[maxChoosableInteger + 1];
            return DFS(desiredTotal);
        }

        private bool DFS(int desiredTotal)
        {
            var stateMark = ToStateMark(state);
            if (cache.TryGetValue(stateMark, out var res))
            {
                return res;
            }

            for (int i = 1; i < state.Length; i++)
            {
                if (!state[i])
                {
                    state[i] = true;
                    if (desiredTotal <= i || !DFS(desiredTotal - i))
                    {
                        cache[stateMark] = true;
                        state[i] = false;
                        return true;
                    }
                    state[i] = false;
                }
            }

            cache[stateMark] = false;
            return false;
        }

        private int ToStateMark(bool[] state)
        {
            int ans = 0;
            for (int i = 0; i < state.Length; i++)
            {
                ans <<= 1;
                if (state[i])
                {
                    ans |= 1;
                }
            }

            return ans;
        }
    }
}