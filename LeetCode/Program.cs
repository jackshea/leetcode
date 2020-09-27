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
            var input = "ababbc";
            var test = new P0395_LongestSubstringWithAtLeastKRepeatingCharacters();
            var ans = test.LongestSubstring(input, 2);
            Console.WriteLine(ans);
            Console.ReadLine();
        }
    }
}
