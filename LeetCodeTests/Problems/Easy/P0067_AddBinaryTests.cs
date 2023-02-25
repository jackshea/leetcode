using LeetCode.Problems.Easy;
using NUnit.Framework;

namespace LeetCodeTests.Problems.Easy;

[TestFixture]
public class P0067_AddBinaryTests
{
    [Test]
    public void AddBinaryTest_1()
    {
        var a = "11";
        var b = "1";
        var test = new P0067_AddBinary();

        var output = test.AddBinary(a, b);

        Assert.AreEqual("100", output);
    }

    [Test]
    public void AddBinaryTest_2()
    {
        var a = "1010";
        var b = "1011";
        var test = new P0067_AddBinary();

        var output = test.AddBinary(a, b);

        Assert.AreEqual("10101", output);
    }
}