using NUnit.Framework;
using LeetCode.Contest.Biweekly.C046;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCode.Common;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace LeetCode.Contest.Biweekly.C046.Tests
{
    [TestFixture()]
    public class P5669Tests
    {
        [Test()]
        public void CanChooseTest()
        {
            var test = new P5669();
            var groups =
                Utils.Read2DArray(
                    "[[6636698,4693069,-2178984,-2253405,-2732131,8550889,-2324014,-2561263],[-8973571,-9146179,7704305,-1063430,-6569826],[2791091],[-9691134,651171,9835817,4163881,4944714,8166788,-9025553,-9250995,1599781]]");
            Assert.IsTrue(test.CanChoose(groups, new[] { 8550889, -2178984, 6636698, 4693069, -2178984, -2253405, -2732131, 8550889, -2324014, -2561263, -2324014, 8550889, -8973571, -9146179, 7704305, -1063430, -6569826, 2791091, -9691134, 651171, 9835817, 4163881, 4944714, 8166788, -9025553, -9250995, 1599781 }));
        }

        [Test()]
        public void CanChooseTest1()
        {
            var test = new P5669();
            var groups = Utils.Read2DArray("[[1,-1,-1],[3,-2,0]]");
            Assert.IsTrue(test.CanChoose(groups, new[] { 1, -1, 0, 1, -1, -1, 3, -2, 0 }));
        }

        [Test()]
        public void CanChooseTest2()
        {
            var test = new P5669();
            var groups = Utils.Read2DArray("[[10,-2],[1,2,3,4]]");
            Assert.IsFalse(test.CanChoose(groups, new[] { 1, 2, 3, 4, 10, -2 }));
        }

        [Test()]
        public void CanChooseTest3()
        {
            var test = new P5669();
            var groups = Utils.Read2DArray("[[1,2,3],[3,4]]");
            Assert.IsFalse(test.CanChoose(groups, new[] { 7, 7, 1, 2, 3, 4, 7, 7 }));
        }
    }
}