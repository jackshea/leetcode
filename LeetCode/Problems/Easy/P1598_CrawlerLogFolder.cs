namespace LeetCode.Problems.Easy
{
    /// 文件夹操作日志搜集器
    /// https://leetcode-cn.com/problems/crawler-log-folder/
    public class P1598_CrawlerLogFolder
    {
        public int MinOperations(string[] logs)
        {
            int len = 0;
            foreach (var log in logs)
            {
                if (log == "../")
                {
                    if (len > 0)
                    {
                        len--;
                    }
                }
                else if (log == "./")
                {
                    continue;
                }
                else
                {
                    len++;
                }
            }

            return len;
        }
    }
}