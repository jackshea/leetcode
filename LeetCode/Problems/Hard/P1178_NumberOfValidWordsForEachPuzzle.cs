using System.Collections.Generic;

namespace LeetCode.Problems.Hard
{
    /// 猜字谜
    /// https://leetcode-cn.com/problems/number-of-valid-words-for-each-puzzle/
    public class P1178_NumberOfValidWordsForEachPuzzle
    {
        public IList<int> FindNumOfValidWords(string[] words, string[] puzzles)
        {
            Dictionary<int, int> bitMap = new Dictionary<int, int>();
            foreach (var word in words)
            {
                var bits = GetBits(word);
                bitMap.TryGetValue(bits, out var count);
                bitMap[bits] = count + 1;
            }

            IList<int> ans = new List<int>(puzzles.Length);
            for (int i = 0; i < puzzles.Length; i++)
            {
                var puzzlesBit = GetBits(puzzles[i]);
                var firstCharBit = GetBits(puzzles[i][0].ToString());
                int n = puzzlesBit;
                int sum = 0;
                while (n > 0)
                {
                    if ((n & firstCharBit) != 0 && bitMap.TryGetValue(n, out var cnt))
                    {
                        sum += cnt;
                    }

                    n = (n - 1) & puzzlesBit;
                }
                ans.Add(sum);
            }

            return ans;
        }

        private int GetBits(string word)
        {
            int bit = 0;
            foreach (var w in word)
            {
                bit |= 1 << (w - 'a');
            }

            return bit;
        }
    }
}