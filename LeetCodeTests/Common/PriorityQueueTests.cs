using NUnit.Framework;
using LeetCode.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Common.Tests
{
    [TestFixture()]
    public class PriorityQueueTests
    {
        [Test()]
        public void PriorityQueueTest()
        {
            PriorityQueue<int> pq = new PriorityQueue<int>();
            int[] input = { 1, 2, 3, 4, 5, 4, 3, 2, 1 };
            foreach (var i in input)
            {
                pq.Push(i);
            }

            int[] ans = input;
            for (int i = 0; i < ans.Length; i++)
            {
                ans[i] = pq.Pop();
            }

            Assert.AreEqual(new int[] { 5, 4, 4, 3, 3, 2, 2, 1, 1 }, ans);
        }

        [Test()]
        public void PriorityQueueTest1()
        {
            PriorityQueue<int> pq = new PriorityQueue<int>(9, Comparer<int>.Create(((a, b) => -a.CompareTo(b))));
            int[] input = { 1, 2, 3, 4, 5, 4, 3, 2, 1 };
            foreach (var i in input)
            {
                pq.Push(i);
            }

            int[] ans = input;
            for (int i = 0; i < ans.Length; i++)
            {
                ans[i] = pq.Pop();
            }

            Assert.AreEqual(new int[] { 1, 1, 2, 2, 3, 3, 4, 4, 5 }, ans);
        }

    }
}