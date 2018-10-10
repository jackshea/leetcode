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
            var test = new P0013_RomanToInteger();
            Console.WriteLine(test.RomanToInt("MCMXCIV"));
            Console.ReadLine();
        }
    }
}
