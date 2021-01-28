using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Problems.Medium
{
    /// 数组中两个数的最大异或值
    /// https://leetcode-cn.com/problems/maximum-xor-of-two-numbers-in-an-array
    public class P0421_MaximumXorOfTwoNumbersInAnArray
    {
        public int FindMaximumXOR(int[] nums)
        {
            var maxNum = nums.Max();
            int len = BinLength(maxNum);
            int maxXor = 0, currXor = 0;
            ISet<int> prefixes = new HashSet<int>();
            for (int i = len - 1; i >= 0; i--)
            {
                maxXor <<= 1;
                currXor = maxXor | 1;
                prefixes.Clear();
                foreach (var num in nums)
                {
                    prefixes.Add(num >> i);
                }

                foreach (var prefix in prefixes)
                {
                    if (prefixes.Contains(currXor ^ prefix))
                    {
                        maxXor = currXor;
                        break;
                    }
                }
            }

            return maxXor;
        }

        private int BinLength(int n)
        {
            int ans = 0;
            while (n != 0)
            {
                n >>= 1;
                ans++;
            }

            return ans == 0 ? 1 : ans;
        }
    }
}