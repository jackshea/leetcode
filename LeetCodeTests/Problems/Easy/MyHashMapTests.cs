﻿using LeetCode.Problems.Easy;
using NUnit.Framework;

namespace LeetCodeTests.Problems.Easy;

[TestFixture]
public class MyHashMapTests
{
    [Test]
    public void GetTest()
    {
        var hashMap = new MyHashMap();
        hashMap.Put(1, 1);
        hashMap.Put(2, 2);
        Assert.AreEqual(1, hashMap.Get(1)); // 返回 1
        Assert.AreEqual(-1, hashMap.Get(3)); // 返回 -1 (未找到)
        hashMap.Put(2, 1); // 更新已有的值
        Assert.AreEqual(1, hashMap.Get(2)); // 返回 1 
        hashMap.Remove(2); // 删除键为2的数据
        Assert.AreEqual(-1, hashMap.Get(2)); // 返回 -1 (未找到) 

        hashMap.Put(10001 + 1, 2);
        hashMap.Put(3 * 10001 + 1, 3);
        hashMap.Remove(10001 + 1);
        Assert.AreEqual(-1, hashMap.Get(10001 + 1)); // 返回 -1 (未找到)
    }
}