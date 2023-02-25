using NUnit.Framework;

namespace LeetCode.Problems.Medium.Tests;

[TestFixture]
public class P0838_PushDominoesTests
{
    [Test]
    public void PushDominoesTest()
    {
        var test = new P0838_PushDominoes();
        Assert.AreEqual("LL.RR.LLRRLL..", test.PushDominoes(".L.R...LR..L.."));
    }

    [Test]
    public void PushDominoesTest1()
    {
        var test = new P0838_PushDominoes();
        Assert.AreEqual("L.....RRRRLLLLLLL.RR", test.PushDominoes("L.....RR.RL.....L.R."));
    }
}