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
            var test = new P0028_ImplementStrstr();
            Console.WriteLine(test.StrStr("mississippi", "issipi"));
            Console.ReadLine();
        }
    }
}
