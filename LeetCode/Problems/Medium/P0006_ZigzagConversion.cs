using System.Text;

namespace LeetCode.Problems.Medium;

/// Z 字形变换
/// https://leetcode-cn.com/problems/zigzag-conversion/
public class P0006_ZigzagConversion
{
    public string Convert(string s, int numRows)
    {
        if (numRows <= 1 || s.Length <= numRows) return s;

        var rows = new StringBuilder[numRows];
        for (var i = 0; i < rows.Length; i++) rows[i] = new StringBuilder();
        var curRow = 0;
        var dir = 1;
        foreach (var c in s)
        {
            rows[curRow].Append(c);
            curRow += dir;
            if (curRow == 0)
                dir = 1;
            else if (curRow == numRows - 1) dir = -1;
        }

        var ans = new StringBuilder();
        foreach (var r in rows) ans.Append(r);

        return ans.ToString();
    }
}