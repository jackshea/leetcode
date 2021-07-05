using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Problems.Hard
{
    /// 原子的数量
    /// https://leetcode-cn.com/problems/number-of-atoms/
    public class P0726_NumberOfAtoms
    {
        private int index = 0;
        public string CountOfAtoms(string formula)
        {
            Stack<Dictionary<string, int>> stack = new Stack<Dictionary<string, int>>();
            Dictionary<string, int> current = new Dictionary<string, int>();

            while (index < formula.Length)
            {
                var c = formula[index];
                if (c == '(')
                {
                    stack.Push(current);
                    current = new Dictionary<string, int>();
                    index++;
                }
                else if (c == ')')
                {
                    var top = stack.Pop();
                    index++;
                    int count = ReadNumber(formula);
                    var currentKeys = current.Keys.ToList();
                    foreach (var key in currentKeys)
                    {
                        current[key] *= count;
                        top.TryGetValue(key, out var cnt);
                        top[key] = current[key] + cnt;
                    }

                    current = top;
                }
                else
                {
                    string atom = ReadAtom(formula);
                    int count = ReadNumber(formula);
                    current.TryGetValue(atom, out var cnt);
                    current[atom] = cnt + count;
                }
            }

            StringBuilder sb = new StringBuilder();
            List<string> keys = current.Keys.ToList();
            keys.Sort();
            foreach (var key in keys)
            {
                sb.Append(key);
                sb.Append(current[key] <= 1 ? "" : current[key].ToString());
            }

            return sb.ToString();
        }

        private string ReadAtom(string formula)
        {
            StringBuilder sb = new StringBuilder();
            while (index < formula.Length)
            {
                char c = formula[index];
                if (c >= 'A' && c <= 'Z' && sb.Length == 0)
                {
                    sb.Append(c);
                    index++;
                }
                else if (c >= 'a' && c <= 'z')
                {
                    sb.Append(c);
                    index++;
                    break;
                }
                else
                {
                    break;
                }
            }

            return sb.ToString();
        }

        private int ReadNumber(string formula)
        {
            int num = 0;
            while (index < formula.Length)
            {
                char c = formula[index];
                if (char.IsDigit(c))
                {
                    num = num * 10 + c - '0';
                    index++;
                }
                else
                {
                    break;
                }
            }

            return num == 0 ? 1 : num;
        }
    }
}