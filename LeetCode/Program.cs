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
            var inputArray = new int[] {1,2,3,4,5};
            var input = Utils.BuildList(inputArray);
            var test = new P0328_OddEvenLinkedList();
            var ans = test.OddEvenList(input);
            var ansArray = Utils.ListToArray(ans);
            foreach (var i in ansArray)
            {
                Console.Write(i+" ");
            }
        }
    }
}
