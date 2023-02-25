using System.Collections.Generic;

namespace LeetCode.Problems.Medium;

/// Dota2 参议院
/// https://leetcode-cn.com/problems/dota2-senate/
public class P0649_Dota2Senate
{
    public string PredictPartyVictory(string senate)
    {
        var rq = new Queue<int>();
        var dq = new Queue<int>();
        for (var i = 0; i < senate.Length; i++)
        {
            var c = senate[i];
            if (c == 'R')
                rq.Enqueue(i);
            else
                dq.Enqueue(i);
        }

        while (rq.Count > 0 && dq.Count > 0)
            if (rq.Peek() < dq.Peek())
            {
                rq.Enqueue(rq.Dequeue() + senate.Length);
                dq.Dequeue();
            }
            else
            {
                rq.Dequeue();
                dq.Enqueue(dq.Dequeue() + senate.Length);
            }

        if (rq.Count > 0) return "Radiant";

        return "Dire";
    }
}