using System;
using System.Collections;
using System.Collections.Generic;

namespace LeetCode.Problems.Medium
{
    /// 文件的最长绝对路径
    /// https://leetcode-cn.com/problems/longest-absolute-file-path/
    public class P0388_LongestAbsoluteFilePath
    {
        public int LengthLongestPath(string input)
        {
            Dictionary<int, int> depth2Length = new Dictionary<int, int>();
            depth2Length[-1] = 0;
            depth2Length[0] = 0;
            int t = 0;
            bool isFile = false;
            int ans = 0;
            int length = 0;
            foreach (var c in input)
            {
                if (c == '\n')
                {
                    if (isFile)
                    {
                        ans = Math.Max(ans, depth2Length[t - 1] + length);
                    }
                    else
                    {
                        depth2Length[t] = depth2Length[t - 1] + length + 1;
                    }
                    t = 0;
                    isFile = false;
                    length = 0;
                    continue;
                }

                if (c == '\t')
                {
                    t++;
                    continue;
                }

                if (c == '.')
                {
                    isFile = true;
                }

                length++;
            }

            if (isFile)
            {
                ans = Math.Max(ans, depth2Length[t - 1] + length);
            }

            return ans;
        }
    }
}