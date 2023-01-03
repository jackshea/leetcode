namespace LeetCode.Problems.Medium
{
    /// 检查句子中的数字是否递增
    /// https://leetcode.cn/problems/check-if-numbers-are-ascending-in-a-sentence/
    public class P2042_CheckIfNumbersAreAscendingInASentence
    {
        public bool AreNumbersAscending(string s)
        {
            string[] words = s.Split(' ');
            int last = 0;
            foreach (var word in words)
            {
                if (int.TryParse(word, out var number))
                {
                    if (number > last)
                    {
                        last = number;
                    }
                    else
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}