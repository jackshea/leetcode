using LeetCode.Common;
using NUnit.Framework;

namespace LeetCode.Contest.Biweekly.C045.Tests;

[TestFixture]
public class P5660Tests
{
    [Test]
    public void MaxValueTest()
    {
        var test = new P5660();
        var input = Utils.Read2DArray("[[1,2,4],[3,4,3],[2,3,1]]");
        Assert.AreEqual(7, test.MaxValue(input, 2));
    }

    [Test]
    public void MaxValueTest1()
    {
        var test = new P5660();
        var input = Utils.Read2DArray("[[1,2,4],[3,4,3],[2,3,10]]");
        Assert.AreEqual(10, test.MaxValue(input, 2));
    }

    [Test]
    public void MaxValueTest2()
    {
        var test = new P5660();
        var input = Utils.Read2DArray("[[1,1,1],[2,2,2],[3,3,3],[4,4,4]]");
        Assert.AreEqual(9, test.MaxValue(input, 3));
    }
}