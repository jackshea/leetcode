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
            var input = "dir\n\tsubdir1\n\tsubdir2\n\t\tfile.ext";
            var test = new P0388_LongestAbsoluteFilePath();
            var ans = test.LengthLongestPath(input);
            Console.WriteLine(ans);
            Console.ReadLine();
        }
    }
}
