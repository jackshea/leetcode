using NUnit.Framework;
using LeetCode.Problems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems.Tests
{
    [TestFixture()]
    public class P0202_HappyNumberTests
    {
        [Test()]
        public void NextTest()
        {
            int n = 19;

            int next = new P0202_HappyNumber().Next(n);

            Assert.AreEqual(82, next);

            next = new P0202_HappyNumber().Next(next);
            Assert.AreEqual(68, next);

            next = new P0202_HappyNumber().Next(next);
            Assert.AreEqual(100, next);

            next = new P0202_HappyNumber().Next(next);
            Assert.AreEqual(1, next);
        }

        [Test()]
        public void IsHappyTest()
        {
            Assert.IsTrue(new P0202_HappyNumber().IsHappy(19));
        }
    }
}