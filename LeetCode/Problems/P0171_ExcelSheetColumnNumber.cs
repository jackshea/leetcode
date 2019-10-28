namespace LeetCode.Problems
{
    public class P0171_ExcelSheetColumnNumber
    {
        public int TitleToNumber(string s)
        {
            int sum = 0;
            for (var i = 0; i < s.Length; i++)
            {
                sum *= 26;
                sum += s[i] - 'A' + 1;
            }

            return sum;
        }
    }
}