using LeetCode.Common;
using NUnit.Framework;

namespace LeetCode.Problems.Hard.Tests;

[TestFixture]
public class P0815_BusRoutesTests
{
    [Test]
    public void NumBusesToDestinationTest()
    {
        var test = new P0815_BusRoutes();
        var input = Utils.Read2DArray(" [[1,2,7],[3,6,7]]");
        Assert.AreEqual(2, test.NumBusesToDestination(input, 1, 6));
    }
}