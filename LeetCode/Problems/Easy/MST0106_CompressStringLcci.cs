﻿using System.Text;

namespace LeetCode.Problems.Easy
{
    /// 面试题 01.06. 字符串压缩
    /// https://leetcode-cn.com/problems/compress-string-lcci/
    public class MST0106_CompressStringLcci
    {
        public string CompressString(string S)
        {
            StringBuilder sb = new StringBuilder();
            int count = 1;
            for (var i = 0; i < S.Length; i++)
            {
                if (i == S.Length - 1 || S[i] != S[i + 1])
                {
                    sb.Append(S[i]).Append(count);
                    count = 1;
                }
                else
                {
                    count++;
                }
            }

            if (sb.Length < S.Length)
            {
                return sb.ToString();
            }

            return S;
        }
    }
}