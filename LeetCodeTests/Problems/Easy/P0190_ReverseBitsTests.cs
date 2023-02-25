using LeetCode.Problems.Easy;
using NUnit.Framework;

namespace LeetCodeTests.Problems.Easy;

[TestFixture]
public class P0190_ReverseBitsTests
{
    [Test]
    public void reverseBitsTest()
    {
        uint input = 43261596;

        var reverseBits = new P0190_ReverseBits().reverseBits(input);

        Assert.AreEqual(964176192, reverseBits);
    }

    [Test]
    public void reverseBitsTest_2()
    {
        var input = 4294967293;

        var reverseBits = new P0190_ReverseBits().reverseBits(input);

        Assert.AreEqual(3221225471, reverseBits);
    }
}