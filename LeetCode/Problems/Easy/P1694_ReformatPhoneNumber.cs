using System.Collections.Generic;

namespace LeetCode.Problems.Easy
{
    /// 重新格式化电话号码
    /// https://leetcode-cn.com/problems/reformat-phone-number/
    public class P1694_ReformatPhoneNumber
    {
        public string ReformatNumber(string number)
        {
            List<char> numbers = new List<char>();
            int cnt = 0;
            foreach (var num in number)
            {
                if (num >= '0' && num <= '9')
                {
                    numbers.Add(num);
                    cnt++;
                    if (cnt % 3 == 0)
                    {
                        numbers.Add('-');
                    }
                }
            }

            switch (cnt % 3)
            {
                case 0:
                    numbers.RemoveAt(numbers.Count - 1);
                    break;
                case 1:
                    int a = numbers.Count - 3;
                    char c = numbers[a];
                    numbers[a] = numbers[a + 1];
                    numbers[a + 1] = c;
                    break;
            }

            return new string(numbers.ToArray());
        }
    }
}