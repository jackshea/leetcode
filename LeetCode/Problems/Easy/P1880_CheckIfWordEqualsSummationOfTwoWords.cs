namespace LeetCode.Problems.Easy
{
    /// 检查某单词是否等于两单词之和
    /// https://leetcode-cn.com/problems/check-if-word-equals-summation-of-two-words/
    public class P1880_CheckIfWordEqualsSummationOfTwoWords
    {
        public bool IsSumEqual(string firstWord, string secondWord, string targetWord)
        {
            return WordValue(firstWord) + WordValue(secondWord) == WordValue(targetWord);
        }

        private int WordValue(string word)
        {
            int num = 0;
            foreach (var c in word)
            {
                num = num * 10 + c - 'a';
            }

            return num;
        }
    }
}