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
            var nums = new int[] { 4, 2, 7, 6, 9, 14, 12 };
            var test = new P5556();
            var ans = test.FurthestBuilding(nums, 5, 1);
            Console.WriteLine(ans);
            Console.ReadLine();
        }
    }
}
