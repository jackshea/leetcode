using NUnit.Framework;

namespace LeetCode.Problems.Medium.Tests;

[TestFixture]
public class P0264_UglyNumberIITests
{
    [Test]
    public void NthUglyNumberTest()
    {
        var test = new P0264_UglyNumberII();
        var actual = test.NthUglyNumber(10);
        Assert.AreEqual(12, actual);
    }
}