using LeetCode.Common;
using NUnit.Framework;

namespace LeetCode.Problems.Hard.Tests;

[TestFixture]
public class CodecTests
{
    [Test]
    public void serializeTest()
    {
        int?[] a = { 1, 2, 3, null, null, 4, 5 };
        var bt = Utils.BuildBinaryTree(a);
        var test = new Codec();
        Assert.AreEqual("1,2,#,#,3,4,#,#,5,#,#,", test.serialize(bt));
    }
}