using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            var test = new P0079_WordSearch();
            char[][] board = {
                new []{'A', 'B', 'C', 'E'},
                new []{'S', 'F', 'C', 'S'},
                new []{'A', 'D', 'E', 'E'}
                };
            test.Exist(board, "ABCCED");
        }
    }
}
