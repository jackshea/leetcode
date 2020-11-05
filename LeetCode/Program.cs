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
            var beginWord = "hit";
            var endWord = "cog";
            var wordList = new string[] { "hot", "dot", "dog", "lot", "log", "cog" };
            var test = new P0127_WordLadder();
            var ans = test.LadderLength(beginWord, endWord, wordList);
            Console.WriteLine(ans);
            Console.ReadLine();
        }
    }
}
