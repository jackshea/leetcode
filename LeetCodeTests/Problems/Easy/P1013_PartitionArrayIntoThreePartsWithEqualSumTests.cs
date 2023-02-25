using LeetCode.Problems.Easy;
using NUnit.Framework;

namespace LeetCodeTests.Problems.Easy;

[TestFixture]
public class P1013_PartitionArrayIntoThreePartsWithEqualSumTests
{
    [Test]
    public void CanThreePartsEqualSumTest()
    {
        var test = new P1013_PartitionArrayIntoThreePartsWithEqualSum();
        Assert.IsTrue(test.CanThreePartsEqualSum(new[] { 0, 2, 1, -6, 6, -7, 9, 1, 2, 0, 1 }));
    }
}