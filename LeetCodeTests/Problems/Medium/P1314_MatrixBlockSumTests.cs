using NUnit.Framework;
using LeetCode.Problems.Medium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCode.Common;

namespace LeetCode.Problems.Medium.Tests
{
    [TestFixture()]
    public class P1314_MatrixBlockSumTests
    {
        [Test()]
        public void MatrixBlockSumTest()
        {
            var input = Utils.Read2DArray("[[1,2,3],[4,5,6],[7,8,9]]");
            var test = new P1314_MatrixBlockSum();
            var ans = test.MatrixBlockSum(input, 1);
            CollectionAssert.AreEqual(Utils.Read2DArray("[[12,21,16],[27,45,33],[24,39,28]]"), ans);
        }
    }
}