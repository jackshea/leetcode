using System.Collections.Generic;

namespace LeetCode.Problems.Medium
{
    /// 分割数组为连续子序列
    /// https://leetcode-cn.com/problems/split-array-into-consecutive-subsequences/
    public class P0695_SplitArrayIntoConsecutiveSubsequences
    {
        public bool IsPossible(int[] nums)
        {
            var nc = new Dictionary<int, int>();
            var tail = new Dictionary<int, int>();
            foreach (var num in nums)
            {
                Delta(nc, num, 1);
            }

            foreach (var num in nums)
            {
                if (!nc.ContainsKey(num) || nc[num] == 0)
                {
                    continue;
                }

                if (nc[num] > 0 && tail.ContainsKey(num - 1) && tail[num - 1] > 0)
                {
                    Delta(nc, num, -1);
                    Delta(tail, num - 1, -1);
                    Delta(tail, num, 1);
                }
                else if (nc[num] > 0 && nc.ContainsKey(num + 1) && nc[num + 1] > 0 && nc.ContainsKey(num + 2) && nc[num + 2] > 0)
                {
                    Delta(nc, num, -1);
                    Delta(nc, num + 1, -1);
                    Delta(nc, num + 2, -1);
                    Delta(tail, num + 2, 1);
                }
                else
                {
                    return false;
                }
            }
            return true;
        }

        private void Delta(Dictionary<int, int> dic, int key, int delta)
        {
            dic.TryGetValue(key, out var cnt);
            dic[key] = cnt + delta;
        }
    }
}