using LeetCode.Problems.Easy;
using NUnit.Framework;

namespace LeetCodeTests.Problems.Easy
{
    [TestFixture()]
    public class P0205_IsomorphicStringsTests
    {
        [Test()]
        public void IsIsomorphicTest()
        {
            string s = "egg";
            string t = "add";

            var isIsomorphic = new P0205_IsomorphicStrings().IsIsomorphic(s, t);

            Assert.IsTrue(isIsomorphic);
        }

        [Test()]
        public void IsIsomorphicTest_1()
        {
            string s = "foo";
            string t = "bar";

            var isIsomorphic = new P0205_IsomorphicStrings().IsIsomorphic(s, t);

            Assert.IsFalse(isIsomorphic);
        }

        [Test()]
        public void IsIsomorphicTest_2()
        {
            string s = "paper";
            string t = "title";

            var isIsomorphic = new P0205_IsomorphicStrings().IsIsomorphic(s, t);

            Assert.IsTrue(isIsomorphic);
        }

        [Test()]
        public void IsIsomorphicTest_3()
        {
            string s = "ab";
            string t = "aa";

            var isIsomorphic = new P0205_IsomorphicStrings().IsIsomorphic(s, t);

            Assert.IsFalse(isIsomorphic);
        }
    }
}