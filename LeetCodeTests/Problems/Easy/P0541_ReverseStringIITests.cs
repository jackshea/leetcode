using LeetCode.Problems.Easy;
using NUnit.Framework;

namespace LeetCodeTests.Problems.Easy;

[TestFixture]
public class P0541_ReverseStringIITests
{
    [Test]
    public void ReverseStrTest()
    {
        var test = new P0541_ReverseStringII();

        Assert.AreEqual("gfedcba", test.ReverseStr("abcdefg", 8));
    }
}