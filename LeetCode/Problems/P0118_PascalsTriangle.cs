using System.Collections.Generic;

namespace LeetCode.Problems
{
    /// 杨辉三角
    /// https://leetcode-cn.com/problems/pascals-triangle/description/
    public class P0118_PascalsTriangle
    {
        public IList<IList<int>> Generate(int numRows)
        {
            if (numRows <= 0)
            {
                return new List<IList<int>>();
            }

            var result = new List<IList<int>>();
            result.Add(new List<int> { 1 });

            for (int i = 1; i < numRows; i++)
            {
                var lastRow = result[i - 1];
                var newRow = new List<int>();
                newRow.Add(1);
                for (int j = 1; j < i; j++)
                {
                    newRow.Add(lastRow[j - 1] + lastRow[j]);
                }
                newRow.Add(1);
                result.Add(newRow);
            }

            return result;
        }
    }
}