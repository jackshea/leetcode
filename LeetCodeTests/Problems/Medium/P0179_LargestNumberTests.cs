using NUnit.Framework;

namespace LeetCode.Problems.Medium.Tests;

[TestFixture]
public class P0179_LargestNumberTests
{
    [Test]
    public void LargestNumberTest()
    {
        var test = new P0179_LargestNumber();
        Assert.AreEqual("9534330", test.LargestNumber(new[] { 3, 30, 34, 5, 9 }));
    }
}