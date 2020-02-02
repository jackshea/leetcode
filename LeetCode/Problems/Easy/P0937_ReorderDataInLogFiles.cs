using System;

namespace LeetCode.Problems.Easy
{
    /// 重新排列日志文件
    /// https://leetcode-cn.com/problems/reorder-data-in-log-files/
    public class P0937_ReorderDataInLogFiles
    {
        public string[] ReorderLogFiles(string[] logs)
        {
            LogExInfo[] logExInfos = new LogExInfo[logs.Length];
            for (int i = 0; i < logs.Length; i++)
            {
                logExInfos[i] = getLogInfo(logs[i], i);
            }

            Array.Sort(logExInfos, (a, b) =>
            {
                if (a.Type != b.Type)
                {
                    return a.Type.CompareTo(b.Type);
                }

                if (a.Type == LogType.LETTERS)
                {
                    if (a.Content != b.Content)
                    {
                        return a.Content.CompareTo(b.Content);
                    }
                    else
                    {
                        return a.Key.CompareTo(b.Key);
                    }
                }
                else
                {
                    return a.RawIndex.CompareTo(b.RawIndex);
                }
            });
            for (int i = 0; i < logs.Length; i++)
            {
                logs[i] = logExInfos[i].RawLog;
            }

            return logs;
        }

        /// 日志类型
        public enum LogType
        {
            // 字母类型
            LETTERS,
            // 数字类型
            DIGIS
        }

        /// 日志信息
        public class LogExInfo
        {
            public LogType Type;
            public string Key;
            public string Content;
            public int RawIndex;
            public string RawLog;
        }

        /// 日志类型
        private LogExInfo getLogInfo(string log, int index)
        {
            var blankIndex = log.IndexOf(' ');
            var logExInfo = new LogExInfo();
            logExInfo.Key = log.Substring(0, blankIndex);
            logExInfo.Content = log.Substring(blankIndex + 1, log.Length - blankIndex - 1);
            if (char.IsDigit(log[blankIndex + 1]))
            {
                logExInfo.Type = LogType.DIGIS;
            }
            else
            {
                logExInfo.Type = LogType.LETTERS;
            }

            logExInfo.RawIndex = index;
            logExInfo.RawLog = log;

            return logExInfo;
        }
    }
}