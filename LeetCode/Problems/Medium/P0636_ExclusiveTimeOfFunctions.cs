using System.Collections.Generic;

namespace LeetCode.Problems.Medium;

/// 函数的独占时间
/// https://leetcode-cn.com/problems/exclusive-time-of-functions/
public class P0636_ExclusiveTimeOfFunctions
{
    public int[] ExclusiveTime(int n, IList<string> logs)
    {
        var spends = new int[n];
        var stack = new Stack<LogItem>();
        stack.Push(new LogItem(logs[0]));
        var preTime = stack.Peek().Time;

        for (var i = 1; i < logs.Count; i++)
        {
            var logItem = new LogItem(logs[i]);
            if (logItem.Action == "start")
            {
                if (stack.Count != 0) spends[stack.Peek().Id] += logItem.Time - preTime;
                stack.Push(logItem);
                preTime = logItem.Time;
            }
            else
            {
                spends[logItem.Id] += logItem.Time - preTime + 1;
                stack.Pop();
                preTime = logItem.Time + 1;
            }
        }

        return spends;
    }

    public class LogItem
    {
        public string Action;
        public int Id;
        public int Time;

        public LogItem(string log)
        {
            var split = log.Split(':');
            Id = int.Parse(split[0]);
            Action = split[1];
            Time = int.Parse(split[2]);
        }
    }
}