using LeetCode.Problems.Easy;
using NUnit.Framework;

namespace LeetCodeTests.Problems.Easy;

[TestFixture]
public class P0219_ContainsDuplicateIITests
{
    [Test]
    public void ContainsNearbyDuplicateTest()
    {
        var input = new[] { 1, 0, 1, 1 };
        var k = 1;

        Assert.IsTrue(new P0219_ContainsDuplicateII().ContainsNearbyDuplicate(input, k));
    }
}