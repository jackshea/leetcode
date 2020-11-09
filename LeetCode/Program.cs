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
            var input = Utils.Read2DArray("[[1,3],[-2,2]]");
            var test = new P0973_KClosestPointsToOrigin();
            var ans = test.KClosest(input, 1);
            Console.WriteLine(ans.ListToString());
            Console.ReadLine();
        }
    }
}
