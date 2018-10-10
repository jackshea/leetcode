using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCode.Problems;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = new P0014_LongestCommonPrefix();
            Console.WriteLine(test.LongestCommonPrefix(new string[] { "flower", "flow", "flight" }));
            Console.ReadLine();
        }
    }
}
