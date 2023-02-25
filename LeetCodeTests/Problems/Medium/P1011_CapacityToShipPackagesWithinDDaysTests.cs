using NUnit.Framework;

namespace LeetCode.Problems.Medium.Tests;

[TestFixture]
public class P1011_CapacityToShipPackagesWithinDDaysTests
{
    [Test]
    public void DaysTest()
    {
        var test = new P1011_CapacityToShipPackagesWithinDDays();
        Assert.AreEqual(5, test.Days(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 15));
        Assert.AreEqual(5, test.Days(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 15 }, 15));
    }
}