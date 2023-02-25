using LeetCode.Problems.Easy;
using NUnit.Framework;

namespace LeetCodeTests.Problems.Easy;

[TestFixture]
public class P0849_MaximizeDistanceToClosestPersonTests
{
    [Test]
    public void MaxDistToClosestTest()
    {
        var test = new P0849_MaximizeDistanceToClosestPerson();
        var ans = test.MaxDistToClosest(new[] { 1, 0, 0, 0, 1, 0, 1 });
        Assert.AreEqual(2, ans);
    }

    [Test]
    public void MaxDistToClosestTest1()
    {
        var test = new P0849_MaximizeDistanceToClosestPerson();
        var ans = test.MaxDistToClosest(new[] { 1, 0, 0, 0 });
        Assert.AreEqual(3, ans);
    }

    [Test]
    public void MaxDistToClosestTest2()
    {
        var test = new P0849_MaximizeDistanceToClosestPerson();
        var ans = test.MaxDistToClosest(new[] { 0, 1 });
        Assert.AreEqual(1, ans);
    }

    [Test]
    public void MaxDistToClosestTest3()
    {
        var test = new P0849_MaximizeDistanceToClosestPerson();
        var ans = test.MaxDistToClosest(new[] { 0, 0, 1 });
        Assert.AreEqual(2, ans);
    }
}