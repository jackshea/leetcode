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
            var input = new int[] { 197, 130, 1 };
            var test = new P0393_Utf8Validation();
            var ans = test.ValidUtf8(input);
            Console.WriteLine(ans);
            Console.ReadLine();
        }
    }
}
