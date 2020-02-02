namespace LeetCode.Problems.Easy
{
    /// 写字符串需要的行数
    /// https://leetcode-cn.com/problems/number-of-lines-to-write-string/
    public class P0806_NumberOfLinesToWriteString
    {
        private const int LineWidth = 100;
        public int[] NumberOfLines(int[] widths, string S)
        {
            int remainWidth = LineWidth;
            int lines = 1;
            foreach (var c in S)
            {
                var needWidth = widths[c-'a'];
                if (remainWidth>= needWidth)
                {
                    remainWidth -= needWidth;
                }
                else
                {
                    lines++;
                    remainWidth = LineWidth - needWidth;
                }
            }

            return new int[]{ lines, LineWidth - remainWidth };
        }
    }
}