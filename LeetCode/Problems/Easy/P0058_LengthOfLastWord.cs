namespace LeetCode.Problems.Easy
{
    /// 最后一个单词的长度
    /// https://leetcode-cn.com/problems/length-of-last-word/description/
    public class P0058_LengthOfLastWord
    {
        public int LengthOfLastWord(string s)
        {
            int length = 0;
            bool reset = false;
            foreach (char c in s)
            {
                if (c != ' ')
                {
                    length = reset ? 1 : length + 1;
                    reset = false;
                }
                else
                {
                    reset = true;
                }
            }

            return length;
        }
    }
}