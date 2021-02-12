using System.Collections.Generic;

namespace LeetCode.Problems.Medium
{
    public class P0636_ExclusiveTimeOfFunctions
    {
        public int[] ExclusiveTime(int n, IList<string> logs)
        {
            int[] spends = new int[n];
            Stack<LogItem> stack = new Stack<LogItem>();
            stack.Push(new LogItem(logs[0]));
            int preTime = stack.Peek().Time;

            for (int i = 1; i < logs.Count; i++)
            {
                var logItem = new LogItem(logs[i]);
                if (logItem.Action == "start")
                {
                    if (stack.Count != 0)
                    {
                        spends[stack.Peek().Id] += logItem.Time - preTime;
                    }
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
            public int Id;
            public string Action;
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
}