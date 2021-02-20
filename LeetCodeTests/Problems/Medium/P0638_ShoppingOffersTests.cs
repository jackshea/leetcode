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
    public class P0638_ShoppingOffersTests
    {
        [Test()]
        public void ShoppingOffersTest()
        {
            var test = new P0638_ShoppingOffers();
            Assert.AreEqual(14, test.ShoppingOffers(new List<int> { 2, 5 },
                Utils.Read2DArray("[[3,0,5],[1,2,10]]"), new List<int> { 3, 2 }));
        }
    }
}