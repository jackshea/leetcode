using LeetCode.Problems.Easy;
using NUnit.Framework;

namespace LeetCodeTests.Problems.Easy;

[TestFixture]
public class MyHashSetTests
{
    [Test]
    public void ContainsTest()
    {
        var hashSet = new MyHashSet();
        hashSet.Add(1);
        hashSet.Add(2);
        Assert.IsTrue(hashSet.Contains(1)); // 返回 true
        Assert.IsFalse(hashSet.Contains(3)); // 返回 false (未找到)
        hashSet.Add(2);
        Assert.IsTrue(hashSet.Contains(2)); // 返回 true
        hashSet.Remove(2);
        Assert.IsFalse(hashSet.Contains(2)); // 返回  false (已经被删除)
    }
}