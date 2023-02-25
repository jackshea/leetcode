using LeetCode.Problems.Easy;
using NUnit.Framework;

namespace LeetCodeTests.Problems.Easy;

[TestFixture]
public class P0205_IsomorphicStringsTests
{
    [Test]
    public void IsIsomorphicTest()
    {
        var s = "egg";
        var t = "add";

        var isIsomorphic = new P0205_IsomorphicStrings().IsIsomorphic(s, t);

        Assert.IsTrue(isIsomorphic);
    }

    [Test]
    public void IsIsomorphicTest_1()
    {
        var s = "foo";
        var t = "bar";

        var isIsomorphic = new P0205_IsomorphicStrings().IsIsomorphic(s, t);

        Assert.IsFalse(isIsomorphic);
    }

    [Test]
    public void IsIsomorphicTest_2()
    {
        var s = "paper";
        var t = "title";

        var isIsomorphic = new P0205_IsomorphicStrings().IsIsomorphic(s, t);

        Assert.IsTrue(isIsomorphic);
    }

    [Test]
    public void IsIsomorphicTest_3()
    {
        var s = "ab";
        var t = "aa";

        var isIsomorphic = new P0205_IsomorphicStrings().IsIsomorphic(s, t);

        Assert.IsFalse(isIsomorphic);
    }
}