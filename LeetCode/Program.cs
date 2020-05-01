using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCode.Common;
using LeetCode.Problems;
using LeetCode.Problems.Easy;
using LeetCode.Problems.Hard;
using LeetCode.Problems.Medium;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            PriorityQueue<int> pq = new PriorityQueue<int>();
            pq.Push(1);
            pq.Push(3);
            pq.Push(2);
            pq.Push(1);

            while (pq.Count != 0)
            {
                Console.Write(pq.Pop() + " ");
            }

            Console.ReadLine();
        }
    }
}
