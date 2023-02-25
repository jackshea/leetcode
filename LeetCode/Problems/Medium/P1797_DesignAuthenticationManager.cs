using System.Collections.Generic;

namespace LeetCode.Problems.Medium;

/// 设计一个验证系统
/// https://leetcode.cn/problems/design-authentication-manager/
public class AuthenticationManager
{
    private readonly Dictionary<string, int> dic = new();
    private readonly int timeToLive;

    public AuthenticationManager(int timeToLive)
    {
        this.timeToLive = timeToLive;
    }

    public void Generate(string tokenId, int currentTime)
    {
        dic[tokenId] = currentTime + timeToLive;
    }

    public void Renew(string tokenId, int currentTime)
    {
        if (dic.TryGetValue(tokenId, out var expireTime) && expireTime > currentTime)
            dic[tokenId] = currentTime + timeToLive;
    }

    public int CountUnexpiredTokens(int currentTime)
    {
        var count = 0;
        var expireKeys = new List<string>();
        foreach (var kvp in dic)
            if (kvp.Value > currentTime)
                count++;
            else
                expireKeys.Add(kvp.Key);
        foreach (var expireKey in expireKeys) dic.Remove(expireKey);

        return count;
    }
}