using System;

namespace LeetCode.Problems.Medium
{
    /// 比较版本号
    /// https://leetcode-cn.com/problems/compare-version-numbers/
    public class P0165_CompareVersionNumbers
    {
        public int CompareVersion(string version1, string version2)
        {
            var split1 = version1.Split('.');
            var split2 = version2.Split('.');
            int maxLen = Math.Max(split1.Length, split2.Length);
            for (int i = 0; i < maxLen; i++)
            {
                int v1 = 0;
                if (i < split1.Length)
                {
                    v1 = int.Parse(split1[i]);
                }

                int v2 = 0;
                if (i < split2.Length)
                {
                    v2 = int.Parse(split2[i]);
                }

                if (v1 != v2)
                {
                    return v1.CompareTo(v2);
                }
            }

            return 0;
        }
    }
}