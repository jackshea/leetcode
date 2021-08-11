using System;

namespace LeetCode.Problems.Medium
{
    /// 重新排序得到 2 的幂
    /// https://leetcode-cn.com/problems/reordered-power-of-2/
    public class P0869_ReorderedPowerOf2
    {
        public bool ReorderedPowerOf2(int n)
        {
            var ns = n.ToString().ToCharArray();
            Array.Sort(ns);
            for (int i = 0; i <= 31; i++)
            {
                var s = (1 << i).ToString();
                if (s.Length < ns.Length)
                {
                    continue;
                }
                else if (s.Length > ns.Length)
                {
                    break;
                }
                else
                {
                    var charArray = s.ToCharArray();
                    Array.Sort(charArray);
                    bool check = true;
                    for (int j = 0; j < ns.Length; j++)
                    {
                        if (charArray[j] != ns[j])
                        {
                            check = false;
                            break;
                        }
                    }
                    if (check)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}