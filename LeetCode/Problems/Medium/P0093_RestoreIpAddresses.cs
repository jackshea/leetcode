using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems.Medium;

/// 复原IP地址
/// https://leetcode-cn.com/problems/restore-ip-addresses/
public class P0093_RestoreIpAddresses
{
    private readonly List<string> ans = new();
    private readonly int[] ipAddr = new int[4];

    public IList<string> RestoreIpAddresses(string s)
    {
        DFS(0, 0, s);
        return ans;
    }

    private void DFS(int ipIndex, int sIndex, string s)
    {
        if (ipIndex >= 4)
        {
            if (sIndex >= s.Length) ans.Add(ToString(ipAddr));
            return;
        }

        for (var i = sIndex; i < sIndex + 3; i++)
        {
            var num = ToIpNumber(s, sIndex, i);
            if (num >= 0)
            {
                ipAddr[ipIndex] = num;
                DFS(ipIndex + 1, i + 1, s);
            }
        }
    }

    private string ToString(int[] ipAddr)
    {
        var sb = new StringBuilder();
        for (var i = 0; i < ipAddr.Length; i++)
        {
            if (i != 0) sb.Append('.');

            sb.Append(ipAddr[i]);
        }

        return sb.ToString();
    }

    private int ToIpNumber(string s, int start, int end)
    {
        if (end >= s.Length) return -1;
        var len = end - start + 1;
        if (len < 1 || len > 3) return -1;
        if (len != 1 && s[start] == '0') return -1;

        var num = Convert.ToInt32(s.Substring(start, len));
        if (num < 0 || num > 255) return -1;

        return num;
    }
}