using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems.Easy
{
    /// 转变日期格式
    /// https://leetcode-cn.com/problems/reformat-date/
    public class P1507_ReformatDate
    {
        private Dictionary<string, int> monthDic = new Dictionary<string, int>
        {
            {"Jan",1 },
            {"Feb",2 },
            {"Mar",3 },
            {"Apr",4 },
            {"May",5 },
            {"Jun",6 },
            {"Jul",7 },
            {"Aug",8 },
            {"Sep",9 },
            {"Oct",10 },
            {"Nov",11 },
            {"Dec",12 }
        };

        public string ReformatDate(string date)
        {
            var dateSplit = date.Split(' ');
            StringBuilder sb = new StringBuilder();
            sb.Append(dateSplit[2]);
            sb.Append("-");
            sb.Append(GetMonth(dateSplit[1]));
            sb.Append("-");
            sb.Append(GetDay(dateSplit[0]));
            return sb.ToString();
        }

        private string GetDay(string day)
        {
            var ans = day.Substring(0, day.Length - 2);
            if (ans.Length == 1)
            {
                return "0" + ans;
            }
            return ans;
        }

        private string GetMonth(string month)
        {
            return monthDic[month].ToString("00");
        }
    }
}