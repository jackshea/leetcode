﻿using System.Collections.Generic;

namespace LeetCode.Problems.Medium;

/// TinyURL 的加密与解密
/// https://leetcode-cn.com/problems/encode-and-decode-tinyurl/
public class Codec
{
    private const string baseUrl = "http://tinyurl.com/";
    private readonly Dictionary<int, string> dic = new();
    private int id;

    // Encodes a URL to a shortened URL
    public string encode(string longUrl)
    {
        dic[++id] = longUrl;
        return baseUrl + id;
    }

    // Decodes a shortened URL to its original URL.
    public string decode(string shortUrl)
    {
        var getId = int.Parse(shortUrl.Substring(baseUrl.Length));
        dic.TryGetValue(getId, out var url);
        return url;
    }
}