namespace LeetCode.Problems.Easy
{
    /// 字符串中第二大的数字
    /// https://leetcode-cn.com/problems/second-largest-digit-in-a-string/
    public class P1796_SecondLargestDigitInAString
    {
        public int SecondHighest(string s)
        {
            bool[] hasNum = new bool[10];
            foreach (var c in s)
            {
                if (char.IsNumber(c))
                {
                    hasNum[c - '0'] = true;
                }
            }

            int top1 = -1;
            for (int i = 9; i >= 0; i--)
            {
                if (hasNum[i])
                {
                    if (top1 == -1)
                    {
                        top1 = i;
                    }
                    else
                    {
                        return i;
                    }
                }
            }

            return -1;
        }
    }
}