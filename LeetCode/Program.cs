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
            //var nums = new int[] { 4, 2, 7, 6, 9, 14, 12 };
            string inputIntervals = "[[1,2],[3,5],[6,7],[8,10],[12,16]]";
            int[][] intervals = Utils.Read2DArray(inputIntervals);
            var test = new P0057_InsertInterval();
            var ans = test.Insert(intervals, new[] { 4, 8 });
            Console.WriteLine(ans);
            Console.ReadLine();
        }
    }
}
