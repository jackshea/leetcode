﻿using System;
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
            var test = new P0467_UniqueSubstringsInWraparoundString();
            var ans = test.FindSubstringInWraproundString("zab");
            Console.WriteLine(ans);
            Console.ReadLine();
        }
    }
}
