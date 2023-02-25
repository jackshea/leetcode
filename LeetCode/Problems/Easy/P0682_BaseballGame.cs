using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Problems.Easy;

/// 棒球比赛
/// https://leetcode-cn.com/problems/baseball-game/
public class P0682_BaseballGame
{
    public int CalPoints(string[] ops)
    {
        var score = new Stack<int>();
        foreach (var op in ops)
            switch (op)
            {
                case "+":
                    var temp = score.Pop();
                    var currentScore = temp + score.Peek();
                    score.Push(temp);
                    score.Push(currentScore);
                    break;
                case "D":
                    score.Push(score.Peek() * 2);
                    break;
                case "C":
                    score.Pop();
                    break;
                default:
                    score.Push(int.Parse(op));
                    break;
            }

        return score.Sum();
    }
}