using NUnit.Framework;
using LeetCode.Problems.Hard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCode.Common;

namespace LeetCode.Problems.Hard.Tests
{
    [TestFixture()]
    public class CodecTests
    {
        [Test()]
        public void serializeTest()
        {
            int?[] a = new int?[] { 1, 2, 3, null, null, 4, 5 };
            var bt = ConvertArrayToBinaryTree.Build(a);
            var test = new Codec();
            Assert.AreEqual("1,2,#,#,3,4,#,#,5,#,#,", test.serialize(bt));
        }
    }
}