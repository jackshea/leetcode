using NUnit.Framework;

namespace LeetCode.Problems.Medium.Tests;

[TestFixture]
public class P0609_FindDuplicateFileInSystemTests
{
    [Test]
    public void FindDuplicateTest()
    {
        var test = new P0609_FindDuplicateFileInSystem();
        string[] input =
            { "root/a 1.txt(abcd) 2.txt(efgh)", "root/c 3.txt(abcd)", "root/c/d 4.txt(efgh)", "root 4.txt(efgh)" };
        var output = test.FindDuplicate(input);
        Assert.AreEqual(2, output.Count);
    }

    [Test]
    public void FindDuplicateTest1()
    {
        var test = new P0609_FindDuplicateFileInSystem();
        string[] input = { "root/a 1.txt(abcd) 2.txt(efsfgh)", "root/c 3.txt(abdfcd)", "root/c/d 4.txt(efggdfh)" };
        var output = test.FindDuplicate(input);
        Assert.AreEqual(0, output.Count);
    }
}