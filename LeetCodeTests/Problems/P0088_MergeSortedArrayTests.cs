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
    public class P0088_MergeSortedArrayTests
    {
        [Test()]
        public void MergeTest_1()
        {
            int[] nums1 = { 1, 2, 3, 0, 0, 0 };
            int m = 3;
            int[] nums2 = { 2, 5, 6 };
            int n = 3;

            var test = new P0088_MergeSortedArray();
            test.Merge(nums1, m, nums2, n);

            Assert.AreEqual(new[] { 1, 2, 2, 3, 5, 6 }, nums1);
        }

        [Test()]
        public void MergeTest_2()
        {
            int[] nums1 = { 0 };
            int m = 0;
            int[] nums2 = { 1 };
            int n = 1;

            var test = new P0088_MergeSortedArray();
            test.Merge(nums1, m, nums2, n);

            Assert.AreEqual(new[] { 1 }, nums1);
        }
    }
}