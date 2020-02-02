using System.Collections.Generic;

namespace LeetCode.Problems.Easy
{
    /// Fizz Buzz
    /// https://leetcode-cn.com/problems/fizz-buzz/
    public class P0412_FizzBuzz
    {
        public IList<string> FizzBuzz(int n)
        {
            List<string> result = new List<string>(n);
            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                    result.Add("FizzBuzz");
                else if (i % 3 == 0)
                    result.Add("Fizz");
                else if (i % 5 == 0)
                    result.Add("Buzz");
                else
                    result.Add(i.ToString());
            }

            return result;
        }
    }
}