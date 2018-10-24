using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Tools
{
    public static class Utils
    {
        public static string ListToString<T>(this IEnumerable<T> list)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("[");
            bool isFirst = true;
            foreach (var element in list)
            {
                if (!isFirst)
                {
                    sb.Append(", ");
                }

                isFirst = false;
                sb.Append(element);
            }

            sb.Append("]");
            return sb.ToString();
        }
    }
}