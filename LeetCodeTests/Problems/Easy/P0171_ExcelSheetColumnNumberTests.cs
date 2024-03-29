﻿using LeetCode.Problems.Easy;
using NUnit.Framework;

namespace LeetCodeTests.Problems.Easy;

[TestFixture]
public class P0171_ExcelSheetColumnNumberTests
{
    [Test]
    public void TitleToNumberTest()
    {
        var test = new P0171_ExcelSheetColumnNumber();
        var title = new P0168_ExcelSheetColumnTitle();

        for (var i = 1; i < 26 * 26 * 26 + 1; i++) Assert.AreEqual(i, test.TitleToNumber(title.ConvertToTitle(i)));
    }
}