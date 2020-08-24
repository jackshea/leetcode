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
            var input = new List<IList<string>>
            {
                new List<string> {"JFK", "KUL"},
                new List<string> {"JFK", "NRT"},
                new List<string> {"NRT", "JFK"}
            };
            var test = new P0332_ReconstructItinerary();
            var ans = test.FindItinerary(input);
            Console.WriteLine(ans);
            Console.ReadLine();
        }
    }
}
