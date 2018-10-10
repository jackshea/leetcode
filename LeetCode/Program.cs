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
            var test = new P0035_SearchInsertPosition();
            Console.WriteLine(test.SearchInsert(new[] { 1, 3, 5, 6 }, 5));
            Console.WriteLine(test.SearchInsert(new[] { 1, 3, 5, 6 }, 2));
            Console.WriteLine(test.SearchInsert(new[] { 1, 3, 5, 6 }, 7));
            Console.WriteLine(test.SearchInsert(new[] { 1, 3, 5, 6 }, 0));
            Console.ReadLine();
        }
    }
}
