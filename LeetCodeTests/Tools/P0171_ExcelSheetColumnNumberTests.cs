using NUnit.Framework;
using LeetCode.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCode.Problems;

namespace LeetCode.Tools.Tests
{
    [TestFixture()]
    public class P0171_ExcelSheetColumnNumberTests
    {
        [Test()]
        public void TitleToNumberTest()
        {
            var test = new P0171_ExcelSheetColumnNumber();
            var title = new P0168_ExcelSheetColumnTitle();

            for (int i = 1; i < 26 * 26 * 26 + 1; i++)
            {
                Assert.AreEqual(i, test.TitleToNumber(title.ConvertToTitle(i)));
            }
        }
    }
}