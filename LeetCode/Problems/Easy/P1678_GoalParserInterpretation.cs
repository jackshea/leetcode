using System.Text;

namespace LeetCode.Problems.Easy;

/// 设计 Goal 解析器
/// https://leetcode-cn.com/problems/goal-parser-interpretation/
public class P1678_GoalParserInterpretation
{
    public string Interpret(string command)
    {
        var sb = new StringBuilder();
        if (command[0] == 'G') sb.Append('G');

        for (var i = 1; i < command.Length; i++)
            if (command[i] == 'G')
                sb.Append('G');
            else if (command[i - 1] == '(' && command[i] == ')')
                sb.Append('o');
            else if (command[i - 1] == 'l' && command[i] == ')') sb.Append("al");

        return sb.ToString();
    }
}