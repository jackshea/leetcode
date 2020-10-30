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
            var nums = new int[] { 2, 2, 2, 2, 2, 4, 7 };
            var test = new P0457_CircularArrayLoop();
            var ans = test.CircularArrayLoop(nums);
            Console.WriteLine(ans);
            Console.ReadLine();
        }
    }
}
