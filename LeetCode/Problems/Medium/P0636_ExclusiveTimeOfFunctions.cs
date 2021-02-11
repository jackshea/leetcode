using System.Collections.Generic;

namespace LeetCode.Problems.Medium
{
    public class P0636_ExclusiveTimeOfFunctions
    {
        public int[] ExclusiveTime(int n, IList<string> logs)
        {
            int[] spends = new int[n];
            var preLog = new LogItem(logs[0]);

            for (int i = 1; i < logs.Count; i++)
            {
                var logItem = new LogItem(logs[i]);
                if (logItem.Action == "start")
                {
                    spends[preLog.Id] += logItem.Time - preLog.Time - (i == 1 ? 0 : 1);
                }
                else
                {
                    spends[logItem.Id] += logItem.Time - preLog.Time + (preLog.Action == "start" ? 1 : 0);
                }

                preLog = logItem;
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