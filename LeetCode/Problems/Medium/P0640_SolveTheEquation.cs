namespace LeetCode.Problems.Medium
{
    /// 求解方程
    /// https://leetcode-cn.com/problems/solve-the-equation/
    public class P0640_SolveTheEquation
    {
        private int xFactor;
        private int number;
        private int sign = 1;
        public string SolveEquation(string equation)
        {
            equation = equation.Replace("-", "+-");
            var items = equation.Split("+");
            foreach (var item in items)
            {
                if (item.Contains('='))
                {
                    var itemSplit = item.Split('=');
                    HandleItem(itemSplit[0]);
                    sign = -1;
                    HandleItem(itemSplit[1]);
                }
                else
                {
                    HandleItem(item);
                }
            }

            if (xFactor == 0 && number == 0)
            {
                return "Infinite solutions";
            }

            if (xFactor == 0 && number != 0)
            {
                return "No solution";
            }

            return "x=" + -number / xFactor;
        }

        private void HandleItem(string item)
        {
            if (string.IsNullOrEmpty(item))
            {
                return;
            }

            if (item.EndsWith('x'))
            {
                if (item == "-x")
                {
                    xFactor += -sign;
                }
                else if (item.Length > 1)
                {
                    xFactor += sign * int.Parse(item.Substring(0, item.Length - 1));
                }
                else
                {
                    xFactor += sign;
                }
            }
            else
            {
                number += sign * int.Parse(item);
            }
        }
    }
}