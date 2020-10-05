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
            var input = 1000000000;
            var test = new P0400_NthDigit();
            var ans = test.FindNthDigit(input);
            Console.WriteLine(ans);
            Console.ReadLine();
        }
    }
}
