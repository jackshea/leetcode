using LeetCode.Common;
using NUnit.Framework;

namespace LeetCode.Problems.Hard.Tests;

[TestFixture]
public class P0778_SwimInRisingWaterTests
{
    [Test]
    public void SwimInWaterTest()
    {
        var test = new P0778_SwimInRisingWater1();
        var input = Utils.Read2DArray("[[0,2],[1,3]]");
        Assert.AreEqual(3, test.SwimInWater(input));
    }

    [Test]
    public void SwimInWaterTest_2()
    {
        var test = new P0778_SwimInRisingWater1();
        var input = Utils.Read2DArray("[[0,1,2,3,4],[24,23,22,21,5],[12,13,14,15,16],[11,17,18,19,20],[10,9,8,7,6]]");
        Assert.AreEqual(16, test.SwimInWater(input));
    }

    [Test]
    public void SwimInWaterTest_3()
    {
        var test = new P0778_SwimInRisingWater1();
        var input = Utils.Read2DArray("[[3,2],[0,1]]");
        Assert.AreEqual(3, test.SwimInWater(input));
    }
}