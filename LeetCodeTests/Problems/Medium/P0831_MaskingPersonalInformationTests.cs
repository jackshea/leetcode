using NUnit.Framework;

namespace LeetCode.Problems.Medium.Tests;

[TestFixture]
public class P0831_MaskingPersonalInformationTests
{
    [Test]
    public void MaskPIITest()
    {
        var test = new P0831_MaskingPersonalInformation();
        var input = "LeetCode@LeetCode.com";
        Assert.AreEqual("l*****e@leetcode.com", test.MaskPII(input));
    }

    [Test]
    public void MaskPIITest_1()
    {
        var test = new P0831_MaskingPersonalInformation();
        var input = "AB@qq.com";
        Assert.AreEqual("a*****b@qq.com", test.MaskPII(input));
    }

    [Test]
    public void MaskPIITest_2()
    {
        var test = new P0831_MaskingPersonalInformation();
        var input = "1(234)567-890";
        Assert.AreEqual("***-***-7890", test.MaskPII(input));
    }

    [Test]
    public void MaskPIITest_3()
    {
        var test = new P0831_MaskingPersonalInformation();
        var input = "86-(10)12345678";
        Assert.AreEqual("+**-***-***-5678", test.MaskPII(input));
    }

    [Test]
    public void MaskPIITest_4()
    {
        var test = new P0831_MaskingPersonalInformation();
        var input = "+(501321)-50-23431";
        Assert.AreEqual("+***-***-***-3431", test.MaskPII(input));
    }

    [Test]
    public void MaskPIITest_5()
    {
        var test = new P0831_MaskingPersonalInformation();
        var input = "+86(88)1513-7-74";
        Assert.AreEqual("+*-***-***-3774", test.MaskPII(input));
    }
}