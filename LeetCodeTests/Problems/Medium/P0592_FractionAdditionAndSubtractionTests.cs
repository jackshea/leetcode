using NUnit.Framework;

namespace LeetCode.Problems.Medium.Tests;

[TestFixture]
public class P0592_FractionAdditionAndSubtractionTests
{
    [Test]
    public void FractionAdditionTest()
    {
        var input = "-1/2+1/2";
        var test = new P0592_FractionAdditionAndSubtraction();
        var output = test.FractionAddition(input);
        Assert.AreEqual("0/1", output);
    }
}