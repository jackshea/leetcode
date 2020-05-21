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
            var test = new MST1622();
            var ans = test.PrintKMoves(100000);
            foreach (var row in ans)
            {
                Console.WriteLine(row);
            }

            Console.ReadLine();
        }
    }
}
