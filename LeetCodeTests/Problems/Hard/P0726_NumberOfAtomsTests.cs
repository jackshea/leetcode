using NUnit.Framework;
using LeetCode.Problems.Hard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems.Hard.Tests
{
    [TestFixture()]
    public class P0726_NumberOfAtomsTests
    {
        [Test()]
        public void CountOfAtomsTest()
        {
            var test = new P0726_NumberOfAtoms();
            Assert.AreEqual("H2O", test.CountOfAtoms("H2O"));
        }

        [Test()]
        public void CountOfAtomsTest_1()
        {
            var test = new P0726_NumberOfAtoms();
            Assert.AreEqual("H2MgO2", test.CountOfAtoms("Mg(OH)2"));
        }

        [Test()]
        public void CountOfAtomsTest_2()
        {
            var test = new P0726_NumberOfAtoms();
            Assert.AreEqual("K4N2O14S4", test.CountOfAtoms("K4(ON(SO3)2)2"));
        }
        
        [Test()]
        public void CountOfAtomsTest_3()
        {
            var test = new P0726_NumberOfAtoms();
            Assert.AreEqual("H2MgNO", test.CountOfAtoms("Mg(H2O)N"));
        }
    }
}